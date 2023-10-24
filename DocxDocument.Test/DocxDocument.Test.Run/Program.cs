var test = new DocxDocument.Test.ReadTest();
test.Output = Console.Out;
test.Initialize();
Console.WriteLine($"Opening directory: {test.SamplesPath}");
Console.WriteLine();
test.TestOpen();
test.TestReadProperties();
