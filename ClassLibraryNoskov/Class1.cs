using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryNoskov
{
    public class Class1
    {
        public List<string> history = new List<string>();


        public double Convert_To_Fareng_From_Cels(double Cels)
        {
            double ConvertFar = (Cels * 1.8) + 32;
            history.Add($"Перевод из Цельсии в Фаренгейты: {ConvertFar}");
            return ConvertFar;
        }


        public double Convert_To_Cels_From_Fareng(double Fareng)
        {
            double ConvertCels = (Fareng - 32) / 1.8;
            history.Add($"Перевод из Фаренгейтов в Цельсии: {ConvertCels}");
            return ConvertCels;
        }


        public double Convert_To_Sajen_From_Metrе(double Metre)
        {
            double ConvertSajen = Metre * 0.4686914;
            history.Add($"Перевод из Метров в Сажени: {ConvertSajen}");
            return ConvertSajen;
        }


        public double Convert_To_Metre_From_Sajen(double Sajen)
        {
            double ConvertMetre = Sajen * 2.1336;
            history.Add($"Перевод из Саженей в Метры: {ConvertMetre}");
            return ConvertMetre;
        }


        public double Convert_To_Kilogram_From_Pound(double Pound)
        {
            double ConvertKilogram = Pound * 0.45359237;
            history.Add($"Перевод из Фунтов в Килограммы: {ConvertKilogram}");
            return ConvertKilogram;
        }


        public double Convert_To_Pound_From_Kilogram(double Kilogram)
        { 
            double ConvertPound = Kilogram * 2.20462;
            history.Add($"Перевод из Килограмм в Фунты: {ConvertPound}");
            return ConvertPound;
        }


        public string[] GetHistory()
        {
            return history.ToArray();
        }


        public void ClearHistory()
        {
            history.Clear();
        }

    }      

    
}
