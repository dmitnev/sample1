//Console.WriteLine("Hello, World!");

using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    private static async Task Main(string[] args)
    {
        string path = "sampleNote.txt";
        
        using (StreamWriter writer = new StreamWriter(path, false))
        {
            await writer.WriteLineAsync();
        }
        using (StreamWriter writer = new StreamWriter(path, true))
        {

            Console.Write("Введите имя: ");
            string? name = Console.ReadLine();

            Console.Write("Введите возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите рост: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите размер зарплаты: ");
            decimal salary = Convert.ToDecimal(Console.ReadLine());


//Вывод веденых данных в консоль. Update to "SAVE TXT"
            Console.WriteLine($"Имя: {name}  Возраст: {age}  Рост: {height}м  Зарплата: {salary}$");

        }
    }
}

/*              Теория

Особенностью метода Console.ReadLine() является то, что он может считать информацию с консоли 
только в виде строки. Кроме того, возможная ситуация, когда для метода Console.ReadLine не окажется 
доступных для считывания строк, то есть когда ему нечего считывать, он возвращаает значение null, то есть, 
грубо говоря, фактически отсутствие значения. И чтобы отразить эту ситуацию мы определяем переменную name, в 
которую получаем ввод с консоли, как переменную типа string?. Здесь string указывает, что переменная 
может хранить значения типа string, то есть строки. А знак вопроса ? указывает, что переменная также
 может хранить значение null, то есть по сути не иметь никакого значения. Далее мы более подробно 
 разберем null и как с ним работать.

Однако, может возникнуть вопрос, как нам быть, если, допустим, мы хотим ввести возраст в переменную 
типа int или другую информацию в переменные типа double или decimal? По умолчанию платформа .NET 
предоставляет ряд методов, которые позволяют преобразовать различные значения к типам int, double и т.д. 
Некоторые из этих методов:

    Convert.ToInt32() (преобразует к типу int)

    Convert.ToDouble() (преобразует к типу double)

    Convert.ToDecimal() (преобразует к типу decimal)*/