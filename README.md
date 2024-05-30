
## Решение задания на стажировку от MindBox

### Содержание
- [Постановка задачи про площадь фигур](#постановка-задачи-про-площадь-фигур )
- [Объяснение решения](#объяснение-решения)
    - [Основные методы классов проекта MindboxTask](#основные-методы-классов-проекта-MindboxTask)
    - [Классы Unit-тестов проекта MindboxTaskTests](#классы-Unit-тестов-проекта-MindboxTaskTests)
- [Задание про SQL-запрос](#задание-про-SQL-запрос)
- [Приложение](#приложение)

### Постановка задачи про площадь фигур

Написать на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оцениваются:
- Юнит-тесты
- Легкость добавления других фигур
- Вычисление площади фигуры без знания типа фигуры в compile-time
- Проверку на то, является ли треугольник прямоугольным

### Объяснение решения

Для реализации нужного функционала можно было бы использовать, например, абстрактный класс *Shape*. Но это вводило бы определённые ограничения, например, если нужно будет создать класс, который не является фигурой, но у него может быть высчитана площадь, то такое наследование было бы логически неправильным.

*К примеру, класс Sprite, это вроде не фигура, но иногда нужна площадь.*

К тому же, не совсем понятно зачем создавать класс Фигуры, если в нём будет только метод подсчёта площади, ведь фигура обладает и другими свойствами, не только площадью.

Поэтому было принято решение создать интерфейс *IHasArea*, его название будет полностью отражать его функционал (и будет соблюдён принцип единственной ответственности), а также это избавит от проблемы с наследованием, ведь реализация интерфейса не так сильно логически связывает классы.

Класс AreaCalculator является обобщённым, это позволяет получать тип объекта в compile-time. Если использовать обычный класс, то тип будет определяться в runtime.

Это позволит соблюсти требования к заданию, а именно
> Легкость добавления других фигур  
> Вычисление площади фигуры без знания типа фигуры в compile-time

#### Основные методы классов проекта MindboxTask:
```csharp  
interface IHasArea  
 + GetArea()  

class Circle : IHasArea  
 + GetArea()  

class Trianlge : IHasArea  
 + GetArea()
 + IsRightTriangle()
  
static class AreaCalculator<T> where T : IHasArea  
 + CalculateArea(T hasArea)  
```  
Подробнее см. [MindboxTask](MindboxTask/)

#### Классы Unit-тестов проекта MindboxTaskTests:
```csharp  
class CircleTests  
 + Circle_NegativeRadius_ThrowsArgumentException() 
 + GetArea_Radius10_Returns10Pi() 
 + GetArea_ZeroRadius_ReturnsZero()  

class TriangleTests  
 + Triangle_NegativeSide_ThrowsArgumentException()
 + GetArea_Sides3And4And5_Returns25()
 + GetArea_EqualSides_ReturnsCorrectArea()
 + GetPerimeter_Sides10And20And30_Returns60()
 + IsRightTriangle_Sides3And4And5_ReturnsTrue()
 + IsRightTriangle_EqualSides_ReturnsFalse()
 + GetSidesDescending_Sides8And2And5_ReturnsSidesInDescendingOrder()  

class AreaCalculatorTests  
 + CalculateArea_CircleWithRadius10_Returns100Pi()
 + CalculateArea_TriangleWithSides3And4And5_Returns6()  
```  
Подробнее см. [MindboxTaskTests](MindboxTaskTests/)
Для реализации *Unit-тестов* был использован фреймворк *NUnit 3*.

### Задание про SQL-запрос
Допустим, у нас такая структура базы данных:
- Таблица *Products*:
    - ProductID
    - ProductName
- Таблица *Categories*:
    - CategoryID
    - CategoryName
- Таблица *ProductCategories*:
    - ProductID (reference)
    - CategoryID (reference)

Тогда решением будет такой SQL-запрос. Он использует join, чтобы объединить таблицы по нужным нам критериям. В данном случае мы из таблицы с числами (id) делаем таблицу с именами продуктов и категорий, которые имеют данный id.
```sql
select p.ProductName, c.CategoryName
from Products p
join ProductCategories pc on p.ProductID = pc.ProductID
join Categories c on pc.CategoryID = c.CategoryID;
```

### Приложение
В папке [Additions](Additions/) находится "Резюме" с дополнительной информацией обо мне и примерами *учебных* проектов.
