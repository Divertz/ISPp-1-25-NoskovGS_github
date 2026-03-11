using ClassLibraryNoskov;
namespace TestUnit_Noskov
{
    public class UnitTest1
    {
        [Fact]
        //1
        public void Convert_To_Cels()
        {
            //Arrange - Подготовка
            double Cels = 10.5;
            Class1 conv = new Class1();
            //Act - Действие
            double result = conv.Convert_To_Fareng_From_Cels(Cels);
            result = Math.Round(result, 2);
            //Assert - Проверка
            Assert.Equal(50.9, result);
        }


        [Fact]
        //2
        public void Convert_To_Far()
        {
            //Arrange - Подготовка
            double Fareng = 10.5;
        Class1 conv = new Class1();
            //Act - Действие
            double result = conv.Convert_To_Cels_From_Fareng(Fareng);
            result = Math.Round(result, 2);
            //Assert - Проверка
            Assert.Equal(-11.94, result);
        }


        [Fact]
        //3
        public void Convert_To_Sajen()
        {
            //Arrange - Подготовка
            double Metre = 30.3;
            Class1 conv = new Class1();
            //Act - Действие
            double result = conv.Convert_To_Sajen_From_Metrе(Metre);
            result = Math.Round(result, 2);
            //Assert - Проверка
            Assert.Equal(14.2, result);
        }


        [Fact]
        //4
        public void Convert_To_Metre()
        {
            //Arrange - Подготовка
            double Sajen = 30.8;
            Class1 conv = new Class1();
            //Act - Действие
            double result = conv.Convert_To_Metre_From_Sajen(Sajen);
            result = Math.Round(result, 2);
            //Assert - Проверка
            Assert.Equal(65.71, result);
        }


        [Fact]
        //5
        public void Convert_To_Kilogram()
        {
            //Arrange - Подготовка
            double Pound = 75;
            Class1 conv = new Class1();
            //Act - Действие
            double result = conv.Convert_To_Kilogram_From_Pound(Pound);
            result = Math.Round(result, 2);
            //Assert - Проверка
            Assert.Equal(34.02, result);           
        }



        [Fact]
        //6
        public void Convert_To_Pound()
        {
            //Arrange - Подготовка
            double Kilogram = 100;
            Class1 conv = new Class1();
            //Act - Действие
            double result = conv.Convert_To_Pound_From_Kilogram(Kilogram);
            result = Math.Round(result, 2);
            //Assert - Проверка
            Assert.Equal(220.46, result);
        }


        [Fact]
        //7
        public void HistoryIsEmpty()
        {
            //Arrange - Подготовка
            double a = 50;
            Class1 conv = new Class1();
            //Act - Действие
            conv.ClearHistory();
            //Assert - Проверка
            Assert.Empty(conv.history);
        }


        [Fact]
        //8
        public void HistoryIsNotEmpty()
        {
            //Arrange - Подготовка
            double a = 50;
            Class1 conv = new Class1();
            //Act - Действие
            conv.Convert_To_Fareng_From_Cels(a);
            //Assert - Проверка
            Assert.NotEmpty(conv.history);

        }


        [Fact]
        //9
        public void HistoryIsEmptyAgain()
        {
            //Arrange - Подготовка
            double a = 50;
            Class1 conv = new Class1();
            //Act - Действие
            conv.Convert_To_Fareng_From_Cels(a);
            conv.Convert_To_Cels_From_Fareng(a);
            conv.Convert_To_Sajen_From_Metrе(a);
            conv.Convert_To_Metre_From_Sajen(a);
            conv.Convert_To_Kilogram_From_Pound(a);
            conv.Convert_To_Pound_From_Kilogram(a);
            conv.ClearHistory();
            //Assert - Проверка
            Assert.Empty(conv.history);
        }

    }
}