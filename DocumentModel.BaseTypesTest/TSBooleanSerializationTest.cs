namespace DocumentModel.BaseTypesTest;

/// <summary>
/// Test suite for TSBoolean type serialization in both XML and JSON formats.
/// </summary>
public static class TSBooleanSerializationTests
{
  /// <summary>
  /// Runs all TSBoolean serialization tests.
  /// </summary>
  public static bool Run()
  {
    Console.WriteLine("=== TSBoolean Serialization Test Program ===");
    Console.WriteLine();

    // Run all tests
    if (!TestTSBooleanBasicOperations()) return false;
    if (!TestTSBooleanXmlSerialization()) return false;
    if (!TestTSBooleanJsonSerialization()) return false;
    if (!TestTSBooleanEdgeCases()) return false;
    if (!TestTSBooleanPerformance()) return false;

    return true;
  }

  #region Basic Operations Tests

  static bool TestTSBooleanBasicOperations()
  {
    Console.WriteLine("--- Testing TSBoolean Basic Operations ---");

    TSBoolean trueValue = TSBoolean.True;
    TSBoolean falseValue = TSBoolean.False;
    TSBoolean blankValue = TSBoolean.Blank;

    Console.WriteLine($"\n✓ True value: {trueValue}");
    Console.WriteLine($"\n✓ False value: {falseValue}");
    Console.WriteLine($"\n✓ Blank value: {blankValue}");

    if (trueValue != TSBoolean.True || falseValue != TSBoolean.False || blankValue != TSBoolean.Blank)
    {
      Console.WriteLine("✗ Equality test FAILED");
      return false;
    }

    Console.WriteLine("\n✓ Equality test passed");

    string trueString = trueValue.ToString();
    string falseString = falseValue.ToString();
    Console.WriteLine($"\n✓ ToString(): {trueString}, {falseString}");

    int trueInt = (int)trueValue;
    TSBoolean fromInt = (TSBoolean)1;
    Console.WriteLine($"\n✓ Numeric conversions: True={trueInt}, FromInt={fromInt}");

    Console.WriteLine($"\n✓ Hash codes: True={trueValue.GetHashCode()}, False={falseValue.GetHashCode()}, Blank={blankValue.GetHashCode()}");

    Console.WriteLine("\n✓ All basic operations passed");
    Console.WriteLine();
    return true;
  }

  #endregion

  #region XML Serialization Tests

  static bool TestTSBooleanXmlSerialization()
  {
    Console.WriteLine("--- Testing TSBoolean XML Serialization ---");
    var testData = CreateTestData();
    ShowOriginalData(testData);

    var xmlSerializer = new XmlSerializer(typeof(TSBooleanTestData));
    string xmlString;

    using (var stringWriter = new StringWriter())
    using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings
    {
      Indent = true,
      OmitXmlDeclaration = false,
      Encoding = System.Text.Encoding.UTF8
    }))
    {
      xmlSerializer.Serialize(xmlWriter, testData);
      xmlString = stringWriter.ToString();
    }

    Console.WriteLine("Serialized XML:");
    Console.WriteLine(xmlString);
    Console.WriteLine();

    TSBooleanTestData? deserializedData;
    using (var stringReader = new StringReader(xmlString))
    {
      deserializedData = (TSBooleanTestData?)xmlSerializer.Deserialize(stringReader);
    }

    if (!VerifyDeserializedData(deserializedData, testData)) return false;

    Console.WriteLine("\n✓ XML Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;
  }

  #endregion

  #region JSON Serialization Tests

  static bool TestTSBooleanJsonSerialization()
  {
    Console.WriteLine("--- Testing TSBoolean JSON Serialization ---");
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

    var deserializedData = JsonSerializer.Deserialize<TSBooleanTestData>(jsonString, jsonOptions);

    if (!VerifyDeserializedData(deserializedData, testData)) return false;

    Console.WriteLine("\n✓ JSON Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;
  }

  private static void ShowOriginalData(TSBooleanTestData testData)
  {
    Console.WriteLine("Original data:");
    Console.WriteLine($"  Enabled: {testData.Enabled}");
    Console.WriteLine($"  Disabled: {testData.Disabled}");
    Console.WriteLine($"  Indeterminate: {testData.Indeterminate}");
    Console.WriteLine($"  DefaultValue: {testData.DefaultValue}");
    Console.WriteLine();
  }

  private static bool VerifyDeserializedData(TSBooleanTestData? deserializedData, TSBooleanTestData testData)
  {
    if (deserializedData == null)
    {
      Console.WriteLine("✗ Deserialization returned null");
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

  #endregion

  private static TSBooleanTestData CreateTestData()
  {
    return new TSBooleanTestData
    {
      Enabled = TSBoolean.True,
      Disabled = TSBoolean.False,
      Indeterminate = TSBoolean.Blank,
      DefaultValue = TSBoolean.False
    };
  }

  #region Edge Cases Tests

  static bool TestTSBooleanEdgeCases()
  {
    Console.WriteLine("--- Testing TSBoolean Edge Cases ---");

    Console.WriteLine("Testing numeric values:");
    TSBoolean fromZero = (TSBoolean)0;
    TSBoolean fromOne = (TSBoolean)1;
    TSBoolean fromTwo = (TSBoolean)2;
    Console.WriteLine($"  0 -> {fromZero}");
    Console.WriteLine($"  1 -> {fromOne}");
    Console.WriteLine($"  2 -> {fromTwo}");

    Console.WriteLine("\nTesting Enum.TryParse:");
    bool parsedTrue = Enum.TryParse("True", out TSBoolean parsedTrueValue);
    bool parsedFalse = Enum.TryParse("False", out TSBoolean parsedFalseValue);
    bool parsedBlank = Enum.TryParse("Blank", out TSBoolean parsedBlankValue);
    bool parsedInvalid = Enum.TryParse("Invalid", out TSBoolean _);

    Console.WriteLine($"  \"True\" -> {parsedTrueValue} (success={parsedTrue})");
    Console.WriteLine($"  \"False\" -> {parsedFalseValue} (success={parsedFalse})");
    Console.WriteLine($"  \"Blank\" -> {parsedBlankValue} (success={parsedBlank})");
    Console.WriteLine($"  \"Invalid\" -> success={parsedInvalid} (expected false)");

    if (!parsedTrue || !parsedFalse || !parsedBlank || parsedInvalid)
    {
      Console.WriteLine("✗ Enum parsing test FAILED");
      return false;
    }

    Console.WriteLine("\nTesting JSON numeric deserialization:");
    string jsonNumeric = "{\"Value\":1}";
    var fromNumeric = JsonSerializer.Deserialize<TSBooleanWrapper>(jsonNumeric);
    Console.WriteLine($"  From JSON number 1: {fromNumeric?.Value}");

    Console.WriteLine("\n✓ All edge case tests completed");
    Console.WriteLine();
    return true;
  }

  #endregion

  #region Performance Tests

  static bool TestTSBooleanPerformance()
  {
    Console.WriteLine("--- Testing TSBoolean Performance ---");
    const int iterations = 100000;

    var sw = System.Diagnostics.Stopwatch.StartNew();

    TSBoolean testValue = TSBoolean.False;
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      string str = testValue.ToString();
    }
    sw.Stop();
    Console.WriteLine($"ToString() x {iterations}: {sw.ElapsedMilliseconds}ms");

    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      int numeric = (int)testValue;
    }
    sw.Stop();
    Console.WriteLine($"Cast to int x {iterations}: {sw.ElapsedMilliseconds}ms");

    var testObj = CreateTestData();
    sw.Restart();
    for (int i = 0; i < iterations / 10; i++)
    {
      string json = JsonSerializer.Serialize(testObj);
    }
    sw.Stop();
    Console.WriteLine($"JSON Serialization x {iterations / 10}: {sw.ElapsedMilliseconds}ms");

    string jsonData = JsonSerializer.Serialize(testObj);
    sw.Restart();
    for (int i = 0; i < iterations / 10; i++)
    {
      var obj = JsonSerializer.Deserialize<TSBooleanTestData>(jsonData);
    }
    sw.Stop();
    Console.WriteLine($"Deserialization x {iterations / 10}: {sw.ElapsedMilliseconds}ms");

    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      bool result = testValue == TSBoolean.False;
    }
    sw.Stop();
    Console.WriteLine($"Equality check x {iterations}: {sw.ElapsedMilliseconds}ms");

    Console.WriteLine("\n✓ Performance tests completed");
    Console.WriteLine();
    return true;
  }

  #endregion
}

#region Test Helper Classes

/// <summary>
/// Test data class containing various TSBoolean properties.
/// </summary>
[XmlRoot("TSBooleanTestData")]
public class TSBooleanTestData
{
  [XmlElement("Enabled")]
  public TSBoolean Enabled { get; set; }

  [XmlElement("Disabled")]
  public TSBoolean Disabled { get; set; }

  [XmlElement("Indeterminate")]
  public TSBoolean Indeterminate { get; set; }

  [XmlElement("DefaultValue")]
  public TSBoolean DefaultValue { get; set; }
}

/// <summary>
/// Simple wrapper class for testing deserialization scenarios.
/// </summary>
public class TSBooleanWrapper
{
  public TSBoolean Value { get; set; }
}

#endregion
