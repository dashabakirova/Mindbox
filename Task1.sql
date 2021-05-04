SELECT Products.name, Categories.name
FROM Products LEFT JOIN  Categories ON Product.id=Category.productId 
ORDER BY Products.name;