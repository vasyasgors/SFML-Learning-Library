using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFML.Learning
{
    class Program : Game
    {
        static void Main()
        {
               
            InitWindow(800, 600, "Meow");
            SetWindowMode(WindowMode.Resizable);

            int px = MouseX, py = MouseY;

            while (true)
            {
                // 1. Расчет
                DispatchEvents();

                // Игровая логика

                // 2. Очистка буфера и окна
                //ClearWindow();

                // 3. Отрисовка буфера на окне

                if (GetMouseButton(0) == true)
                    FillRectangle(MouseX, MouseY,  100, 100);


                
                // Вызов методов отрисовки объектов

                DisplayWindow();

                px = MouseX;
                py = MouseY;

                // 4. Ожидание
                //Delay(1);
            }
        }
    }
}

