CREATE FUNCTION [dbo].ValidateUserLogin
(
	@username varchar(20),
	@pwd varchar(20)
)
RETURNS bit
AS

BEGIN
declare
@v_uname varchar(50),
@v_pwd varchar(50),
@v_status bit

select @v_uname=username,@v_pwd=password from UserData
where username=@username ;
if (@pwd=@v_pwd)
begin
set @v_status=0
end
else 
begin
set @v_status=1
end
	return @v_status;
END