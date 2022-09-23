namespace ValidationEmail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n---------- Sample Email Validation------------");
            SampleEmailValidation sampleEmailValidation = new SampleEmailValidation();
            sampleEmailValidation.Email("abc@yahoo.com");
            sampleEmailValidation.Email1("abc-100@yahoo.com");
            sampleEmailValidation.Email2("abc.100@yahoo.com");
            sampleEmailValidation.Email3("abc111@abc.com");
            sampleEmailValidation.Email4("abc@");
            sampleEmailValidation.Email5("abc@.com.my");
        }
    }
}