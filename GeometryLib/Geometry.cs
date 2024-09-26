using GeometryLib.Interfaces;

namespace GeometryLib;

public static class ShapeAreaCalculator
{
    public static double CalculateArea(IShape shape)
    {
        return shape.GetArea();
    }
}

/*
-- Запрос для выбора всех пар «Имя продукта – Имя категории»
SELECT 
    p.ProductName AS ProductName,
    c.CategoryName AS CategoryName
FROM 
    Products p
LEFT JOIN 
    ProductCategories pc ON p.ProductID = pc.ProductID
LEFT JOIN 
    Categories c ON pc.CategoryID = c.CategoryID
ORDER BY 
    p.ProductName, c.CategoryName;
 */
