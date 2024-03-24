# Maoltech OTP Generator

Maoltech OTP Generator is a simple library for generating one-time passwords (OTPs) in various formats including numeric, alphanumeric, and alphabetic. It provides a convenient way to generate secure OTPs for authentication, verification, or any other use case where temporary codes are required.

## Installation

You can install the Maoltech OTP Generator NuGet package via the NuGet Package Manager Console:

```bash
Install-Package Maoltech_Otp_Generator
```

Or using the .NET CLI:

```bash
dotnet add package Maoltech_Otp_Generator
```

## Usage
Once installed, you can use the Maoltech_Otp_Generator class to generate OTPs of different types and lengths. Here's a basic example:

```bash
using maoltech_otp_generator;

class Program
{
    static void Main(string[] args)
    {
        Maoltech_Otp_Generator otpGenerator = new Maoltech_Otp_Generator();
        
        // Generate a numeric OTP of length 6
        string numericOtp = otpGenerator.GenerateToken(6, "numeric");
        Console.WriteLine("Numeric OTP: " + numericOtp);
        
        // Generate an alphanumeric OTP of length 8
        string alphanumericOtp = otpGenerator.GenerateToken(8, "alphanumeric");
        Console.WriteLine("Alphanumeric OTP: " + alphanumericOtp);
        
        // Generate an alphabetic OTP of length 4
        string alphabeticOtp = otpGenerator.GenerateToken(4, "alphabetic");
        Console.WriteLine("Alphabetic OTP: " + alphabeticOtp);
    }
}
```

## Supported Token Types
The Maoltech OTP Generator supports the following token types:

numeric: Contains only numeric characters (0-9).
alphanumeric: Contains alphanumeric characters (A-Z, a-z, and 0-9).
alphabetic: Contains only alphabetic characters (A-Z and a-z).

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

## Github Repository
https://github.com/maoltech/maoltech-nutget-generate-otp.git