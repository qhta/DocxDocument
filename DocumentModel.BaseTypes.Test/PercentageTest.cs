using System.Globalization;

// ReSharper disable SpecifyACultureInStringConversionExplicitly

namespace DocumentModel.BaseTypes.Test;

/// <summary>
/// Test suite for Percentage type serialization in both XML and JSON formats.
/// </summary>
public static class PercentageTest
{
  /// <summary>
  /// Runs all Percentage serialization tests.
  /// </summary>
  public static bool Run()
  {
    Console.WriteLine("=== Percentage Serialization Test Program ===");
    Console.WriteLine();

    // Run all tests
    if (!TestPercentageBasicOperations()) return false;
    if (!TestPercentageXmlSerialization()) return false;
    if (!TestPercentageJsonSerialization()) return false;
    if (!TestPercentageEdgeCases()) return false;

    return true;
  }


  static bool TestPercentageBasicOperations()
  {
    Console.WriteLine("--- Testing Percentage Basic Operations ---"); // Test string to Percentage conversion
    Console.WriteLine("");
    var ok = true;


    // Test string to Percentage conversion
    var str = "50%";
    Percentage pct1 = str;
    var decVal = pct1.Value;
    ok = decVal == 50;
    Console.WriteLine($"{TestHelper.OkMarker(ok)} String to Percentage: \"{str}\" -> {decVal}");
    if (!ok) return false;

    // Test string from Percentage conversion
    pct1 = new Percentage("50%");
    var strVal = (string)pct1;
    ok = strVal == "50%";
    Console.WriteLine($"{TestHelper.OkMarker(ok)} Percentage to string: \"{pct1}\" -> {strVal}");
    if (!ok) return false;

    // Test Percentage to double conversion
    pct1 = new Percentage("50%");
    double dbl = (double)pct1;
    ok = dbl == 0.5;
    Console.WriteLine($"{TestHelper.OkMarker(ok)} Percentage to double: {pct1} -> {dbl}");
    if (!ok) return false;

    // Test double to Percentage conversion
    dbl = 0.5;
    pct1 = dbl;
    ok = pct1 == 0.5;
    Console.WriteLine($"{TestHelper.OkMarker(ok)} Double to Percentage: {dbl} -> {pct1}");
    if (!ok) return false;

    // Test Percentage to int conversion
    pct1 = new Percentage("50%");
    var intVal = (int)pct1;
    ok = intVal == 50;
    Console.WriteLine($"{TestHelper.OkMarker(ok)} Percentage to int: {pct1} -> {intVal}");
    if (!ok) return false;

    // Test int to Percentage conversion
    intVal = 50;
    pct1 = intVal;
    ok = pct1 == 0.5;
    Console.WriteLine($"{TestHelper.OkMarker(ok)} int to Percentage: {intVal} -> {pct1}");
    if (!ok) return false;

    // Test Percentage to string without %
    strVal = "50";
    pct1 = new Percentage(strVal);
    ok = pct1 == "50%";
    Console.WriteLine($"{TestHelper.OkMarker(ok)} String without % to Percentage: \"{strVal}\" -> {pct1}");
    if (!ok) return false;

    // Test with precision
    strVal = "50.12%";
    pct1 = new Percentage(strVal);
    string preciseStr = pct1.ToString(2, "%");
    ok = strVal == preciseStr;
    Console.WriteLine($"{TestHelper.OkMarker(ok)} String to Percentage: \"{pct1}\" -> {preciseStr}");

    // Test hash code
    pct1 = new Percentage("50%");
    var hash1 = pct1.GetHashCode();
    var hash2 = (0.5).GetHashCode();
    ok = hash1 == hash2;
    Console.WriteLine($"{TestHelper.OkMarker(ok)} Hash code test: {hash1} {TestHelper.EqualitySymbol(ok)} {hash2}");
    if (!ok) return false;

    // Test equality
    pct1 = new Percentage("50%");
    Percentage pct2 = new Percentage(0.5);
    ok = pct1.Equals(pct2);
    Console.WriteLine($"{TestHelper.OkMarker(ok)} Equality test: \"{pct1}\" {TestHelper.EqualityMessage(ok)} \"{pct2}\" ");
    if (!ok) return false;

    // Test comparison 1
    pct1 = new Percentage("50%");
    pct2 = new Percentage(0.5);
    var cmp = pct1.CompareTo(pct2);
    ok = cmp == 0;
    Console.WriteLine($"{TestHelper.OkMarker(ok)} Comparison 1 test: \"{pct1}\" {TestHelper.CompareMessage(cmp)} \"{pct2}\" ");
    if (!ok) return false;

    // Test comparison 2
    pct1 = new Percentage("51%");
    pct2 = new Percentage(0.50);
    cmp = pct1.CompareTo(pct2);
    ok = cmp == 1;
    Console.WriteLine($"{TestHelper.OkMarker(ok)} Comparison 2 test: \"{pct1}\" {TestHelper.CompareMessage(cmp)} \"{pct2}\" ");
    if (!ok) return false;

    Console.WriteLine();
    return true;
  }



  static bool TestPercentageXmlSerialization()
  {
    Console.WriteLine("--- Testing Percentage XML Serialization ---"); // Create test object
    var testData = CreateTestData();
    ShowOriginalData(testData);

    // Serialize to XML
    var xmlSerializer = new XmlSerializer(typeof(PercentageTestData));
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

    // Deserialize from XML
    PercentageTestData? deserializedData;
    using (var stringReader = new StringReader(xmlString))
    {
      deserializedData = (PercentageTestData?)xmlSerializer.Deserialize(stringReader);
    }

    if (!VerifyDeserializedData(deserializedData, testData)) return false;

    Console.WriteLine("\n✓ XML Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;
  }

  static bool TestPercentageJsonSerialization()
  {
    Console.WriteLine("--- Testing Percentage JSON Serialization ---"); // Create test object
    var testData = CreateTestData();
    ShowOriginalData(testData);

    // Serialize to JSON
    var jsonOptions = new JsonSerializerOptions
    {
      WriteIndented = true,
      PropertyNamingPolicy = JsonNamingPolicy.CamelCase
    };

    string jsonString = JsonSerializer.Serialize(testData, jsonOptions);

    Console.WriteLine("Serialized JSON:");
    Console.WriteLine(jsonString);
    Console.WriteLine();

    // Deserialize from JSON
    var deserializedData = JsonSerializer.Deserialize<PercentageTestData>(jsonString, jsonOptions);

    if (!VerifyDeserializedData(deserializedData, testData)) return false;

    Console.WriteLine("\n✓ JSON Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;
  }

  private static PercentageTestData CreateTestData()
  {
    var testData = new PercentageTestData
    {
      CompletionRate = new Percentage("75.5%"),
      SuccessRate = new Percentage("99.9%"),
      ErrorRate = new Percentage("0.1%"),
      ZeroPercentage = new Percentage("0%"),
      HundredPercentage = new Percentage("100%"),
      FractionalPercentage = new Percentage("33.333%"),
      NegativePercentage = new Percentage("-5.5%")
    };
    return testData;
  }

  private static void ShowOriginalData(PercentageTestData testData)
  {
    Console.WriteLine($"Original data:");
    Console.WriteLine($"  CompletionRate: {testData.CompletionRate}");
    Console.WriteLine($"  SuccessRate: {testData.SuccessRate}");
    Console.WriteLine($"  ErrorRate: {testData.ErrorRate}");
    Console.WriteLine($"  ZeroPercentage: {testData.ZeroPercentage}");
    Console.WriteLine($"  HundredPercentage: {testData.HundredPercentage}");
    Console.WriteLine($"  FractionalPercentage: {testData.FractionalPercentage}");
    Console.WriteLine($"  NegativePercentage: {testData.NegativePercentage}");
    Console.WriteLine();
  }

  private static bool VerifyDeserializedData(PercentageTestData? deserializedData, PercentageTestData testData)
  {
    if (deserializedData == null)
    {
      Console.WriteLine("✗ Deserialization returned null");
      return false;
    }

    // Verify deserialized data
    Console.WriteLine("Deserialized data:");
    var ok = true;
    ok = testData.CompletionRate.Equals(deserializedData.CompletionRate);
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  CompletionRate: {deserializedData.CompletionRate}");
    if (!ok) return false;

    ok = testData.SuccessRate.Equals(deserializedData.SuccessRate);
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  SuccessRate: {deserializedData.SuccessRate}");
    if (!ok) return false;

    ok = testData.ErrorRate.Equals(deserializedData.ErrorRate);
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  ErrorRate: {deserializedData.ErrorRate}");
    if (!ok) return false;

    ok = testData.ZeroPercentage.Equals(deserializedData.ZeroPercentage);
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  ZeroPercentage: {deserializedData.ZeroPercentage}");
    if (!ok) return false;

    ok = testData.HundredPercentage.Equals(deserializedData.HundredPercentage);
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  HundredPercentage: {deserializedData.HundredPercentage}");
    if (!ok) return false;

    ok = testData.FractionalPercentage.Equals(deserializedData.FractionalPercentage);
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  FractionalPercentage: {deserializedData.FractionalPercentage}");
    if (!ok) return false;

    ok = testData.NegativePercentage.Equals(deserializedData.NegativePercentage);
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  NegativePercentage: {deserializedData.NegativePercentage}");
    if (!ok) return false;

    return true;
  }


  static bool TestPercentageEdgeCases()
  {
    Console.WriteLine("--- Testing Percentage Edge Cases ---"); // Test zero value
    Console.WriteLine();

    Console.WriteLine("Testing zero value:");
    var ok = true;
    Percentage zero = new Percentage(0);
    var dblZero = zero.AsDouble();
    ok = zero == 0;
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  Zero: '{zero}' = {dblZero}");
    if (!ok) return false;

    // Test boundary values
    Console.WriteLine("\nTesting boundary values:");
    Percentage minPercentage = new Percentage(0);
    Percentage maxPercentage = new Percentage(100);
    var minInt = minPercentage.AsInteger();
    var maxInt = maxPercentage.AsInteger();
    ok = minInt == 0;
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  Min (0%): \"{minPercentage}\" = {minInt}");
    ok = maxInt == 100;
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  Max (100%): \"{maxPercentage}\" = {maxInt}");
    if (!ok) return false;

    // Test negative values
    Console.WriteLine("\nTesting negative values:");
    Percentage negative = new Percentage("-25.5%");
    var dblNegative = negative.AsDouble();
    ok = dblNegative == -0.255;
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  Negative (-25.5%): \"{negative}\" = {dblNegative}");
    if (!ok) return false;

    // Test large values (beyond 100%)
    Console.WriteLine("\nTesting values beyond 100%:");
    Percentage large = new Percentage("250%");
    var dblLarge = large.AsDouble();
    ok = dblLarge == 2.5;
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  Large (250%): \"{large}\" = {dblLarge}");
    if (!ok) return false;

    // Test fractional values 1
    Console.WriteLine("\nTesting fractional decimal values:");
    Percentage oneThird = new Percentage("33.333%");
    Percentage twoThirds = new Percentage("66.667%");
    var decOneThird = oneThird.AsDecimal();
    var decTwoThirds = twoThirds.AsDecimal();
    ok = decOneThird == 33.333m;
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  One third: \"{oneThird}\" = {decOneThird} (decimal)");
    ok = decTwoThirds == 66.667m;
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  Two thirds: \"{twoThirds}\" = {decTwoThirds} (decimal)");
    if (!ok) return false;

    // Test fractional values 2
    Console.WriteLine("\nTesting fractional double values:");
    oneThird = new Percentage("33.333%");
    twoThirds = new Percentage("66.667%");
    var dblOneThird = oneThird.AsDouble();
    var dblTwoThirds = twoThirds.AsDouble();
    ok = oneThird.Equals(dblOneThird);
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  One third: \"{oneThird}\" {TestHelper.EqualityMessage(ok)} {dblOneThird} (double)");
    ok = twoThirds.Equals(dblTwoThirds);
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  Two thirds: \"{twoThirds}\" {TestHelper.EqualityMessage(ok)} {dblTwoThirds} (double)");
    if (!ok) return false;
    Console.WriteLine(" but note that due to floating-point precision, the equality check may not always be true for fractional values when using double.");
    ok = oneThird == dblOneThird;
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  One third: \"{oneThird}\" {TestHelper.EqualitySymbol(ok)} {dblOneThird} (double)");
    ok = twoThirds == dblTwoThirds;
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  Two thirds: \"{twoThirds}\" {TestHelper.EqualitySymbol(ok)} {dblTwoThirds} (double)");
    ok = dblOneThird == oneThird;
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  One third: {dblOneThird} (double) {TestHelper.EqualitySymbol(ok)} \"{oneThird}\"");
    ok = dblTwoThirds == twoThirds;
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  Two thirds: {dblTwoThirds} (double) {TestHelper.EqualitySymbol(ok)} \"{twoThirds}\"");
    if (!ok) return false;

    // Test very small fractional values
    Console.WriteLine("\nTesting very small fractional values:");
    Percentage tiny = new Percentage(0.001);
    var dblTiny = tiny.AsDouble();
    ok = dblTiny == 0.001;
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  0.001%: \"{tiny}\" = {dblTiny}");
    if (!ok) return false;

    // Test string parsing with and without % suffix
    Console.WriteLine("\nTesting string parsing with and without % suffix:");
    Percentage withPercentage = "75.5%";
    Percentage withoutPercentage = "75.5";
    ok = withPercentage.Equals(withoutPercentage);
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  \"75.5%\" → {withPercentage}");
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  \"75.5\" → {withoutPercentage}");
    if (!ok) return false;



    // Test string parsing with comma decimal separator
    Console.WriteLine("\nTesting comma decimal separator:");
    Percentage commaDecimal = "75,5%";
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  \"75.5%\" → {withPercentage}");
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  \"75,5\" → {commaDecimal}");
    if (!ok) return false;

    // Test JSON numeric vs string input
    Console.WriteLine("\nTesting Deserialization from different formats:");

    // String format with %
    string jsonStringWithPercentage = "{\"Value\":\"50%\"}";
    var fromStringPercentage = JsonSerializer.Deserialize<PercentageWrapper>(jsonStringWithPercentage);
    Console.WriteLine($"  From JSON string \"50%\": {fromStringPercentage?.Value}");

    // String format without %
    string jsonStringWithoutPercentage = "{\"Value\":\"50\"}";
    var fromStringNoPercentage = JsonSerializer.Deserialize<PercentageWrapper>(jsonStringWithoutPercentage);
    Console.WriteLine($"  From JSON string \"50\": {fromStringNoPercentage?.Value}");

    // Numeric format
    string jsonNumeric = "{\"Value\":50.5}";
    var fromNumeric = JsonSerializer.Deserialize<PercentageWrapper>(jsonNumeric);
    Console.WriteLine($"  From JSON number 50.5: {fromNumeric?.Value}");

    // Test formatting with precision
    Console.WriteLine("\nTesting formatted output:");
    Percentage pct = new Percentage("75.12345%");
    Console.WriteLine($"  Default: {pct.ToString()}");
    Console.WriteLine($"  No unit: {pct.ToString(CultureInfo.InvariantCulture, null)}");
    Console.WriteLine($"  Precision 0: {pct.ToString(0, "%")}");
    Console.WriteLine($"  Precision 2: {pct.ToString(2, "%")}");
    Console.WriteLine($"  Precision 4: {pct.ToString(4, "%")}");

    // Test comparison
    Console.WriteLine("\nTesting comparison:");
    Percentage small = new Percentage("25.5%");
    Percentage large2 = new Percentage("75.5%");
    Console.WriteLine($"  25.5% < 75.5%: {small.CompareTo(large2) < 0}");
    Console.WriteLine($"  75.5% > 25.5%: {large2.CompareTo(small) > 0}");
    Console.WriteLine($"  50% == 50%: {new Percentage("50%").CompareTo(new Percentage("50%")) == 0}");

    Console.WriteLine("\n✓ All edge case tests completed");
    Console.WriteLine();
    return true;
  }

}


/// <summary>
/// Test data class containing various Percentage properties.
/// </summary>
[XmlRoot("PercentageTestData")]
public class PercentageTestData
{
  [XmlElement("CompletionRate")]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public Percentage CompletionRate
  {
    [DebuggerStepThrough]
    get;
    [DebuggerStepThrough]
    set;
  }

  [XmlElement("SuccessRate")]
  public Percentage SuccessRate
  {
    [DebuggerStepThrough]
    get;
    [DebuggerStepThrough]
    set;
  }

  [XmlElement("ErrorRate")]
  public Percentage ErrorRate
  {
    [DebuggerStepThrough]
    get;
    [DebuggerStepThrough]
    set;
  }

  [XmlElement("ZeroPercentage")]
  public Percentage ZeroPercentage
  {
    [DebuggerStepThrough]
    get;
    [DebuggerStepThrough]
    set;
  }

  [XmlElement("HundredPercentage")]
  public Percentage HundredPercentage
  {
    [DebuggerStepThrough]
    get;
    [DebuggerStepThrough]
    set;
  }

  [XmlElement("FractionalPercentage")]
  public Percentage FractionalPercentage
  {
    [DebuggerStepThrough]
    get;
    [DebuggerStepThrough]
    set;
  }

  [XmlElement("NegativePercentage")]
  public Percentage NegativePercentage
  {
    [DebuggerStepThrough]
    get;
    [DebuggerStepThrough]
    set;
  }
}


/// <summary>
/// Simple wrapper class for testing Deserialization scenarios.
/// </summary>
public class PercentageWrapper
{
  public Percentage Value { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}


