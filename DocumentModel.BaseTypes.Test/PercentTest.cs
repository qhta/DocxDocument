using System.Globalization;

// ReSharper disable SpecifyACultureInStringConversionExplicitly

namespace DocumentModel.BaseTypes.Test;

/// <summary>
/// Test suite for Percent type serialization in both XML and JSON formats.
/// </summary>
public static class PercentTest
{
  /// <summary>
  /// Runs all Percent serialization tests.
  /// </summary>
  public static bool Run()
  {
    Console.WriteLine("=== Percent Serialization Test Program ===");
    Console.WriteLine();

    // Run all tests
    if (!TestPercentBasicOperations()) return false;
    if (!TestPercentXmlSerialization()) return false;
    if (!TestPercentJsonSerialization()) return false;
    if (!TestPercentEdgeCases()) return false;

    return true;
  }


  static bool TestPercentBasicOperations()
  {
    Console.WriteLine("--- Testing Percent Basic Operations ---"); // Test string to Percent conversion
    Console.WriteLine("");
    var ok = true;


    // Test string to Percent conversion
    var str = "50%";
    Percent pct1 = str;
    var decVal = pct1.Value;
    ok = decVal == 50;
    Console.WriteLine($"{TestHelper.OkMarker(ok)} String to Percent: \"{str}\" -> {decVal}");
    if (!ok) return false;

    // Test string from Percent conversion
    pct1 = new Percent("50%");
    var strVal = (string)pct1;
    ok = strVal == "50%";
    Console.WriteLine($"{TestHelper.OkMarker(ok)} Percent to string: \"{pct1}\" -> {strVal}");
    if (!ok) return false;

    // Test Percent to double conversion
    pct1 = new Percent("50%");
    double dbl = (double)pct1;
    ok = dbl == 0.5;
    Console.WriteLine($"{TestHelper.OkMarker(ok)} Percent to double: {pct1} {TestHelper.EqualitySymbol(ok)} {dbl}");
    if (!ok) return false;

    // Test double to Percent conversion
    dbl = 0.5;
    pct1 = dbl;
    ok = pct1 == 0.5;
    Console.WriteLine($"{TestHelper.OkMarker(ok)} Double to Percent: {dbl} -> {pct1}");
    if (!ok) return false;

    // Test Percent to int conversion
    pct1 = new Percent("50%");
    var intVal = (int)pct1;
    ok = intVal == 50;
    Console.WriteLine($"{TestHelper.OkMarker(ok)} Percent to int: {pct1} -> {intVal}");
    if (!ok) return false;

    // Test int to Percent conversion
    intVal = 50;
    pct1 = intVal;
    ok = pct1 == 0.5;
    Console.WriteLine($"{TestHelper.OkMarker(ok)} int to Percent: {intVal} -> {pct1}");
    if (!ok) return false;

    // Test Percent to string without %
    strVal = "50";
    pct1 = new Percent(strVal);
    ok = pct1 == "50%";
    Console.WriteLine($"{TestHelper.OkMarker(ok)} String without % to Percent: \"{strVal}\" -> {pct1}");
    if (!ok) return false;

    //// Test with precision
    //strVal = "50.12%";
    //pct1 = new Percent(strVal);
    //string preciseStr = pct1.ToString(2, "%");
    //ok = strVal == preciseStr;
    //Console.WriteLine($"{TestHelper.OkMarker(ok)} String to Percent: \"{pct1}\" -> {preciseStr}");

    // Test hash code
    pct1 = new Percent("50%");
    var hash1 = pct1.GetHashCode();
    var hash2 = (0.5).GetHashCode();
    ok = hash1 == hash2;
    Console.WriteLine($"{TestHelper.OkMarker(ok)} Hash code test: {hash1} {TestHelper.EqualitySymbol(ok)} {hash2}");
    if (!ok) return false;

    // Test equality
    pct1 = new Percent("50%");
    Percent pct2 = new Percent(0.5);
    ok = pct1.Equals(pct2);
    Console.WriteLine($"{TestHelper.OkMarker(ok)} Equality test: \"{pct1}\" {TestHelper.EqualityMessage(ok)} \"{pct2}\" ");
    if (!ok) return false;

    // Test comparison 1
    pct1 = new Percent("50%");
    pct2 = new Percent(0.5);
    ok = pct1.CompareTo(pct2) == 0;
    string comparisonMessage = ok ? "is equal to" : "is not equal to";
    Console.WriteLine($"{TestHelper.OkMarker(ok)} Comparison 1 test: \"{pct1}\" {comparisonMessage} \"{pct2}\" ");
    if (!ok) return false;

    // Test comparison 2
    pct1 = new Percent("51%");
    pct2 = new Percent(0.50);
    ok = pct1.CompareTo(pct2) == 1;
    comparisonMessage = ok ? "is greater than" : "is not greater than";
    Console.WriteLine($"{TestHelper.OkMarker(ok)} Comparison 2 test: \"{pct1}\" {comparisonMessage} \"{pct2}\" ");
    if (!ok) return false;

    Console.WriteLine();
    return true;
  }



  static bool TestPercentXmlSerialization()
  {
    Console.WriteLine("--- Testing Percent XML Serialization ---"); // Create test object
    var testData = CreateTestData();
    ShowOriginalData(testData);

    // Serialize to XML
    var xmlSerializer = new XmlSerializer(typeof(PercentTestData));
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
    PercentTestData? deserializedData;
    using (var stringReader = new StringReader(xmlString))
    {
      deserializedData = (PercentTestData?)xmlSerializer.Deserialize(stringReader);
    }

    if (!VerifyDeserializedData(deserializedData, testData)) return false;

    Console.WriteLine("\n✓ XML Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;
  }
  
  static bool TestPercentJsonSerialization()
  {
    Console.WriteLine("--- Testing Percent JSON Serialization ---"); // Create test object
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
    var deserializedData = JsonSerializer.Deserialize<PercentTestData>(jsonString, jsonOptions);

    if (!VerifyDeserializedData(deserializedData, testData)) return false;

    Console.WriteLine("\n✓ JSON Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;
  }

  private static PercentTestData CreateTestData()
  {
    var testData = new PercentTestData
    {
      CompletionRate = new Percent("75%"),
      SuccessRate = new Percent("99%"),
      ErrorRate = new Percent("1%"),
      ZeroPercent = new Percent("0%"),
      HundredPercent = new Percent("100%"),
      //FractionalPercent = new Percent("33%"),
      NegativePercent = new Percent("-5%")
    };
    return testData;
  }

  private static void ShowOriginalData(PercentTestData testData)
  {
    Console.WriteLine($"Original data:");
    Console.WriteLine($"  CompletionRate: {testData.CompletionRate}");
    Console.WriteLine($"  SuccessRate: {testData.SuccessRate}");
    Console.WriteLine($"  ErrorRate: {testData.ErrorRate}");
    Console.WriteLine($"  ZeroPercent: {testData.ZeroPercent}");
    Console.WriteLine($"  HundredPercent: {testData.HundredPercent}");
    //Console.WriteLine($"  FractionalPercent: {testData.FractionalPercent}");
    Console.WriteLine($"  NegativePercent: {testData.NegativePercent}");
    Console.WriteLine();
  }

  private static bool VerifyDeserializedData(PercentTestData? deserializedData, PercentTestData testData)
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

    ok = testData.ZeroPercent.Equals(deserializedData.ZeroPercent);
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  ZeroPercent: {deserializedData.ZeroPercent}");
    if (!ok) return false;

    ok = testData.HundredPercent.Equals(deserializedData.HundredPercent);
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  HundredPercent: {deserializedData.HundredPercent}");
    if (!ok) return false;

    //ok = testData.FractionalPercent.Equals(deserializedData.FractionalPercent);
    //Console.WriteLine($"{TestHelper.OkMarker(ok)}  FractionalPercent: {deserializedData.FractionalPercent}");
    //if (!ok) return false;

    ok = testData.NegativePercent.Equals(deserializedData.NegativePercent);
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  NegativePercent: {deserializedData.NegativePercent}");
    if (!ok) return false;

    return true;
  }


  static bool TestPercentEdgeCases()
  {
    Console.WriteLine("--- Testing Percent Edge Cases ---"); // Test zero value
    Console.WriteLine();

    Console.WriteLine("Testing zero value:");
    var ok = true;
    Percent zero = new Percent(0);
    var dblZero = zero.AsDouble();
    ok = zero==0;
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  Zero: '{zero}' = {dblZero}");
    if (!ok) return false;

    // Test boundary values
    Console.WriteLine("\nTesting boundary values:");
    Percent minPercent = new Percent(0);
    Percent maxPercent = new Percent(100);
    var minInt = minPercent.AsDecimal();
    var maxInt = maxPercent.AsDecimal();
    ok = minInt==0;
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  Min (0%): \"{minPercent}\" = {minInt}");
    ok = maxInt==100;
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  Max (100%): \"{maxPercent}\" = {maxInt}");
    if (!ok) return false;

    // Test negative values
    Console.WriteLine("\nTesting negative values:");
    Percent negative = new Percent("-25%");
    var dblNegative = negative.AsDouble();
    ok = dblNegative == -0.25;
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  Negative (-25%): \"{negative}\" = {dblNegative}");
    if (!ok) return false;

    // Test large values (beyond 100%)
    Console.WriteLine("\nTesting values beyond 100%:");
    Percent large = new Percent("250%");
    var dblLarge = large.AsDouble();
    ok = dblLarge == 2.5;
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  Large (250%): \"{large}\" = {dblLarge}");
    if (!ok) return false;

    // Test fractional values 1
    Console.WriteLine("\nTesting fractional decimal values:");
    Percent oneThird = new Percent("33%");
    Percent twoThirds = new Percent("67%");
    var decOneThird = oneThird.AsDecimal();
    var decTwoThirds = twoThirds.AsDecimal();
    ok = decOneThird == 33m;
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  One third: \"{oneThird}\" = {decOneThird} (decimal)");
    ok = decTwoThirds == 67m;
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  Two thirds: \"{twoThirds}\" = {decTwoThirds} (decimal)");
    if (!ok) return false;

    // Test fractional values 2
    Console.WriteLine("\nTesting fractional double values:");
    oneThird = new Percent("33%");
    twoThirds = new Percent("67%");
    var dblOneThird = oneThird.AsDouble();
    var dblTwoThirds = twoThirds.AsDouble();
    ok =  oneThird.Equals(dblOneThird);
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  One third: \"{oneThird}\" {TestHelper.EqualityMessage(ok)} {dblOneThird} (double)");
    ok = twoThirds.Equals(dblTwoThirds);
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  Two thirds: \"{twoThirds}\" {TestHelper.EqualityMessage(ok)} {dblTwoThirds} (double)");
    if (!ok) return false;
    Console.WriteLine(" note that due to floating-point precision, the equality check may not always be true for fractional values when using double.");
    ok = oneThird == dblOneThird;
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  One third: \"{oneThird}\" {TestHelper.EqualitySymbol(ok)} {dblOneThird} (double)");
    ok = twoThirds == dblTwoThirds;
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  Two thirds: \"{twoThirds}\" {TestHelper.EqualitySymbol(ok)} {dblTwoThirds} (double)");
    ok = dblOneThird == oneThird;
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  One third: {dblOneThird} (double) {TestHelper.EqualitySymbol(ok)} \"{oneThird}\"");
    ok = dblTwoThirds == twoThirds;
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  Two thirds: {dblTwoThirds} (double) {TestHelper.EqualitySymbol(ok)} \"{twoThirds}\"");
    if (!ok) return false;

    //// Test very small fractional values
    //Console.WriteLine("\nTesting very small fractional values:");
    //Percent tiny = new Percent(0.001);
    //var dblTiny = tiny.ToDouble(null);
    //ok = dblTiny == 0.001;
    //Console.WriteLine($"{TestHelper.OkMarker(ok)}  0.001%: \"{tiny}\" = {dblTiny}");
    //if (!ok) return false;

    // Test string parsing with and without % suffix
    Console.WriteLine("\nTesting string parsing with and without % suffix:");
    Percent withPercent = "75%";
    Percent withoutPercent = "75";
    ok = withPercent.Equals(withoutPercent);
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  \"75%\" → {withPercent}");
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  \"75\" → {withoutPercent}");
    if (!ok) return false;



    //// Test string parsing with comma decimal separator
    //Console.WriteLine("\nTesting comma decimal separator:");
    //Percent commaDecimal = "75,5%";
    //Console.WriteLine($"{TestHelper.OkMarker(ok)}  \"75.5%\" → {withPercent}");
    //Console.WriteLine($"{TestHelper.OkMarker(ok)}  \"75,5\" → {commaDecimal}");
    //if (!ok) return false;

    // Test JSON numeric vs string input
    Console.WriteLine("\nTesting Deserialization from different formats:");

    // String format with %
    string jsonStringWithPercent = "{\"Value\":\"50%\"}";
    var fromStringPercent = JsonSerializer.Deserialize<PercentWrapper>(jsonStringWithPercent);
    Console.WriteLine($"  From JSON string \"50%\": {fromStringPercent?.Value}");

    // String format without %
    string jsonStringWithoutPercent = "{\"Value\":\"50\"}";
    var fromStringNoPercent = JsonSerializer.Deserialize<PercentWrapper>(jsonStringWithoutPercent);
    Console.WriteLine($"  From JSON string \"50\": {fromStringNoPercent?.Value}");

    // Numeric format
    string jsonNumeric = "{\"Value\":50}";
    var fromNumeric = JsonSerializer.Deserialize<PercentWrapper>(jsonNumeric);
    Console.WriteLine($"  From JSON number 50: {fromNumeric?.Value}");

    //// Test formatting with precision
    //Console.WriteLine("\nTesting formatted output:");
    //Percent pct = new Percent("75.12345%");
    //Console.WriteLine($"  Default: {pct.ToString()}");
    //Console.WriteLine($"  No unit: {pct.ToString(CultureInfo.InvariantCulture, null)}");
    //Console.WriteLine($"  Precision 0: {pct.ToString(0, "%")}");
    //Console.WriteLine($"  Precision 2: {pct.ToString(2, "%")}");
    //Console.WriteLine($"  Precision 4: {pct.ToString(4, "%")}");

    // Test comparison
    Console.WriteLine("\nTesting comparison:");
    Percent small = new Percent("25%");
    Percent large2 = new Percent("75%");
    Console.WriteLine($"  25% < 75%: {small.CompareTo(large2) < 0}");
    Console.WriteLine($"  75% > 25%: {large2.CompareTo(small) > 0}");
    Console.WriteLine($"  50% == 50%: {new Percent("50%").CompareTo(new Percent("50%")) == 0}");

    Console.WriteLine("\n✓ All edge case tests completed");
    Console.WriteLine();
    return true;
  }

}


/// <summary>
/// Test data class containing various Percent properties.
/// </summary>
[XmlRoot("PercentTestData")]
public class PercentTestData
{
  [XmlElement("CompletionRate")]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public Percent CompletionRate
  {
    [DebuggerStepThrough]
    get;
    [DebuggerStepThrough]
    set;
  }

  [XmlElement("SuccessRate")]
  public Percent SuccessRate
  {
    [DebuggerStepThrough]
    get;
    [DebuggerStepThrough]
    set;
  }

  [XmlElement("ErrorRate")]
  public Percent ErrorRate
  {
    [DebuggerStepThrough]
    get;
    [DebuggerStepThrough]
    set;
  }

  [XmlElement("ZeroPercent")]
  public Percent ZeroPercent
  {
    [DebuggerStepThrough]
    get;
    [DebuggerStepThrough]
    set;
  }

  [XmlElement("HundredPercent")]
  public Percent HundredPercent
  {
    [DebuggerStepThrough]
    get;
    [DebuggerStepThrough]
    set;
  }

  //[XmlElement("FractionalPercent")]
  //public Percent FractionalPercent
  //{
  //  [DebuggerStepThrough]
  //  get;
  //  [DebuggerStepThrough]
  //  set;
  //}

  [XmlElement("NegativePercent")]
  public Percent NegativePercent
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
public class PercentWrapper
{
  public Percent Value { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}


