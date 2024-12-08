namespace Sublibrary;

/// <summary>
/// Документация
///
/// Описание:
/// Используется для вывода текста в консоль
///
/// Обратить внимание:
/// По умолчанию цвет текста белый
///
/// Отзывы от разработчиков:
/// А.А. Зверев: Классная либа! Спасибо!
/// </summary>
public class Library
{
    private readonly ConsoleColor color;

    public Library(ConsoleColor color = ConsoleColor.White)
    {
        this.color = color;
    }

    public void WritLine(string input)
    {
        InColor(color, () => Console.WriteLine(input));
    }

    public void Write(string input)
    {
        InColor(color, () => Console.Write(input));
    }

    private void InColor(ConsoleColor color, Action write)
    {
        var oldColor = Console.ForegroundColor;
        Console.ForegroundColor = color;
        write();
        Console.ForegroundColor = oldColor;
    }
}