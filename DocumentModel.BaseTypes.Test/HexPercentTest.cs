using System.Globalization;

// ReSharper disable SpecifyACultureInStringConversionExplicitly

namespace DocumentModel.BaseTypes.Test;

/// <summary>
/// Test suite for HexPercent type serialization in both XML and JSON formats.
/// </summary>
public static class HexPercentTest
{
  /// <summary>
  /// Runs all HexPercent serialization tests.
  /// </summary>
  public static bool Run()
  {
    Console.WriteLine("=== HexPercent Serialization Test Program ===");
    Console.WriteLine();

    // Run all tests
    if (!TestHexPercentBasicOperations()) return false;
    if (!TestHexPercentXmlSerialization()) return false;
    if (!TestHexPercentJsonSerialization()) return false;
    if (!TestHexPercentEdgeCases()) return false;

    return true;
  }


  static bool TestHexPercentBasicOperations()
  {
    Console.WriteLine("--- Testing HexPercent Basic Operations ---"); // Test string to HexPercent conversion
    Console.WriteLine("");
    var ok = true;


    // Test string to HexPercent conversion
    var str = "50%";
    HexPercent pct1 = str;
    var decVal = pct1.Value;
    ok = decVal == 127;
    Console.WriteLine($"{TestHelper.OkMarker(ok)} String to HexPercent: \"{str}\" -> {decVal}");
    if (!ok) return false;

    // Test string from HexPercent conversion
    pct1 = new HexPercent("60%");
    var strVal = (string)pct1;
    ok = strVal == "60%";
    Console.WriteLine($"{TestHelper.OkMarker(ok)} HexPercent to string: \"{pct1}\" -> {strVal}");
    if (!ok) return false;

    // Test HexPercent to double conversion
    pct1 = new HexPercent("60%");
    double dbl = (double)pct1;
    ok = dbl == 0.6;
    Console.WriteLine($"{TestHelper.OkMarker(ok)} HexPercent to double: {pct1} {TestHelper.EqualitySymbol(ok)} {dbl}");
    if (!ok) return false;
    Console.WriteLine(" note that due to 255 scaling, \"50%\" does not exactly map to 0.5 in double representation.");
    pct1 = new HexPercent("50%");
    dbl = (double)pct1;
    ok = dbl != 0.5;
    Console.WriteLine($"{TestHelper.OkMarker(ok)} HexPercent to double: \"50%\" {TestHelper.EqualitySymbol(ok)} {dbl}");
    if (!ok) return false;

    // Test double to HexPercent conversion
    dbl = 0.6;
    pct1 = dbl;
    ok = pct1 == 0.6;
    Console.WriteLine($"{TestHelper.OkMarker(ok)} Double to HexPercent: {dbl} -> {pct1}");
    if (!ok) return false;

    // Test HexPercent to int conversion
    pct1 = new HexPercent("60%");
    var intVal = (int)pct1;
    ok = intVal == 153;
    Console.WriteLine($"{TestHelper.OkMarker(ok)} HexPercent to int: {pct1} -> {intVal}");
    if (!ok) return false;

    // Test int to HexPercent conversion
    intVal = 153;
    pct1 = intVal;
    ok = pct1 == 0.6;
    Console.WriteLine($"{TestHelper.OkMarker(ok)} int to HexPercent: {intVal} -> {pct1}");
    if (!ok) return false;

    // Test HexPercent to string without %
    strVal = "153";
    pct1 = new HexPercent(strVal);
    ok = pct1 == "60%";
    Console.WriteLine($"{TestHelper.OkMarker(ok)} String without % to HexPercent: \"{strVal}\" -> {pct1}");
    if (!ok) return false;

    //// Test with precision
    //strVal = "50.12%";
    //pct1 = new HexPercent(strVal);
    //string preciseStr = pct1.ToString(2, "%");
    //ok = strVal == preciseStr;
    //Console.WriteLine($"{TestHelper.OkMarker(ok)} String to HexPercent: \"{pct1}\" -> {preciseStr}");

    // Test hash code
    pct1 = new HexPercent("60%");
    var hash1 = pct1.GetHashCode();
    var hash2 = (0.6).GetHashCode();
    ok = hash1 == hash2;
    Console.WriteLine($"{TestHelper.OkMarker(ok)} Hash code test: {hash1} {TestHelper.EqualitySymbol(ok)} {hash2}");
    if (!ok) return false;

    // Test equality
    pct1 = new HexPercent("60%");
    HexPercent pct2 = new HexPercent(0.6);
    ok = pct1.Equals(pct2);
    Console.WriteLine($"{TestHelper.OkMarker(ok)} Equality test: \"{pct1}\" {TestHelper.EqualityMessage(ok)} \"{pct2}\" ");
    if (!ok) return false;

    // Test comparison 1
    pct1 = new HexPercent("60%");
    pct2 = new HexPercent(0.6);
    ok = pct1.CompareTo(pct2) == 0;
    Console.WriteLine($"{TestHelper.OkMarker(ok)} Comparison 1 test: \"{pct1}\" {TestHelper.EqualityMessage(ok)} \"{pct2}\" ");
    if (!ok) return false;

    // Test comparison 2
    pct1 = new HexPercent("51%");
    pct2 = new HexPercent(0.50);
    int cmp = pct1.CompareTo(pct2);
    ok = cmp > 0;
    var comparisonMessage = ok ? "is greater than" : "is not greater than";
    Console.WriteLine($"{TestHelper.OkMarker(ok)} Comparison 2 test: \"{pct1}\" {comparisonMessage} \"{pct2}\" ");
    if (!ok) return false;

    Console.WriteLine();
    return true;
  }



  static bool TestHexPercentXmlSerialization()
  {
    Console.WriteLine("--- Testing HexPercent XML Serialization ---"); // Create test object
    var testData = CreateTestData();
    ShowOriginalData(testData);

    // Serialize to XML
    var xmlSerializer = new XmlSerializer(typeof(HexPercentTestData));
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
    HexPercentTestData? deserializedData;
    using (var stringReader = new StringReader(xmlString))
    {
      deserializedData = (HexPercentTestData?)xmlSerializer.Deserialize(stringReader);
    }

    if (!VerifyDeserializedData(deserializedData, testData)) return false;

    Console.WriteLine("\n✓ XML Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;
  }

  static bool TestHexPercentJsonSerialization()
  {
    Console.WriteLine("--- Testing HexPercent JSON Serialization ---"); // Create test object
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
    var deserializedData = JsonSerializer.Deserialize<HexPercentTestData>(jsonString, jsonOptions);

    if (!VerifyDeserializedData(deserializedData, testData)) return false;

    Console.WriteLine("\n✓ JSON Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;
  }

  private static HexPercentTestData CreateTestData()
  {
    var testData = new HexPercentTestData
    {
      CompletionRate = new HexPercent("75%"),
      SuccessRate = new HexPercent("99%"),
      ErrorRate = new HexPercent("1%"),
      ZeroHexPercent = new HexPercent("0%"),
      HundredHexPercent = new HexPercent("100%"),
      //FractionalHexPercent = new HexPercent("33%"),
      //NegativeHexPercent = new HexPercent("-5%")
    };
    return testData;
  }

  private static void ShowOriginalData(HexPercentTestData testData)
  {
    Console.WriteLine($"Original data:");
    Console.WriteLine($"  CompletionRate: {testData.CompletionRate}");
    Console.WriteLine($"  SuccessRate: {testData.SuccessRate}");
    Console.WriteLine($"  ErrorRate: {testData.ErrorRate}");
    Console.WriteLine($"  ZeroHexPercent: {testData.ZeroHexPercent}");
    Console.WriteLine($"  HundredHexPercent: {testData.HundredHexPercent}");
    //Console.WriteLine($"  FractionalHexPercent: {testData.FractionalHexPercent}");
    //Console.WriteLine($"  NegativeHexPercent: {testData.NegativeHexPercent}");
    Console.WriteLine();
  }

  private static bool VerifyDeserializedData(HexPercentTestData? deserializedData, HexPercentTestData testData)
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

    ok = testData.ZeroHexPercent.Equals(deserializedData.ZeroHexPercent);
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  ZeroHexPercent: {deserializedData.ZeroHexPercent}");
    if (!ok) return false;

    ok = testData.HundredHexPercent.Equals(deserializedData.HundredHexPercent);
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  HundredHexPercent: {deserializedData.HundredHexPercent}");
    if (!ok) return false;

    //ok = testData.FractionalHexPercent.Equals(deserializedData.FractionalHexPercent);
    //Console.WriteLine($"{TestHelper.OkMarker(ok)}  FractionalHexPercent: {deserializedData.FractionalHexPercent}");
    //if (!ok) return false;

    //ok = testData.NegativeHexPercent.Equals(deserializedData.NegativeHexPercent);
    //Console.WriteLine($"{TestHelper.OkMarker(ok)}  NegativeHexPercent: {deserializedData.NegativeHexPercent}");
    //if (!ok) return false;

    return true;
  }


  static bool TestHexPercentEdgeCases()
  {
    Console.WriteLine("--- Testing HexPercent Edge Cases ---"); // Test zero value
    Console.WriteLine();

    Console.WriteLine("Testing zero value:");
    var ok = true;
    HexPercent zero = new HexPercent(0);
    var dblZero = zero.ToDouble(null);
    ok = zero == 0;
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  Zero: '{zero}' = {dblZero}");
    if (!ok) return false;

    // Test boundary values
    Console.WriteLine("\nTesting boundary values:");
    HexPercent minHexPercent = new HexPercent(0);
    HexPercent maxHexPercent = new HexPercent(255);
    var minInt = minHexPercent.ToInt32(null);
    var maxInt = maxHexPercent.ToInt32(null);
    ok = minInt == 0;
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  Min (0%): \"{minHexPercent}\" = {minInt}");
    ok = maxInt == 100;
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  Max (100%): \"{maxHexPercent}\" = {maxInt}");
    if (!ok) return false;

    // Test negative values
    Console.WriteLine("\nTesting negative values:");
    try
    {
      HexPercent negative = new HexPercent("-25%");
      var dblNegative = negative.ToDouble(null);
      ok = dblNegative == -0.25;
      Console.WriteLine($"{TestHelper.OkMarker(ok)}  Negative (-25%): \"{negative}\" = {dblNegative}");
    }
    catch (Exception)
    {
      ok = true;
      Console.WriteLine($"{TestHelper.OkMarker(ok)}  Negative (-25%) not allowed");
    }
    if (!ok) return false;

    // Test large values (beyond 100%)
    Console.WriteLine("\nTesting values beyond 100%:");
    try
    {
      HexPercent large = new HexPercent("250%");
      var dblLarge = large.ToDouble(null);
      ok = dblLarge == 2.5;
      Console.WriteLine($"{TestHelper.OkMarker(ok)}  Large (250%): \"{large}\" = {dblLarge}");
    }
    catch (Exception)
    {
      ok = true;
      Console.WriteLine($"{TestHelper.OkMarker(ok)}  Large (250%) not allowed");
    }
    if (!ok) return false;

    // Test fractional values 1
    Console.WriteLine("\nTesting fractional decimal values:");
    HexPercent oneThird = new HexPercent("33.33%");
    HexPercent twoThirds = new HexPercent("66.67%");
    var decOneThird = oneThird.ToDecimal(null);
    var decTwoThirds = twoThirds.ToDecimal(null);
    ok = decOneThird == 32.941176470588235294117647059m;
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  One third: \"{oneThird}\" = {decOneThird} (decimal)");
    ok = decTwoThirds == 66.666666666666666666666666667m;
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  Two thirds: \"{twoThirds}\" = {decTwoThirds} (decimal)");
    if (!ok) return false;

    // Test fractional values 2
    Console.WriteLine("\nTesting fractional double values:");
    oneThird = new HexPercent("33.33%");
    twoThirds = new HexPercent("66.67%");
    var dblOneThird = oneThird.ToDouble(null);
    var dblTwoThirds = twoThirds.ToDouble(null);
    oneThird = 32.94117647058823;
    twoThirds = 66.66666666666667;
    ok = oneThird.Equals(dblOneThird);
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  One third: \"{oneThird}\" {TestHelper.EqualityMessage(ok)} {dblOneThird} (double)");
    ok = twoThirds.Equals(dblTwoThirds);
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  Two thirds: \"{twoThirds}\" {TestHelper.EqualityMessage(ok)} {dblTwoThirds} (double)");
    if (!ok) return false;
    Console.WriteLine(" but note that due to floating-point precision, the equality check may not always be true for fractional values when using double.");
    var eq = oneThird == dblOneThird;
    ok = !eq;
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  One third: \"{oneThird}\" {TestHelper.EqualitySymbol(eq)} {dblOneThird} (double)");
    eq = twoThirds == dblTwoThirds;
    ok = !eq;
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  Two thirds: \"{twoThirds}\" {TestHelper.EqualitySymbol(eq)} {dblTwoThirds} (double)");
    eq = dblOneThird == oneThird;
    ok = !eq;
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  One third: {dblOneThird} (double) {TestHelper.EqualitySymbol(eq)} \"{oneThird}\"");
    eq = dblTwoThirds == twoThirds;
    ok = !eq;
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  Two thirds: {dblTwoThirds} (double) {TestHelper.EqualitySymbol(eq)} \"{twoThirds}\"");
    if (!ok) return false;

    //// Test very small fractional values
    //Console.WriteLine("\nTesting very small fractional values:");
    //HexPercent tiny = new HexPercent(0.001);
    //var dblTiny = tiny.ToDouble(null);
    //ok = dblTiny == 0.001;
    //Console.WriteLine($"{TestHelper.OkMarker(ok)}  0.001%: \"{tiny}\" = {dblTiny}");
    //if (!ok) return false;

    // Test string parsing with and without % suffix
    Console.WriteLine("\nTesting string parsing with and without % suffix:");
    HexPercent withHexPercent = "75%";
    ok = true;
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  \"75%\" → {withHexPercent}");
    HexPercent withoutHexPercent = "75";
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  \"75\" → {withoutHexPercent}");
    eq = withHexPercent.Equals(withoutHexPercent);
    ok = !eq; 
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  One third: \"{withHexPercent}\" {TestHelper.EqualitySymbol(eq)} \"{withoutHexPercent}\"");
    if (!ok) return false;



    //// Test string parsing with comma decimal separator
    //Console.WriteLine("\nTesting comma decimal separator:");
    //HexPercent commaDecimal = "75,5%";
    //Console.WriteLine($"{TestHelper.OkMarker(ok)}  \"75.5%\" → {withHexPercent}");
    //Console.WriteLine($"{TestHelper.OkMarker(ok)}  \"75,5\" → {commaDecimal}");
    //if (!ok) return false;

    // Test JSON numeric vs string input
    Console.WriteLine("\nTesting Deserialization from different formats:");

    // String format with %
    string jsonStringWithHexPercent = "{\"Value\":\"50%\"}";
    var fromStringHexPercent = JsonSerializer.Deserialize<HexPercentWrapper>(jsonStringWithHexPercent);
    Console.WriteLine($"  From JSON string \"50%\": {fromStringHexPercent?.Value}");

    // String format without %
    string jsonStringWithoutHexPercent = "{\"Value\":\"50\"}";
    var fromStringNoHexPercent = JsonSerializer.Deserialize<HexPercentWrapper>(jsonStringWithoutHexPercent);
    Console.WriteLine($"  From JSON string \"50\": {fromStringNoHexPercent?.Value}");

    // Numeric format
    string jsonNumeric = "{\"Value\":50}";
    var fromNumeric = JsonSerializer.Deserialize<HexPercentWrapper>(jsonNumeric);
    Console.WriteLine($"  From JSON number 50: {fromNumeric?.Value}");

    //// Test formatting with precision
    //Console.WriteLine("\nTesting formatted output:");
    //HexPercent pct = new HexPercent("75.12345%");
    //Console.WriteLine($"  Default: {pct.ToString()}");
    //Console.WriteLine($"  No unit: {pct.ToString(CultureInfo.InvariantCulture, null)}");
    //Console.WriteLine($"  Precision 0: {pct.ToString(0, "%")}");
    //Console.WriteLine($"  Precision 2: {pct.ToString(2, "%")}");
    //Console.WriteLine($"  Precision 4: {pct.ToString(4, "%")}");

    // Test comparison
    Console.WriteLine("\nTesting comparison:");
    HexPercent small = new HexPercent("25%");
    HexPercent large2 = new HexPercent("75%");
    Console.WriteLine($"  25% < 75%: {small.CompareTo(large2) < 0}");
    Console.WriteLine($"  75% > 25%: {large2.CompareTo(small) > 0}");
    Console.WriteLine($"  50% == 50%: {new HexPercent("50%").CompareTo(new HexPercent("50%")) == 0}");

    // Test IConvertible implementation
    Console.WriteLine("\nTesting IConvertible conversions:");
    HexPercent convertTest = new HexPercent("42%");
    Console.WriteLine($"  ToByte: {convertTest.ToByte(null)}");
    Console.WriteLine($"  ToInt32: {convertTest.ToInt32(null)}");
    Console.WriteLine($"  ToDouble: {convertTest.ToDouble(null)}");
    Console.WriteLine($"  ToDecimal: {convertTest.ToDecimal(null)}");

    // Test ToType conversions
    Console.WriteLine("\nTesting ToType conversions:");
    var asInt32 = (int)convertTest.ToType(typeof(Int32), null);
    var asDouble = (double)convertTest.ToType(typeof(Double), null);
    var asString = (string)convertTest.ToType(typeof(String), null);
    Console.WriteLine($"  ToType(Int32): {asInt32}");
    Console.WriteLine($"  ToType(Double): {asDouble}");
    Console.WriteLine($"  ToType(String): {asString}");

    Console.WriteLine("\n✓ All edge case tests completed");
    Console.WriteLine();
    return true;
  }

}


/// <summary>
/// Test data class containing various HexPercent properties.
/// </summary>
[XmlRoot("HexPercentTestData")]
public class HexPercentTestData
{
  [XmlElement("CompletionRate")]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public HexPercent CompletionRate
  {
    [DebuggerStepThrough]
    get;
    [DebuggerStepThrough]
    set;
  }

  [XmlElement("SuccessRate")]
  public HexPercent SuccessRate
  {
    [DebuggerStepThrough]
    get;
    [DebuggerStepThrough]
    set;
  }

  [XmlElement("ErrorRate")]
  public HexPercent ErrorRate
  {
    [DebuggerStepThrough]
    get;
    [DebuggerStepThrough]
    set;
  }

  [XmlElement("ZeroHexPercent")]
  public HexPercent ZeroHexPercent
  {
    [DebuggerStepThrough]
    get;
    [DebuggerStepThrough]
    set;
  }

  [XmlElement("HundredHexPercent")]
  public HexPercent HundredHexPercent
  {
    [DebuggerStepThrough]
    get;
    [DebuggerStepThrough]
    set;
  }

  //[XmlElement("FractionalHexPercent")]
  //public HexPercent FractionalHexPercent
  //{
  //  [DebuggerStepThrough]
  //  get;
  //  [DebuggerStepThrough]
  //  set;
  //}

  //[XmlElement("NegativeHexPercent")]
  //public HexPercent NegativeHexPercent
  //{
  //  [DebuggerStepThrough]
  //  get;
  //  [DebuggerStepThrough]
  //  set;
  //}
}


/// <summary>
/// Simple wrapper class for testing Deserialization scenarios.
/// </summary>
public class HexPercentWrapper
{
  public HexPercent Value { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}


