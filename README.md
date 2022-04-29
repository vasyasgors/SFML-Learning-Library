# SFML Learning Library

Простая учебная надстройка над SFML позволяющая писать в функциональном стиле.

## Справка

### Структура программы

```
using System;
using SFML.Learning;

class Program : Game
{
    static void Main()
    {
        InitWindow(800, 600, "Meow");

        while (true)
        {
            // 1. Расчет
            DispatchEvents();

            // Игровая логика

            // 2. Очистка буфера и окна
            ClearWindow();

            // 3. Отрисовка буфера на окне

            // Вывозв методов отрисовки объектов

            DisplayWindow();

            // 4. Ожидание
            Delay(1);
        }
    }
}
```


### Окно

void InitWindow(uint width, uint height, string title = "untitled") - создает графическое окно с шириной, высотой и названием

void DispatchEvents() - опрашивает все устройства ввод. Обычно вызвается в начале каждого обновления.

void DisplayWindow() - отображает графический буфер на окне

void ClearWindow(byte r = 0, byte g = 0, byte b = 0) - очищаешь окно заданным цветом. Цвет задается компонентами RGB

void ClearWindow(Color color) - очищаешь окно заданным цветом. Цвет задается перечеслением типа SFML.Graphics.Color

void Delay(int ms) - приостанавливает программу на ms милисекунд

### Ввод

bool GetKey(Keyboard.Key key) - возвращает true если клавиша key нажата и удерживается
	
bool GetKeyDown(Keyboard.Key key) - возвращает true в момент опускания клавиши key

bool GetKeyUp(Keyboard.Key key) - возвращает true в момент подъема клавиши key

bool GetMouseButton(Mouse.Button button) - возвращает true в если клавиша мышки button нажата и удерживается

bool GetMouseButtonDown(Mouse.Button button) - возвращает true в момент опускания клавиши мышки button

bool GetMouseButtonUp(Mouse.Button button) - возвращает true в момент подъема клавиши мышки button
      
int MouseX - координата X указателя мышки относительно окна

int MouseY - координата Y указателя мышки относительно окна

### Рисование примитивов

void SetFillColor(byte red, byte green, byte blue) - Задает цвет рисования примитивово. Цвет задается компонентами RGB

void SetFillColor(Color color) - Задает цвет рисования примитивово. Цвет задается перечеслением типа SFML.Graphics.Color

void DrawLine(float x0, float y0, float x1, float y1, int width = 1) - Рисует линию от координат (x0, y10 до координат (x1, y1), с толщиной width

void FillCircle(float x, float y, float radius) - Закрашивает круг радиусом radius центр которого находится в (x, y)

void FillRectangle(float x, float y, float width, float height) - Закрашивает прямоугольник широной width и высотой height, левый верхний угол которого находится в (x, y)


### Спрайты и текстуры

string LoadTexture(string path) - загружает текстуру находящийся по пути path и возвращает индитификатор текстуры

void DrawSprite(string name float x, float y) - рисует спрайт с именем name, левый верхний угол которого находится (x, y)

void DrawSprite(string name, float x, float y, int left, int top, int width, int height) - рисует спрайт с именем name, левый верхний угол которого находится (x, y).
Параметры (left, top, width, height) задают отображаему область спрайта.

### Звуки и музыка

string LoadSound(string path) - загружает звук находящийся по пути path и возвращает индитификатор звука

void PlaySound(string name) - воспроизводит звук с именем name

void PlaySound(string name, float volume) - воспроизводит звук с именем name и громкость volume. Громкость меняется от 0 до 100.

string LoadMusic(string path) - загружает музыку находящийся по пути path и возвращает индитификатор музыки

void PlayMusic(string name) -  воспроизводит музыку с именем name

void PlayMusic(string name, float volume) - воспроизводит музыку с именем name и громкость volume. Громкость меняется от 0 до 100.

void StopMusic(string name) - останавливает музыку с именем name

#### Важно! Библиотека поддерживает только формат .wav

### Текст

void SetFont(string path) - устанавливает шрифт для всех надписей находящийся по пути path 

void DrawText(int x, int y, string text, uint size = 12) - отображает строку text в левый верхний угол которого находится в координатах (x, y) размером size
