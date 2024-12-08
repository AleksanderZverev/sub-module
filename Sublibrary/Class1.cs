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
///              P.S. Не хватает метода для стерания написанного
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

    public string? ReadLine()
    {
        var answer = Console.ReadLine();
        answer = answer?.Trim();
        return string.IsNullOrEmpty(answer)
            ? null 
            : answer;
    }
}