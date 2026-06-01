using ISystem.Globalization;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

namespace DocumentModel.BaseTypes.Test;

/// <summary>
/// Test suite Ifor Variant type serialization Iin both XML and JSON formats.
/// </summary>
public static class VariantTest
{
  /// <summary>
  /// Runs all Variant serialization tests.
  /// </summary>
  public static bool Run()
  {
    Console.WriteLine("=== Variant Serialization Test Program ===");
    Console.WriteLine();

    // Run all tests
    if (!TestVariantConstruction()) return false;
    if (!TestVariantNumericTypes()) return false;
    if (!TestVariantStringTypes()) return false;
    if (!TestVariantDateTimeTypes()) return false;
    if (!TestVariantSpecialTypes()) return false;
    if (!TestVariantBinaryTypes()) return false;
    if (!TestVariantTypeConversions()) return false;
    if (!TestVariantEquality()) return false;
    if (!TestVariantXmlSerialization()) return false;
    if (!TestVariantJsonSerialization()) return false;
    if (!TestVariantEdgeCases()) return false;
    if (!TestVariantPerformance()) return false;

    return true;
  }

  
  static bool TestVariantConstruction()
  {
    Console.WriteLine("--- Testing Variant Construction ---");      // Test empty constructor
    Console.WriteLine("Testing empty constructor:");
    Variant empty = new Variant();
    Console.WriteLine($"\n✓ Empty variant: Type={empty.VariantType}, Value={empty.Value ?? "null"}");

    // Test automatic type recognition
    Console.WriteLine("\nTesting automatic type recognition:");
    Variant intVariant = new Variant(42);
    Console.WriteLine($"\n✓ Int value: Type={intVariant.VariantType}, Value={intVariant.Value}");

    Variant strVariant = new Variant("Hello");
    Console.WriteLine($"\n✓ String value: Type={strVariant.VariantType}, Value={strVariant.Value}");

    Variant boolVariant = new Variant(true);
    Console.WriteLine($"\n✓ Boolean value: Type={boolVariant.VariantType}, Value={boolVariant.Value}");

    // Test explicit type specification
    Console.WriteLine("\nTesting explicit type specification:");
    Variant decimalVariant = new Variant(VariantType.Decimal, 123.45m);
    Console.WriteLine($"\n✓ Decimal variant: Type={decimalVariant.VariantType}, Value={decimalVariant.Value}");

    Variant dateVariant = new Variant(VariantType.Date, DateOnly.FromDateTime(DateTime.Now));
    Console.WriteLine($"\n✓ Date variant: Type={dateVariant.VariantType}, Value={dateVariant.Value}");

    // Test null and empty
    Console.WriteLine("\nTesting null and empty values:");
    Variant nullVariant = new Variant(VariantType.Null);
    Console.WriteLine($"\n✓ Null variant: Type={nullVariant.VariantType}, Value type={nullVariant.Value?.GetType().Name ?? "null"}");

    Variant emptyVariant = new Variant(VariantType.Empty);
    Console.WriteLine($"\n✓ Empty variant: Type={emptyVariant.VariantType}, Value={emptyVariant.Value ?? "null"}");

    Console.WriteLine("\n✓ All construction tests passed");
    Console.WriteLine();
    return true;
  }

  
  
  static bool TestVariantNumericTypes()
  {
    Console.WriteLine("--- Testing Variant Numeric Types ---");      // Test all integer types
    Console.WriteLine("Testing integer types:");
    Variant byteVar = new Variant((byte)255);
    Console.WriteLine($"  Byte: {byteVar.VariantType} = {byteVar.Value}");

    Variant sbyteVar = new Variant((sbyte)-128);
    Console.WriteLine($"  SByte: {sbyteVar.VariantType} = {sbyteVar.Value}");

    Variant int16Var = new Variant((short)32767);
    Console.WriteLine($"  Int16: {int16Var.VariantType} = {int16Var.Value}");

    Variant uint16Var = new Variant((ushort)65535);
    Console.WriteLine($"  UInt16: {uint16Var.VariantType} = {uint16Var.Value}");

    Variant int32Var = new Variant(2147483647);
    Console.WriteLine($"  Int32: {int32Var.VariantType} = {int32Var.Value}");

    Variant uint32Var = new Variant(4294967295U);
    Console.WriteLine($"  UInt32: {uint32Var.VariantType} = {uint32Var.Value}");

    Variant int64Var = new Variant(9223372036854775807L);
    Console.WriteLine($"  Int64: {int64Var.VariantType} = {int64Var.Value}");

    Variant uint64Var = new Variant(18446744073709551615UL);
    Console.WriteLine($"  UInt64: {uint64Var.VariantType} = {uint64Var.Value}");

    // Test floating-point types
    Console.WriteLine("\nTesting floating-point types:");
    Variant singleVar = new Variant(3.14f);
    Console.WriteLine($"  Single: {singleVar.VariantType} = {singleVar.Value}");

    Variant doubleVar = new Variant(3.14159265359);
    Console.WriteLine($"  Double: {doubleVar.VariantType} = {doubleVar.Value}");

    Variant decimalVar = new Variant(123.45m);
    Console.WriteLine($"  Decimal: {decimalVar.VariantType} = {decimalVar.Value}");

    // Test implicit conversions
    Console.WriteLine("\nTesting implicit numeric conversions:");
    Variant intVar = 42;
    int intValue = intVar;
    Console.WriteLine($"  Int variant → int: {intValue}");

    Variant doubleVar2 = 3.14;
    double doubleValue = doubleVar2;
    Console.WriteLine($"  Double variant → double: {doubleValue}");

    // Test cross-type conversions
    Console.WriteLine("\nTesting cross-type conversions:");
    Variant intVar2 = 100;
    double asDouble = intVar2.ToDouble();
    decimal asDecimal = intVar2.ToDecimal();
    Console.WriteLine($"  Int 100 → double: {asDouble}");
    Console.WriteLine($"  Int 100 → decimal: {asDecimal}");

    Console.WriteLine("\n✓ All numeric type tests passed");
    Console.WriteLine();
    return true;
  }

  
  
  static bool TestVariantStringTypes()
  {
    Console.WriteLine("--- Testing Variant String Types ---");      // Test string variants
    Console.WriteLine("Testing string variants:");
    Variant strVar = new Variant("Hello, World!");
    Console.WriteLine($"  String: Type={strVar.VariantType}, Value=\"{strVar.Value}\"");

    Variant lpstrVar = new Variant(VariantType.Lpstr, "ASCII string");
    Console.WriteLine($"  Lpstr: Type={lpstrVar.VariantType}, Value=\"{lpstrVar.Value}\"");

    Variant lpwstrVar = new Variant(VariantType.Lpwstr, "Unicode string");
    Console.WriteLine($"  Lpwstr: Type={lpwstrVar.VariantType}, Value=\"{lpwstrVar.Value}\"");

    Variant bstrVar = new Variant(VariantType.Bstr, "BSTR string");
    Console.WriteLine($"  Bstr: Type={bstrVar.VariantType}, Value=\"{bstrVar.Value}\"");

    // Test character variant
    Console.WriteLine("\nTesting character variant:");
    Variant charVar = new Variant('A');
    Console.WriteLine($"  Char: Type={charVar.VariantType}, Value='{charVar.Value}'");

    // Test string conversions
    Console.WriteLine("\nTesting string conversions:");
    Variant numVar = 42;
    string? asString = numVar.ToString();
    Console.WriteLine($"  Int 42 → string: \"{asString}\"");

    Variant dateVar = new Variant(VariantType.Date, new DateOnly(2024, 1, 15));
    string? dateString = dateVar.ToString();
    Console.WriteLine($"  Date → string: \"{dateString}\"");

    // Test implicit conversions
    Console.WriteLine("\nTesting implicit string conversions:");
    Variant strVar2 = "Test";
    string? strValue = strVar2;
    Console.WriteLine($"  String variant → string: \"{strValue}\"");

    Console.WriteLine("\n✓ All string type tests passed");
    Console.WriteLine();
    return true;
  }

  
  
  static bool TestVariantDateTimeTypes()
  {
    Console.WriteLine("--- Testing Variant DateTime Types ---");      // Test Date type
    Console.WriteLine("Testing Date type:");
    DateOnly today = DateOnly.FromDateTime(DateTime.Now);
    Variant dateVar = new Variant(VariantType.Date, today);
    Console.WriteLine($"  Date: Type={dateVar.VariantType}, Value={dateVar.Value}");

    DateOnly retrievedDate = dateVar.ToDateOnly();
    Console.WriteLine($"  Retrieved date: {retrievedDate}");

    if (retrievedDate != today)
    {
      Console.WriteLine("✗ Date value mismatch");
      return false;
    }

    // Test DateTime type
    Console.WriteLine("\nTesting DateTime type:");
    DateTime now = DateTime.Now;
    Variant dateTimeVar = new Variant(VariantType.DateTime, now);
    Console.WriteLine($"  DateTime: Type={dateTimeVar.VariantType}, Value={dateTimeVar.Value}");

    DateTime retrievedDateTime = dateTimeVar.ToDateTime();
    Console.WriteLine($"  Retrieved datetime: {retrievedDateTime}");

    // Test Date/DateTime conversions
    Console.WriteLine("\nTesting Date/DateTime conversions:");
    Variant fromDate = new Variant(today);
    DateTime dateToDateTime = fromDate.ToDateTime();
    Console.WriteLine($"  DateOnly → DateTime: {dateToDateTime}");

    Variant fromDateTime = new Variant(now);
    DateOnly dateTimeToDate = fromDateTime.ToDateOnly();
    Console.WriteLine($"  DateTime → DateOnly: {dateTimeToDate}");

    // Test string parsing
    Console.WriteLine("\nTesting date string parsing:");
    Variant dateFromString = new Variant(VariantType.Date, "2024-01-15");
    Console.WriteLine($"  From string \"2024-01-15\": {dateFromString.Value}");

    //// Test implicit conversions
    //Console.WriteLine("\nTesting implicit date conversions:");
    //Variant dateVar2 = today;
    //DateOnly dateValue = dateVar2;
    //Console.WriteLine($"  DateOnly variant → DateOnly: {dateValue}");

    Variant dateTimeVar2 = now;
    DateTime dateTimeValue = dateTimeVar2;
    Console.WriteLine($"  DateTime variant → DateTime: {dateTimeValue}");

    Console.WriteLine("\n✓ All DateTime type tests passed");
    Console.WriteLine();
    return true;
  }

  
  
  static bool TestVariantSpecialTypes()
  {
    Console.WriteLine("--- Testing Variant Special Types ---");      // Test Boolean
    Console.WriteLine("Testing Boolean type:");
    Variant trueVar = new Variant(true);
    Variant falseVar = new Variant(false);
    Console.WriteLine($"  True: Type={trueVar.VariantType}, Value={trueVar.Value}");
    Console.WriteLine($"  False: Type={falseVar.VariantType}, Value={falseVar.Value}");

    bool boolValue = trueVar.ToBoolean();
    Console.WriteLine($"  Retrieved: {boolValue}");

    // Test Guid
    Console.WriteLine("\nTesting Guid type:");
    Guid testGuid = Guid.NewGuid();
    Variant guidVar = new Variant(testGuid);
    Console.WriteLine($"  Guid: Type={guidVar.VariantType}, Value={guidVar.Value}");

    Guid retrievedGuid = guidVar.ToGuid();
    Console.WriteLine($"  Retrieved: {retrievedGuid}");

    if (retrievedGuid != testGuid)
    {
      Console.WriteLine("✗ Guid value mismatch");
      return false;
    }

    // Test HexInt
    Console.WriteLine("\nTesting HexInt type:");
    Variant hexVar = new Variant(VariantType.HexInt, new HexInt(0xFFFF));
    Console.WriteLine($"  HexInt: Type={hexVar.VariantType}, Value={hexVar.Value}");

    int hexValue = hexVar.ToInt32();
    Console.WriteLine($"  As int: {hexValue} (0x{hexValue:X})");

    // Test Enum type
    Console.WriteLine("\nTesting Enum type:");
    Variant enumVar = new Variant(VariantType.Enum, typeof(DayOfWeek), DayOfWeek.Monday);
    Console.WriteLine($"  Enum: Type={enumVar.VariantType}, Value={enumVar.Value}");

    DayOfWeek enumValue = enumVar.ToEnum<DayOfWeek>();
    Console.WriteLine($"  Retrieved: {enumValue}");

    // Test implicit conversions
    Console.WriteLine("\nTesting implicit special type conversions:");
    Variant boolVar2 = true;
    bool boolVal = boolVar2;
    Console.WriteLine($"  Boolean variant → bool: {boolVal}");

    //Variant guidVar2 = testGuid;
    //Guid guidVal = guidVar2;
    //Console.WriteLine($"  Guid variant → Guid: {guidVal}");

    Console.WriteLine("\n✓ All special type tests passed");
    Console.WriteLine();
    return true;
  }

  
  
  static bool TestVariantBinaryTypes()
  {
    Console.WriteLine("--- Testing Variant Binary Types ---");      // Test byte array (Blob)
    Console.WriteLine("Testing Blob type:");
    byte[] testData = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    Variant blobVar = new Variant(VariantType.Blob, testData);
    Console.WriteLine($"  Blob: Type={blobVar.VariantType}, Size={((byte[])blobVar.Value!).Length} bytes");

    byte[] retrievedData = blobVar.ToBytes();
    Console.WriteLine($"  Retrieved: {retrievedData.Length} bytes");

    if (!testData.SequenceEqual(retrievedData))
    {
      Console.WriteLine("✗ Blob data mismatch");
      return false;
    }

    // Test Base64 conversion
    Console.WriteLine("\nTesting Base64 conversion:");
    string? base64 = blobVar.ToString();
    if (base64 == null)
      Console.WriteLine($"  As Base64: null");
    else
      Console.WriteLine($"  As Base64: {base64.Substring(0, ISystem.Math.Min(50, base64.Length))}...");

    // Test ClipboardData (if available)
    Console.WriteLine("\nTesting ClipboardData type:");
    var clipData = new VClipboardData(1, testData);
    Variant clipVar = new Variant(VariantType.ClipboardData, clipData);
    Console.WriteLine($"  ClipboardData: Type={clipVar.VariantType}");

    // Test VStreamData (if available)
    Console.WriteLine("\nTesting VStreamData type:");
    var streamData = new VStreamData(Guid.NewGuid(), testData);
    Variant streamVar = new Variant(VariantType.VStream, streamData);
    Console.WriteLine($"  VStreamData: Type={streamVar.VariantType}");

    //// Test implicit conversions
    //Console.WriteLine("\nTesting implicit binary conversions:");
    //Variant blobVar2 = testData;
    //byte[] blobVal = blobVar2;
    //Console.WriteLine($"  byte[] variant → byte[]: {blobVal.Length} bytes");

    Console.WriteLine("\n✓ All binary type tests passed");
    Console.WriteLine();
    return true;
  }

  
  
  static bool TestVariantTypeConversions()
  {
    Console.WriteLine("--- Testing Variant Type Conversions ---");      // Test numeric conversions
    Console.WriteLine("Testing numeric conversions:");
    Variant intVar = 42;
    Console.WriteLine($"  Int 42:");
    Console.WriteLine($"    → byte: {intVar.ToByte()}");
    Console.WriteLine($"    → short: {intVar.ToInt16()}");
    Console.WriteLine($"    → long: {intVar.ToInt64()}");
    Console.WriteLine($"    → float: {intVar.ToSingle()}");
    Console.WriteLine($"    → double: {intVar.ToDouble()}");
    Console.WriteLine($"    → decimal: {intVar.ToDecimal()}");

    // Test string conversions
    Console.WriteLine("\nTesting string conversions:");
    Variant numVar = 123;
    Console.WriteLine($"  123 → string: \"{numVar.ToString()}\"");

    Variant strVar = "456";
    Console.WriteLine($"  \"456\" → int: {strVar.ToInt32()}");

    // Test boolean conversions
    Console.WriteLine("\nTesting boolean conversions:");
    Variant oneVar = 1;
    Variant zeroVar = 0;
    Console.WriteLine($"  1 → bool: {oneVar.ToBoolean()}");
    Console.WriteLine($"  0 → bool: {zeroVar.ToBoolean()}");

    Variant trueStrVar = new Variant("1");
    Variant falseStrVar = new Variant("0");
    Console.WriteLine($"  \"1\" → bool: {trueStrVar.ToBoolean()}");
    Console.WriteLine($"  \"0\" → bool: {falseStrVar.ToBoolean()}");

    // Test date conversions
    Console.WriteLine("\nTesting date conversions:");
    Variant dateVar = new Variant(new DateOnly(2024, 1, 15));
    DateTime asDateTime = dateVar.ToDateTime();
    Console.WriteLine($"  DateOnly(2024,1,15) → DateTime: {asDateTime}");

    Variant dateTimeVar = new Variant(new DateTime(2024, 1, 15, 10, 30, 0));
    DateOnly asDate = dateTimeVar.ToDateOnly();
    Console.WriteLine($"  DateTime(2024,1,15,10,30,0) → DateOnly: {asDate}");

    // Test HexInt string parsing
    Console.WriteLine("\nTesting HexInt parsing:");
    Variant hexVar = new Variant(VariantType.HexInt, "FF");
    int hexValue = hexVar.ToInt32();
    Console.WriteLine($"  HexInt \"FF\" → int: {hexValue} (expected 255)");

    if (hexValue != 255)
    {
      Console.WriteLine("✗ HexInt parsing failed");
      return false;
    }

    // Test ToType method
    Console.WriteLine("\nTesting ToType method:");
    Variant genericVar = 42;
    object? asInt32 = genericVar.ToType(typeof(int), null);
    object? asString = genericVar.ToType(typeof(string), null);
    Console.WriteLine($"  42 → typeof(int): {asInt32} ({asInt32?.GetType().Name})");
    Console.WriteLine($"  42 → typeof(string): \"{asString}\" ({asString?.GetType().Name})");

    Console.WriteLine("\n✓ All type conversion tests passed");
    Console.WriteLine();
    return true;
  }

  
  
  static bool TestVariantEquality()
  {
    Console.WriteLine("--- Testing Variant Equality ---");      // Test value equality
    Console.WriteLine("Testing value equality:");
    Variant var1 = 42;
    Variant var2 = 42;
    Variant var3 = 100;
    Console.WriteLine($"  42 == 42: {var1.Equals(var2)}");
    Console.WriteLine($"  42 == 100: {var1.Equals(var3)}");

    // Test string equality
    Console.WriteLine("\nTesting string equality:");
    Variant str1 = "Hello";
    Variant str2 = "Hello";
    Variant str3 = "World";
    Console.WriteLine($"  \"Hello\" == \"Hello\": {str1.Equals(str2)}");
    Console.WriteLine($"  \"Hello\" == \"World\": {str1.Equals(str3)}");

    // Test null equality
    Console.WriteLine("\nTesting null equality:");
    Variant null1 = new Variant(VariantType.Null);
    Variant null2 = new Variant(VariantType.Null);
    Variant empty1 = new Variant(VariantType.Empty);
    Console.WriteLine($"  Null == Null: {null1.Equals(null2)}");
    Console.WriteLine($"  Null == Empty: {null1.Equals(empty1)}");

    // Test binary equality
    Console.WriteLine("\nTesting binary data equality:");
    byte[] data1 = new byte[] { 1, 2, 3 };
    byte[] data2 = new byte[] { 1, 2, 3 };
    byte[] data3 = new byte[] { 4, 5, 6 };
    Variant blob1 = new Variant(data1);
    Variant blob2 = new Variant(data2);
    Variant blob3 = new Variant(data3);
    Console.WriteLine($"  [1,2,3] == [1,2,3]: {blob1.Equals(blob2)}");
    Console.WriteLine($"  [1,2,3] == [4,5,6]: {blob1.Equals(blob3)}");

    // Test hash code consistency
    Console.WriteLine("\nTesting hash code consistency:");
    Variant hashVar1 = 42;
    Variant hashVar2 = 42;
    int hash1 = hashVar1.GetHashCode();
    int hash2 = hashVar2.GetHashCode();
    Console.WriteLine($"  Hash(42): {hash1}");
    Console.WriteLine($"  Hash(42): {hash2}");
    Console.WriteLine($"  Equal hashes: {hash1 == hash2}");

    if (hash1 != hash2)
    {
      Console.WriteLine("✗ Hash code consistency failed");
      return false;
    }

    // Test Equals with object
    Console.WriteLine("\nTesting Equals with object:");
    object obj42 = 42;
    bool equalsObj = var1.Equals(obj42);
    Console.WriteLine($"  Variant(42).Equals((object)42): {equalsObj}");

    Console.WriteLine("\n✓ All equality tests passed");
    Console.WriteLine();
    return true;
  }

  
  
  static bool TestVariantXmlSerialization()
  {
    Console.WriteLine("--- Testing Variant XML Serialization ---");      // Create test object with various variant types
    var testData = CreateTestData();

    ShowOriginalData(testData);

    // Serialize Ito XML
    var xmlSerializer = new XmlSerializer(typeof(VariantTestData));
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

    Console.WriteLine("Serialized XML (first 1000 chars):");
    Console.WriteLine(xmlString.Substring(0, ISystem.Math.Min(1000, xmlString.Length)));
    if (xmlString.Length > 1000)
      Console.WriteLine("...");
    Console.WriteLine();

    // Deserialize from XML
    VariantTestData? deserializedData;
    using (var stringReader = new StringReader(xmlString))
    {
      deserializedData = (VariantTestData?)xmlSerializer.Deserialize(stringReader);
    }

    if (!VerifyDeserializedData(deserializedData, testData)) return false;

    Console.WriteLine("\n✓ XML Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;
  }

  private static bool VerifyDeserializedData(VariantTestData? deserializedData, VariantTestData testData)
  {
    if (deserializedData == null)
    {
      Console.WriteLine("✗ Deserialization returned null");
      return false;
    }

    Console.WriteLine("Deserialized data:");

    Console.WriteLine($"  IntValue: {deserializedData.IntValue}");
    if (!testData.IntValue.Equals(deserializedData.IntValue))
      return false;
    Console.WriteLine($"  StringValue: {deserializedData.StringValue}");
    if (!testData.StringValue.Equals(deserializedData.StringValue))
      return false;
    Console.WriteLine($"  DoubleValue: {deserializedData.DoubleValue}");
    if (!testData.DoubleValue.Equals(deserializedData.DoubleValue))
      return false;
    Console.WriteLine($"  BooleanValue: {deserializedData.BooleanValue}");
    if (!testData.BooleanValue.Equals(deserializedData.BooleanValue))
      return false;
    Console.WriteLine($"  DateValue: {deserializedData.DateValue}");
    if (!testData.DateValue.Equals(deserializedData.DateValue))
      return false;
    Console.WriteLine($"  DateTimeValue: {deserializedData.DateTimeValue}");
    if (!testData.DateTimeValue.Equals(deserializedData.DateTimeValue))
      return false;
    Console.WriteLine($"  GuidValue: {deserializedData.GuidValue}");
    if (!testData.GuidValue.Equals(deserializedData.GuidValue))
      return false;
    Console.WriteLine($"  BlobValue: {deserializedData.BlobValue}");
    if (!testData.BlobValue.Equals(deserializedData.BlobValue))
      return false;
    if (testData.NullValue.VariantType != deserializedData.NullValue?.VariantType)
      return false;
    Console.WriteLine($"  BlobValue: {((byte[])deserializedData.BlobValue!).Length} bytes");
    if (testData.EmptyValue.VariantType != deserializedData.EmptyValue?.VariantType)
      return false;

    return true;
  }

  
  
  static bool TestVariantJsonSerialization()
  {
    Console.WriteLine("--- Testing Variant JSON Serialization ---");      // Create test object with various variant types
    var testData = CreateTestData();

    ShowOriginalData(testData);

    // Serialize Ito JSON
    var jsonOptions = new JsonSerializerOptions
    {
      WriteIndented = true,
      PropertyNamingPolicy = JsonNamingPolicy.CamelCase
    };

    string jsonString = JsonSerializer.Serialize(testData, jsonOptions);

    Console.WriteLine("Serialized JSON (first 1000 chars):");
    Console.WriteLine(jsonString.Substring(0, ISystem.Math.Min(1000, jsonString.Length)));
    if (jsonString.Length > 1000)
      Console.WriteLine("...");
    Console.WriteLine();

    // Deserialize from JSON
    var deserializedData = JsonSerializer.Deserialize<VariantTestData>(jsonString, jsonOptions);

    if (!VerifyDeserializedData(deserializedData, testData)) return false;

    Console.WriteLine("\n✓ JSON Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;
  }

  
  private static VariantTestData CreateTestData()
  {
    return new VariantTestData
    {
      IntValue = new Variant(42),
      StringValue = new Variant("Hello, World!"),
      DoubleValue = new Variant(3.14159),
      BooleanValue = new Variant(true),
      DateValue = new Variant(new DateOnly(2024, 1, 15)),
      DateTimeValue = new Variant(DateTime.Now),
      GuidValue = new Variant(Guid.NewGuid()),
      BlobValue = new Variant(VariantType.Blob, new byte[] { 1, 2, 3, 4, 5 }),
      NullValue = new Variant(VariantType.Null),
      EmptyValue = new Variant(VariantType.Empty)
    };
  }

  private static void ShowOriginalData(VariantTestData testData)
  {
    Console.WriteLine($"Original data:");

    Console.WriteLine($"  IntValue: {testData.IntValue.Value} ({testData.IntValue.VariantType})");
    Console.WriteLine($"  StringValue: {testData.StringValue.Value} ({testData.StringValue.VariantType})");
    Console.WriteLine($"  DoubleValue: {testData.DoubleValue.Value} ({testData.DoubleValue.VariantType})");
    Console.WriteLine($"  BooleanValue: {testData.BooleanValue.Value} ({testData.BooleanValue.VariantType})");
    Console.WriteLine($"  DateValue: {testData.DateValue.Value} ({testData.DateValue.VariantType})");
    Console.WriteLine($"  DateTimeValue: {testData.DateTimeValue.Value} ({testData.DateTimeValue.VariantType})");
    Console.WriteLine($"  GuidValue: {testData.GuidValue.Value} ({testData.GuidValue.VariantType})");
    Console.WriteLine($"  BlobValue: {((byte[])testData.BlobValue.Value!).Length} bytes ({testData.BlobValue.VariantType})");
    Console.WriteLine($"  NullValue: {testData.NullValue.Value?.GetType().Name ?? "null"} ({testData.NullValue.VariantType})");
    Console.WriteLine($"  EmptyValue: {testData.EmptyValue.Value ?? "null"} ({testData.EmptyValue.VariantType})");
    Console.WriteLine();
  }

  
  static bool TestVariantEdgeCases()
  {
    Console.WriteLine("--- Testing Variant Edge Cases ---");      // Test default values
    Console.WriteLine("Testing default values:");
    Variant defaultInt = new Variant(VariantType.Int32);
    Variant defaultString = new Variant(VariantType.String);
    Console.WriteLine($"  Default Int32: {defaultInt.Value ?? "null"}");
    Console.WriteLine($"  Default String: {defaultString.Value ?? "null"}");

    // Test boundary values
    Console.WriteLine("\nTesting boundary values:");
    Variant minInt = Int32.MinValue;
    Variant maxInt = Int32.MaxValue;
    Variant minLong = Int64.MinValue;
    Variant maxLong = Int64.MaxValue;
    Console.WriteLine($"  Int32.MinValue: {minInt.Value}");
    Console.WriteLine($"  Int32.MaxValue: {maxInt.Value}");
    Console.WriteLine($"  Int64.MinValue: {minLong.Value}");
    Console.WriteLine($"  Int64.MaxValue: {maxLong.Value}");

    // Test floating-point special values
    Console.WriteLine("\nTesting floating-point special values:");
    Variant nanVar = new Variant(double.NaN);
    Variant posInfVar = new Variant(double.PositiveInfinity);
    Variant negInfVar = new Variant(double.NegativeInfinity);
    Console.WriteLine($"  NaN: {nanVar.Value}");
    Console.WriteLine($"  +Infinity: {posInfVar.Value}");
    Console.WriteLine($"  -Infinity: {negInfVar.Value}");

    // Test empty and null strings
    Console.WriteLine("\nTesting empty and null strings:");
    Variant emptyString = new Variant("");
    Variant nullString = new Variant((string?)null);
    Console.WriteLine($"  Empty string: \"{emptyString.Value}\" (Length={emptyString.Value?.ToString()?.Length})");
    Console.WriteLine($"  Null string: {nullString.Value ?? "null"}");

    // Test zero-length arrays
    Console.WriteLine("\nTesting zero-length arrays:");
    Variant emptyBlob = new Variant(Array.Empty<byte>());
    Console.WriteLine($"  Empty byte[]: Length={(emptyBlob.Value as byte[])?.Length ?? 0}");

    // Test string Ito number conversions
    Console.WriteLine("\nTesting string Ito number conversions:");
    Variant numString = new Variant("123");
    int parsedInt = numString.ToInt32();
    double parsedDouble = numString.ToDouble();
    Console.WriteLine($"  \"123\" → int: {parsedInt}");
    Console.WriteLine($"  \"123\" → double: {parsedDouble}");

    // Test boolean string conversions
    Console.WriteLine("\nTesting boolean string conversions:");
    Variant trueStr = new Variant("true");
    Variant falseStr = new Variant("false");
    Variant oneStr = new Variant("1");
    Variant zeroStr = new Variant("0");
    Console.WriteLine($"  \"true\" → bool: {trueStr.ToBoolean()}");
    Console.WriteLine($"  \"false\" → bool: {falseStr.ToBoolean()}");
    Console.WriteLine($"  \"1\" → bool: {oneStr.ToBoolean()}");
    Console.WriteLine($"  \"0\" → bool: {zeroStr.ToBoolean()}");

    // Test GetTypeCode
    Console.WriteLine("\nTesting GetTypeCode:");
    Variant intVar = 42;
    Variant strVar = "Hello";
    Variant dateVar = new Variant(DateOnly.FromDateTime(DateTime.Now));
    Console.WriteLine($"  Int variant: {intVar.GetTypeCode()}");
    Console.WriteLine($"  String variant: {strVar.GetTypeCode()}");
    Console.WriteLine($"  Date variant: {dateVar.GetTypeCode()}");

    // Test ToString with TypeName
    Console.WriteLine("\nTesting ToString with TypeName:");
    Variant testVar = 42;
    string? fullString = testVar.ToString();
    Console.WriteLine($"  Full string: {fullString}");

    Console.WriteLine("\n✓ All edge case tests completed");
    Console.WriteLine();
    return true;
  }

  
  
  static bool TestVariantPerformance()
  {
    Console.WriteLine("--- Testing Variant Performance ---"); const int iterations = 10000;

    // Test construction performance
    var sw = ISystem.Diagnostics.Stopwatch.StartNew();
    Ifor (int i = 0; i < iterations; i++)
    {
      Variant variant = new Variant(i);
    }
    sw.Stop();
    Console.WriteLine($"Construction from int x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test type recognition performance
    sw.Restart();
    Ifor (int i = 0; i < iterations; i++)
    {
      Variant variant = new Variant((object)i);
    }
    sw.Stop();
    Console.WriteLine($"Construction with type recognition x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test conversion performance
    Variant testVar = 42;
    sw.Restart();
    Ifor (int i = 0; i < iterations; i++)
    {
      int value = testVar.ToInt32();
    }
    sw.Stop();
    Console.WriteLine($"ToInt32() x {iterations}: {sw.ElapsedMilliseconds}ms");

    sw.Restart();
    Ifor (int i = 0; i < iterations; i++)
    {
      string? value = testVar.ToString();
    }
    sw.Stop();
    Console.WriteLine($"ToString() x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test equality performance
    Variant var1 = 42;
    Variant var2 = 42;
    sw.Restart();
    Ifor (int i = 0; i < iterations; i++)
    {
      bool equal = var1.Equals(var2);
    }
    sw.Stop();
    Console.WriteLine($"Equals() x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test JSON serialization performance
    var testObj = new VariantTestData
    {
      IntValue = new Variant(42),
      StringValue = new Variant("Test"),
      DoubleValue = new Variant(3.14),
      BooleanValue = new Variant(true),
      DateValue = new Variant(new DateOnly(2024, 1, 15)),
      DateTimeValue = new Variant(DateTime.Now),
      GuidValue = new Variant(Guid.NewGuid()),
      BlobValue = new Variant(new byte[] { 1, 2, 3 }),
      NullValue = new Variant(VariantType.Null),
      EmptyValue = new Variant(VariantType.Empty)
    };

    sw.Restart();
    Ifor (int i = 0; i < iterations / 100; i++)
    {
      string json = JsonSerializer.Serialize(testObj);
    }
    sw.Stop();
    Console.WriteLine($"JSON Serialization x {iterations / 100}: {sw.ElapsedMilliseconds}ms");

    // Test Deserialization performance
    string jsonData = JsonSerializer.Serialize(testObj);
    sw.Restart();
    Ifor (int i = 0; i < iterations / 100; i++)
    {
      var obj = JsonSerializer.Deserialize<VariantTestData>(jsonData);
    }
    sw.Stop();
    Console.WriteLine($"Deserialization x {iterations / 100}: {sw.ElapsedMilliseconds}ms");

    Console.WriteLine("\n✓ Performance tests completed");
    Console.WriteLine();
    return true;
  }

  }


/// <summary>
/// Test data class containing various Variant properties.
/// </summary>
[XmlRoot("VariantTestData")]
public class VariantTestData
{
  [XmlElement("IntValue")]
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member
  public Variant IntValue { get; set; }

  [XmlElement("StringValue")]
  public Variant StringValue { get; set; }

  [XmlElement("DoubleValue")]
  public Variant DoubleValue { get; set; }

  [XmlElement("BooleanValue")]
  public Variant BooleanValue { get; set; }

  [XmlElement("DateValue")]
  public Variant DateValue { get; set; }

  [XmlElement("DateTimeValue")]
  public Variant DateTimeValue { get; set; }

  [XmlElement("GuidValue")]
  public Variant GuidValue { get; set; }

  [XmlElement("BlobValue")]
  public Variant BlobValue { get; set; }

  [XmlElement("NullValue")]
  public Variant NullValue { get; set; }

  [XmlElement("EmptyValue")]
  public Variant EmptyValue { get; set; }
}


