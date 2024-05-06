internal class Program
{

    private static void Main(string[] args)
    {
        //Thực hành chuyển đổi nhiệt độ
        Console.Write("Nhập độ Celsius: ");
        float celsius = float.Parse(Console.ReadLine());
        float fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine($"{celsius} độ Celsius = {fahrenheit} độ Fahrenheit");

        //Thực hành game đoán số
        Random random = new Random();
        int secretNumber = random.Next(1, 101);
        Console.WriteLine("Chào mừng đến với trò chơi đoán số!");
        Console.WriteLine("Tôi đã chọn một số từ 1 đến 100. Hãy cố gắng đoán nó!");
        int guess = 0;
        int attempts = 0;
        while (guess != secretNumber && attempts < 5)
        {
            Console.Write("Nhập số đoán của bạn: ");
            guess = int.Parse(Console.ReadLine());
            attempts++;
            if (guess < secretNumber)
            {
                Console.WriteLine("Số bạn đoán nhỏ hơn số bí mật.");
            }
            else if (guess > secretNumber)
            {
                Console.WriteLine("Số bạn đoán lớn hơn số bí mật.");
            }
            else
            {
                Console.WriteLine("Chúc mừng! Bạn đã đoán đúng số bí mật!");
                break;
            }
        }
        if (guess != secretNumber)
        {
            Console.WriteLine($"Bạn đã hết số lần đoán. Số bí mật là: {secretNumber}");
        }

        //Bài tập tính điểm trung bình
        System.Console.WriteLine("Enter math point: ");
        int mathPoint = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter chemestry point: ");
        int chemestry = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter history point: ");
        int history = int.Parse(Console.ReadLine());
        int averagePoint = (mathPoint + chemestry + history) / 3;
        System.Console.WriteLine("Average point is: " + averagePoint);

        //Bài tập chuyển đổi tiền tệ
        double vnd = 23000;
        double usd;
        System.Console.Write("Enter USD: ");
        double result = (usd = double.Parse(Console.ReadLine())) * vnd;
        System.Console.WriteLine(usd + " USD after convert in to VND is: " + result);

        //Bài tập tìm số lớn nhất 
        System.Console.WriteLine("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());
        int max = firstNumber;
        if (secondNumber > max)
        {
            max = secondNumber;
        }
        if (thirdNumber > max)
        {
            max = thirdNumber;
        }
        System.Console.WriteLine("Biggest number is: " + max);
    }
}