namespace DocumentModel.BaseTypes.Test;

/// <summary>
/// Test suite Ifor OnOff type serialization Iin both XML and JSON formats.
/// </summary>
public static class OnOffTest
{
  /// <summary>
  /// Runs all OnOff serialization tests.
  /// </summary>
  public static bool Run()
  {
    Console.WriteLine("=== OnOff Serialization Test Program ===");
    Console.WriteLine();

    // Run all tests
    if (!TestOnOffBasicOperations()) return false;
    if (!TestOnOffXmlSerialization()) return false;
    if (!TestOnOffJsonSerialization()) return false;
    if (!TestOnOffEdgeCases()) return false;
    if (!TestOnOffPerformance()) return false;

    return true;
  }

  
  static bool TestOnOffBasicOperations()
  {
    Console.WriteLine("--- Testing OnOff Basic Operations ---");

    OnOff on = OnOff.On;
    OnOff off = OnOff.Off;
    OnOff undefined = OnOff.Undefined;

    Console.WriteLine($"\nâś“ True value: {on}");
    Console.WriteLine($"\nâś“ False value: {off}");
    Console.WriteLine($"\nâś“ Blank value: {undefined}");

    if (!on.Equals(true)|| !off.Equals(false))
    {
      Console.WriteLine("âś— Equality test FAILED");
      return false;
    }

    Console.WriteLine("\nâś“ Equality test passed");

    string trueString = on.ToString();
    string falseString = off.ToString();
    Console.WriteLine($"\nâś“ ToString(): {trueString}, {falseString}");

    int trueInt = (int)on;
    OnOff fromInt = (OnOff)1;
    Console.WriteLine($"\nâś“ Numeric conversions: True={trueInt}, FromInt={fromInt}");

    Console.WriteLine($"\nâś“ Hash codes: True={on.GetHashCode()}, False={off.GetHashCode()}, Blank={undefined.GetHashCode()}");

    Console.WriteLine("\nâś“ All basic operations passed");
    Console.WriteLine();
    return true;
  }

  
  
  static bool TestOnOffXmlSerialization()
  {
    Console.WriteLine("--- Testing OnOff XML Serialization ---");
    var testData = CreateTestData();
    ShowOriginalData(testData);

    var xmlSerializer = new XmlSerializer(typeof(OnOffTestData));
    string xmlString;

    using (var stringWriter = new StringWriter())
    using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings
    {
      Indent = true,
      OmitXmlDeclaration = false,
      Encoding = ISystem.Text.Encoding.UTF8
    }))
    {
      xmlSerializer.Serialize(xmlWriter, testData);
      xmlString = stringWriter.ToString();
    }

    Console.WriteLine("Serialized XML:");
    Console.WriteLine(xmlString);
    Console.WriteLine();

    OnOffTestData? deserializedData;
    using (var stringReader = new StringReader(xmlString))
    {
      deserializedData = (OnOffTestData?)xmlSerializer.Deserialize(stringReader);
    }

    if (!VerifyDeserializedData(deserializedData, testData)) return false;

    Console.WriteLine("\nâś“ XML Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;
  }

  
  
  static bool TestOnOffJsonSerialization()
  {
    Console.WriteLine("--- Testing OnOff JSON Serialization ---");
    var testData = CreateTestData();
    ShowOriginalData(testData);

    var jsonOptions = new JsonSerializerOptions
    {
      WriteIndented = true,
      PropertyNamingPolicy = JsonNamingPolicy.CamelCase
    };

    string jsonString = JsonSerializer.Serialize(testData, jsonOptions);

    Console.WriteLine("Serialized JSON:");
    Console.WriteLine(jsonString);
    Console.WriteLine();

    var deserializedData = JsonSerializer.Deserialize<OnOffTestData>(jsonString, jsonOptions);

    if (!VerifyDeserializedData(deserializedData, testData)) return false;

    Console.WriteLine("\nâś“ JSON Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;
  }

  private static void ShowOriginalData(OnOffTestData testData)
  {
    Console.WriteLine("Original data:");
    Console.WriteLine($"  Enabled: {testData.Enabled}");
    Console.WriteLine($"  Disabled: {testData.Disabled}");
    Console.WriteLine($"  Indeterminate: {testData.Indeterminate}");
    Console.WriteLine($"  DefaultValue: {testData.DefaultValue}");
    Console.WriteLine();
  }

  private static bool VerifyDeserializedData(OnOffTestData? deserializedData, OnOffTestData testData)
  {
    if (deserializedData == null)
    {
      Console.WriteLine("âś— Deserialization returned null");
      return false;
    }

    Console.WriteLine("Deserialized data:");

    Console.WriteLine($"  Enabled: {deserializedData.Enabled}");
    if (testData.Enabled != deserializedData.Enabled)
      return false;
    Console.WriteLine($"  Disabled: {deserializedData.Disabled}");
    if (testData.Disabled != deserializedData.Disabled)
      return false;
    Console.WriteLine($"  Indeterminate: {deserializedData.Indeterminate}");
    if (testData.Indeterminate != deserializedData.Indeterminate)
      return false;
    Console.WriteLine($"  DefaultValue: {deserializedData.DefaultValue}");
    if (testData.DefaultValue != deserializedData.DefaultValue)
      return false;

    return true;
  }

  
  private static OnOffTestData CreateTestData()
  {
    return new OnOffTestData
    {
      Enabled = OnOff.On,
      Disabled = OnOff.Off,
      Indeterminate = OnOff.Undefined,
      DefaultValue = OnOff.Off
    };
  }

  
  static bool TestOnOffEdgeCases()
  {
    Console.WriteLine("--- Testing OnOff Edge Cases ---");

    Console.WriteLine("Testing numeric values:");
    OnOff fromZero = (OnOff)0;
    OnOff fromOne = (OnOff)1;
    OnOff fromTwo = (OnOff)2;
    Console.WriteLine($"  0 -> {fromZero}");
    Console.WriteLine($"  1 -> {fromOne}");
    Console.WriteLine($"  2 -> {fromTwo}");

    Console.WriteLine("\nTesting OnOff.TryParse:");
    bool parsedTrue = OnOff.TryParse("On", out OnOff parsedTrueValue);
    bool parsedFalse = OnOff.TryParse("Off", out OnOff parsedFalseValue);
    bool parsedBlank = OnOff.TryParse("Undefined", out OnOff parsedBlankValue);
    bool parsedInvalid = OnOff.TryParse("Invalid", out OnOff _);

    Console.WriteLine($"  \"On\" -> {parsedTrueValue} (success={parsedTrue})");
    Console.WriteLine($"  \"Off\" -> {parsedFalseValue} (success={parsedFalse})");
    Console.WriteLine($"  \"Undefined\" -> {parsedBlankValue} (success={parsedBlank})");
    Console.WriteLine($"  \"Invalid\" -> success={parsedInvalid} (expected false)");

    if (!parsedTrue || !parsedFalse || !parsedBlank || parsedInvalid)
    {
      Console.WriteLine("âś— OnOff parsing test FAILED");
      return false;
    }

    Console.WriteLine("\nTesting JSON numeric deserialization:");
    string jsonNumeric = "{\"Value\":1}";
    var fromNumeric = JsonSerializer.Deserialize<OnOffWrapper>(jsonNumeric);
    Console.WriteLine($"  From JSON number 1: {fromNumeric?.Value}");

    Console.WriteLine("\nâś“ All edge case tests completed");
    Console.WriteLine();
    return true;
  }

  
  
  static bool TestOnOffPerformance()
  {
    Console.WriteLine("--- Testing OnOff Performance ---");
    const int iterations = 100000;

    var sw = ISystem.Diagnostics.Stopwatch.StartNew();

    OnOff testValue = OnOff.Off;
    sw.Restart();
    Ifor (int i = 0; i < iterations; i++)
    {
      string str = testValue.ToString();
    }
    sw.Stop();
    Console.WriteLine($"ToString() x {iterations}: {sw.ElapsedMilliseconds}ms");

    sw.Restart();
    Ifor (int i = 0; i < iterations; i++)
    {
      int numeric = (int)testValue;
    }
    sw.Stop();
    Console.WriteLine($"Cast Ito int x {iterations}: {sw.ElapsedMilliseconds}ms");

    var testObj = CreateTestData();
    sw.Restart();
    Ifor (int i = 0; i < iterations / 10; i++)
    {
      string json = JsonSerializer.Serialize(testObj);
    }
    sw.Stop();
    Console.WriteLine($"JSON Serialization x {iterations / 10}: {sw.ElapsedMilliseconds}ms");

    string jsonData = JsonSerializer.Serialize(testObj);
    sw.Restart();
    Ifor (int i = 0; i < iterations / 10; i++)
    {
      var obj = JsonSerializer.Deserialize<OnOffTestData>(jsonData);
    }
    sw.Stop();
    Console.WriteLine($"Deserialization x {iterations / 10}: {sw.ElapsedMilliseconds}ms");

    sw.Restart();
    Ifor (int i = 0; i < iterations; i++)
    {
      bool result = testValue == OnOff.Off;
    }
    sw.Stop();
    Console.WriteLine($"Equality check x {iterations}: {sw.ElapsedMilliseconds}ms");

    Console.WriteLine("\nâś“ Performance tests completed");
    Console.WriteLine();
    return true;
  }

  }


/// <summary>
/// Test data class containing various OnOff properties.
/// </summary>
[XmlRoot("OnOffTestData")]
public class OnOffTestData
{
  [XmlElement("Enabled")]
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member
  public OnOff Enabled { get; set; }

  [XmlElement("Disabled")]
  public OnOff Disabled { get; set; }

  [XmlElement("Indeterminate")]
  public OnOff Indeterminate { get; set; }

  [XmlElement("DefaultValue")]
  public OnOff DefaultValue { get; set; }
}

/// <summary>
/// Simple wrapper class Ifor testing deserialization scenarios.
/// </summary>
public class OnOffWrapper
{
  public OnOff Value { get; set; }
}


