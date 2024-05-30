﻿namespace MindboxTask;

class Program
{
    // Также, в ситуации если нам не нужно создавать объекты классов, можно было бы воспользоваться перечислением.
    // Тогда в классе AreaCalculator будет метод, который принимает значение enum'а, и данные о фигуре.
    // Но будет вопрос как передавать данные о фигуре: можно передавать словарь с определёнными ключами,
    // но тогда имена этих ключей будут как бы захардкожены (можно сдлеать ещё один enum, в котором будут такие
    // значения ключей такие, как radius, sideA, sideB ... )
    // Либо можно создать класс, который хранил бы информацию о фигурах, но в этом есть смысл только если мы будем
    // создавать объекты этого класса только непосредственно при вызове метода вычисления площади, ведь иначе в чем 
    // разница с просто объктами фигур.
    
    static void Main(string[] args)
    {
        
    }
}