CREATE OR REPLACE FUNCTION test.test01(v_name text, v_birthday_from timestamp , v_birthday_to timestamp, v_address text)
    RETURNS SETOF test.company AS $$

declare
_sql text := 'SELECT * FROM test.company';
_where text;

BEGIN

_where := concat_ws(' AND '
       , CASE WHEN v_name IS NOT NULL THEN 'name like ''' || '%' || v_name || '%'''                  END
       , CASE WHEN v_birthday_from IS NOT NULL THEN 'birthday >= ''' || v_birthday_from || ''''          END
       , CASE WHEN v_birthday_to IS NOT NULL THEN 'birthday <= ''' || v_birthday_to || ''''           END
       , CASE WHEN v_address IS NOT NULL THEN 'address like ''' || '%' || v_address || '%'''           END);

	IF _where <> '' THEN
   		_sql := _sql || ' WHERE ' || _where;
	END IF;

    RETURN QUERY EXECUTE _sql;
END

$$ LANGUAGE PLpgSQL;