﻿Module Module1
    Sub Main()
        'Assignment: For every datatype, create a variable, assign it a value and output it to the console

        'Boolean - True or False values [used in conditional statements and logical operations]
        Dim isBeginnerProgrammer As Boolean = False
        Console.WriteLine($"isBeginner = {isBeginnerProgrammer}")

        'Byte - small integer values [positive numbers from 0 to 255] [1 byte]
        Dim numberOfChildren As Byte = 4
        Console.WriteLine($"Number of Children = {numberOfChildren}")

        'Char - individual unicode characters [positive values from 0 to 65_535] [2 bytes]
        Dim gravitationalConstant As Char = "G"c
        Console.WriteLine($"Gravitational Constant = {gravitationalConstant}")

        'Date - stores date and time [from January 1, 0001 to December 31, 9999] [8 bytes]
        Dim dateOfAdmission As Date = #2018-09-04#
        Console.WriteLine($"Date of Admission: {dateOfAdmission}")

        'Decimal - used when precision is critical (financial and scientific calculations) [16 bytes]
        Dim accountBalance As Decimal = 250_000.638954609234 'GHC
        Console.WriteLine($"Account Balance = {accountBalance}")

        'Double - general purpose floating point number [for both positive and negative values] [8 bytes]
        Dim circumfrence As Double = 27.342857142857142 'radius = 4.35
        Console.WriteLine($"Circumfrence of circle = {circumfrence}")

        'Integer - storing whole numbers, positive and negative [(-2,147,483,648) to (2,147,483,647)] [4 bytes]
        Dim currentNetWorth As Integer = 2_000_000_000 'USD
        Console.WriteLine($"Current Net Worth = {currentNetWorth}")

        'Long - large whole numbers beyond the range of integers [signed] [8 bytes]
        Dim nationalDebt As Long = 40_000_000_000_000 'USD
        Console.WriteLine($"Ghana's national debt = {nationalDebt}")

        'Object - store any type of data [provides flexibility] [4 bytes - 32_bit_pc] [8 bytes - 64_bit_pc]
        Dim myObj As Object = "This is an object" 'string object
        Console.WriteLine($"Object can be a string -> {myObj}")
        myObj = 23 'byte object
        Console.WriteLine($"Object can be a number(byte) -> {myObj}")
        myObj = True 'boolean object
        Console.WriteLine($"Object can be a boolean -> {myObj}")
        myObj = 3.142 'single object
        Console.WriteLine($"Object can be a single -> {myObj}")
        Console.WriteLine("NB://Object datatype can store any other datatype")

        'SByte - small signed integer values [-128 to 127] [1 byte] [signed]
        Dim outputEfficiency As SByte = -78 '%
        Console.WriteLine($"Output Efficency = {outputEfficiency}")

        'Short - short signed integer values [2 bytes] [signed]
        Dim milesOnCar As Short = 15_000 'miles
        Console.WriteLine($"Miles left on car = {milesOnCar}")

        'Single - floating point numbers with lower precision [4 bytes] [signed]
        Dim temperatureInDegrees As Single = -4.344 'degrees
        Console.WriteLine($"Current Temperature = {temperatureInDegrees}")

        'String - represents any sequence of characters [approx. 2 billion unicode characters]
        Dim stMyName As String = "Christian Solomon"
        Console.WriteLine($"Name = {stMyName}")

        'UInteger - large unsigned integer whole numbers [4 bytes] [ 0 to 4,294,967,295 ]
        Dim annualRevenue As UInteger = 4_967_295
        Console.WriteLine($"Annual revenue = {annualRevenue}")

        'ULong - large unsigned whole numbers beyond the range of UInteger [8 bytes]
        Dim lightYearInKilometers As ULong = 9_460_730_500_000 'km [approximation]
        Console.WriteLine($"Lightyear in kilometers(approx.) = {lightYearInKilometers}")

        'UShort - represents short unsigned whole numbers [2 bytes] [0 to 65_535]
        Dim studentPopulation As UShort = 60_000 'students
        Console.WriteLine($"Student Population = {studentPopulation}")

        'User-Defined - (like structures in C programming language)[Platform Dependent]
        '   used to create custom datatypes using structures to encapsulate related data
        Dim studentOne As StudentStructure
        studentOne.stName = "Michael Asante"
        studentOne.nAge = 23 'years
        studentOne.bCompleted = True
        Console.WriteLine($"The student {studentOne.stName} is {studentOne.nAge} years of age, and has 'isCmpleted' status set to {studentOne.bCompleted}")
        Console.ReadKey(True)
    End Sub

    Structure StudentStructure
        Public stName As String
        Public nAge As SByte
        Public bCompleted As Boolean
    End Structure
End Module