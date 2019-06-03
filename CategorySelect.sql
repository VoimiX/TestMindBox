/*В базе данных MS SQL Server есть продукты и категории. 
Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов.
 Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.
 */

 select p.Name, c.Category from Product p 
 left join CategoryProduct cp on p.ProductId = cp.ProductId
 left join Category c on c.CategoryId = cp.CategoryId


