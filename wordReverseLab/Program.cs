Console.WriteLine("Welcome to the word reverser!");
bool retry = true;
while (retry)
{
    //ask for user input
    Console.WriteLine("Please enter a line to reverse: ");
    try
    {
        string input = Console.ReadLine().Trim();
        if (!input.All(c => char.IsLetter(c) || c == ' '))
        {
            throw new Exception("Please enter words only, symbols and numbers not allowed.");
        }
        retry = false;
        List<string> words = input.Split(" ").ToList();
        //reverse word
        Console.WriteLine("Your entry reversed is: ");
        words.ForEach(w => Console.Write(reverse(w)));
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

//make method to reverse using stack
static string reverse(string word)
{
    Stack<char> stack = new Stack<char>();
    foreach (char c in word)    
    {
        stack.Push(c);
    }
    word = "";
    while(stack.Count > 0)
    {
        word += stack.Pop();
    }
    return word + " ";
}