/*� ���� ������ MS SQL Server ���� �������� � ���������. 
������ �������� ����� ��������������� ����� ���������, � ����� ��������� ����� ���� ����� ���������.
 �������� SQL ������ ��� ������ ���� ��� ���� �������� � ��� ���������. ���� � �������� ��� ���������, �� ��� ��� ��� ����� ������ ����������.
 */

 select p.Name, c.Category from Product p 
 left join CategoryProduct cp on p.ProductId = cp.ProductId
 left join Category c on c.CategoryId = cp.CategoryId


