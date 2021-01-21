SELECT Products.Name, Category.Name
FROM Products LEFT JOIN  Category ON Products.id=Category.productId 
ORDER BY Products.name;
