using System.Globalization;

namespace DocumentModel.BaseTypesTest;

/// <summary>
/// Test suite for ArrayVariant type serialization in both XML and JSON formats.
/// </summary>
public static class ArrayVariantTests
{
  /// <summary>
  /// Runs all ArrayVariant serialization tests.
  /// </summary>
  public static bool Run()
  {
    Console.WriteLine("=== ArrayVariant Serialization Test Program ===");
    Console.WriteLine();

    // Run all tests
    if (!TestArrayVariantBasicOperations()) return false;
    if (!TestArrayVariantTypeConversions()) return false;
    if (!TestArrayVariantToString()) return false;
    if (!TestArrayVariantResizing()) return false;
    if (!TestArrayVariantXmlSerialization()) return false;
    if (!TestArrayVariantJsonSerialization()) return false;
    if (!TestArrayVariantEdgeCases()) return false;
    if (!TestArrayVariantPerformance()) return false;

    return true;
  }

  #region Basic Operations Tests

  static bool TestArrayVariantBasicOperations()
  {
    Console.WriteLine("--- Testing ArrayVariant Basic Operations ---");      // Test default constructor
    Console.WriteLine("Testing default constructor:");
    ArrayVariant arr1 = new ArrayVariant();
    Console.WriteLine($"\n✓ Default constructor: Size={arr1.Size}, Count={arr1.Count}");

    // Test constructor with size and type
    Console.WriteLine("\nTesting constructor with size and type:");
    ArrayVariant intArray = new ArrayVariant(VariantType.Int32, 5);
    Console.WriteLine($"\n✓ Int32 array: Size={intArray.Size}, LowerBounds={intArray.LowerBounds}, UpperBounds={intArray.UpperBounds}");

    // Test adding elements
    Console.WriteLine("\nTesting element assignment:");
    intArray[0] = 10;
    intArray[1] = 20;
    intArray[2] = 30;
    intArray[3] = 40;
    intArray[4] = 50;
    Console.WriteLine($"\n✓ Assigned 5 elements");

    // Test element retrieval
    Console.WriteLine("\nTesting element retrieval:");
    for (int i = 0; i < intArray.Size; i++)
    {
      Console.Write($"{intArray[i]} ");
    }
    Console.WriteLine();

    // Test Contains
    Console.WriteLine("\nTesting Contains:");
    Console.WriteLine($"  Contains 30: {intArray.Contains(30)}");
    Console.WriteLine($"  Contains 99: {intArray.Contains(99)}");

    // Test Count
    Console.WriteLine($"\nTesting Count: {intArray.Count} non-null elements");

    // Test enumeration
    Console.WriteLine("\nTesting enumeration:");
    int count = 0;
    foreach (var item in intArray)
    {
      count++;
    }
    Console.WriteLine($"\n✓ Enumerated {count} elements");

    // Test Clear
    Console.WriteLine("\nTesting Clear:");
    ArrayVariant clearTest = new ArrayVariant(VariantType.Int32, 3);
    clearTest[0] = 1;
    clearTest[1] = 2;
    clearTest[2] = 3;
    Console.WriteLine($"  Before clear: Count={clearTest.Count}");
    clearTest.Clear();
    Console.WriteLine($"  After clear: Count={clearTest.Count}");

    // Test CopyTo
    Console.WriteLine("\nTesting CopyTo:");
    object?[] destArray = new object?[10];
    intArray.CopyTo(destArray, 2);
    Console.WriteLine($"\n✓ Copied to destination array starting at index 2");

    Console.WriteLine("\n✓ All basic operations passed");
    Console.WriteLine();
    return true;
  }

  #endregion

  #region ValueType Conversion Tests

  static bool TestArrayVariantTypeConversions()
  {
    Console.WriteLine("--- Testing ArrayVariant ValueType Conversions ---");      // Test different variant types
    Console.WriteLine("Testing Int32 array:");
    ArrayVariant intArray = new ArrayVariant(VariantType.Int32, 3);
    intArray[0] = 100;
    intArray[1] = 200;
    intArray[2] = 300;
    Console.WriteLine($"\n✓ Int32: [{intArray[0]}, {intArray[1]}, {intArray[2]}]");

    Console.WriteLine("\nTesting String array:");
    ArrayVariant strArray = new ArrayVariant(VariantType.String, 3);
    strArray[0] = "Hello";
    strArray[1] = "World";
    strArray[2] = "Test";
    Console.WriteLine($"\n✓ String: [{strArray[0]}, {strArray[1]}, {strArray[2]}]");

    Console.WriteLine("\nTesting Boolean array:");
    ArrayVariant boolArray = new ArrayVariant(VariantType.Boolean, 3);
    boolArray[0] = true;
    boolArray[1] = false;
    boolArray[2] = true;
    Console.WriteLine($"\n✓ Boolean: [{boolArray[0]}, {boolArray[1]}, {boolArray[2]}]");

    Console.WriteLine("\nTesting Double array:");
    ArrayVariant doubleArray = new ArrayVariant(VariantType.Double, 3);
    doubleArray[0] = 1.5;
    doubleArray[1] = 2.75;
    doubleArray[2] = 3.125;
    Console.WriteLine($"\n✓ Double: [{doubleArray[0]}, {doubleArray[1]}, {doubleArray[2]}]");

    Console.WriteLine("\nTesting DateTime array:");
    ArrayVariant dateArray = new ArrayVariant(VariantType.DateTime, 2);
    dateArray[0] = new DateTime(2024, 1, 1);
    dateArray[1] = new DateTime(2024, 12, 31);
    Console.WriteLine($"\n✓ DateTime: [{dateArray[0]}, {dateArray[1]}]");

    Console.WriteLine("\nTesting type change (Int32 to String):");
    ArrayVariant changeArray = new ArrayVariant(VariantType.Int32, 3);
    changeArray[0] = 10;
    changeArray[1] = 20;
    changeArray[2] = 30;
    Console.WriteLine($"  Before: BaseType={changeArray.BaseType}, [{changeArray[0]}, {changeArray[1]}, {changeArray[2]}]");
    changeArray.BaseType = VariantType.String;
    Console.WriteLine($"  After: BaseType={changeArray.BaseType}, [{changeArray[0]}, {changeArray[1]}, {changeArray[2]}]");

    Console.WriteLine("\n✓ All type conversion tests passed");
    Console.WriteLine();
    return true;
  }

  #endregion

  #region ToString Tests

  static bool TestArrayVariantToString()
  {
    Console.WriteLine("--- Testing ArrayVariant ToString ---");      // Test empty array
    Console.WriteLine("Testing empty array ToString:");
    ArrayVariant emptyArray = new ArrayVariant(VariantType.Int32, 0);
    string emptyStr = emptyArray.ToString()!;
    Console.WriteLine($"  Empty array: '{emptyStr}'");
    if (emptyStr != "[]")
    {
      Console.WriteLine("✗ Empty array ToString FAILED");
      return false;
    }

    // Test integer array
    Console.WriteLine("\nTesting integer array ToString:");
    ArrayVariant intArray = new ArrayVariant(VariantType.Int32, 5);
    intArray[0] = 10;
    intArray[1] = 20;
    intArray[2] = 30;
    intArray[3] = 40;
    intArray[4] = 50;
    string intStr = intArray.ToString()!;
    Console.WriteLine($"  Integer array: '{intStr}'");
    if (!intStr.Contains("10") || !intStr.Contains("20") || !intStr.Contains("50"))
    {
      Console.WriteLine("✗ Integer array ToString FAILED");
      return false;
    }

    // Test string array
    Console.WriteLine("\nTesting string array ToString:");
    ArrayVariant strArray = new ArrayVariant(VariantType.String, 3);
    strArray[0] = "Alpha";
    strArray[1] = "Beta";
    strArray[2] = "Gamma";
    string strStr = strArray.ToString()!;
    Console.WriteLine($"  String array: '{strStr}'");
    if (!strStr.Contains("Alpha") || !strStr.Contains("Beta") || !strStr.Contains("Gamma"))
    {
      Console.WriteLine("✗ String array ToString FAILED");
      return false;
    }

    // Test array with null values
    Console.WriteLine("\nTesting array with null values ToString:");
    ArrayVariant nullArray = new ArrayVariant(VariantType.String, 3);
    nullArray[0] = "First";
    nullArray[1] = null;
    nullArray[2] = "Third";
    string nullStr = nullArray.ToString()!;
    Console.WriteLine($"  Array with nulls: '{nullStr}'");
    if (!nullStr.Contains("First") || !nullStr.Contains("Third"))
    {
      Console.WriteLine("✗ Array with nulls ToString FAILED");
      return false;
    }

    // Test double array with InvariantCulture
    Console.WriteLine("\nTesting double array with InvariantCulture:");
    ArrayVariant doubleArray = new ArrayVariant(VariantType.Double, 3);
    doubleArray[0] = 1.5;
    doubleArray[1] = 2.75;
    doubleArray[2] = 3.125;
    string doubleStrInvariant = doubleArray.ToString(CultureInfo.InvariantCulture)!;
    Console.WriteLine($"  InvariantCulture: '{doubleStrInvariant}'");

    // Test double array with different culture (French uses comma as decimal separator)
    Console.WriteLine("\nTesting double array with French culture:");
    var frenchCulture = new CultureInfo("fr-FR");
    string doubleStrFrench = doubleArray.ToString(frenchCulture)!;
    Console.WriteLine($"  French culture: '{doubleStrFrench}'");

    // Test boolean array
    Console.WriteLine("\nTesting boolean array ToString:");
    ArrayVariant boolArray = new ArrayVariant(VariantType.Boolean, 3);
    boolArray[0] = true;
    boolArray[1] = false;
    boolArray[2] = true;
    string boolStr = boolArray.ToString()!;
    Console.WriteLine($"  Boolean array: '{boolStr}'");
    if (!boolStr.Contains("True") || !boolStr.Contains("False"))
    {
      Console.WriteLine("✗ Boolean array ToString FAILED");
      return false;
    }

    // Test DateTime array
    Console.WriteLine("\nTesting DateTime array ToString:");
    ArrayVariant dateArray = new ArrayVariant(VariantType.DateTime, 2);
    dateArray[0] = new DateTime(2024, 1, 15, 10, 30, 0);
    dateArray[1] = new DateTime(2024, 12, 25, 18, 45, 0);
    string dateStr = dateArray.ToString(CultureInfo.InvariantCulture)!;
    Console.WriteLine($"  DateTime array (InvariantCulture): '{dateStr}'");

    // Test DateTime array with different culture
    string dateStrUs = dateArray.ToString(new CultureInfo("en-US"))!;
    Console.WriteLine($"  DateTime array (en-US): '{dateStrUs}'");

    // Test single element array
    Console.WriteLine("\nTesting single element array ToString:");
    ArrayVariant singleArray = new ArrayVariant(VariantType.String, 1);
    singleArray[0] = "OnlyOne";
    string singleStr = singleArray.ToString()!;
    Console.WriteLine($"  Single element: '{singleStr}'");
    if (!singleStr.Contains("OnlyOne"))
    {
      Console.WriteLine("✗ Single element ToString FAILED");
      return false;
    }

    // Test custom bounds array
    Console.WriteLine("\nTesting custom bounds array ToString:");
    ArrayVariant customArray = new ArrayVariant(VariantType.Int32, 5, 7);
    customArray[5] = 50;
    customArray[6] = 60;
    customArray[7] = 70;
    string customStr = customArray.ToString()!;
    Console.WriteLine($"  Custom bounds (5-7): '{customStr}'");
    if (!customStr.Contains("50") || !customStr.Contains("60") || !customStr.Contains("70"))
    {
      Console.WriteLine("✗ Custom bounds ToString FAILED");
      return false;
    }

    // Test format consistency
    Console.WriteLine("\nTesting format consistency:");
    Console.WriteLine($"  Format should be: [element1, element2, ...]");
    if (!intStr.StartsWith("[") || !intStr.EndsWith("]"))
    {
      Console.WriteLine("✗ Format consistency FAILED - missing parentheses");
      return false;
    }
    if (!intStr.Contains(","))
    {
      Console.WriteLine("✗ Format consistency FAILED - missing comma separator");
      return false;
    }

    // Test decimal formatting with specific culture
    Console.WriteLine("\nTesting decimal formatting:");
    ArrayVariant decimalArray = new ArrayVariant(VariantType.Decimal, 2);
    decimalArray[0] = 1234.56m;
    decimalArray[1] = 7890.12m;
    string decimalStrInvariant = decimalArray.ToString(CultureInfo.InvariantCulture)!;
    Console.WriteLine($"  Decimal (InvariantCulture): '{decimalStrInvariant}'");

    var germanCulture = new CultureInfo("de-DE");
    string decimalStrGerman = decimalArray.ToString(germanCulture)!;
    Console.WriteLine($"  Decimal (de-DE): '{decimalStrGerman}'");

    // Test performance of ToString
    Console.WriteLine("\nTesting ToString performance:");
    var perfArray = new ArrayVariant(VariantType.Int32, 100);
    for (int i = 0; i < 100; i++)
    {
      perfArray[i] = i;
    }

    var sw = System.Diagnostics.Stopwatch.StartNew();
    for (int i = 0; i < 1000; i++)
    {
      string result = perfArray.ToString()!;
    }
    sw.Stop();
    Console.WriteLine($"  ToString() x 1000 (100 elements): {sw.ElapsedMilliseconds}ms");

    Console.WriteLine("\n✓ All ToString tests passed");
    Console.WriteLine();
    return true;
  }

  #endregion

  #region Resizing Tests

  static bool TestArrayVariantResizing()
  {
    Console.WriteLine("--- Testing ArrayVariant Resizing ---");      // Test resize with size only
    Console.WriteLine("Testing resize with size:");
    ArrayVariant arr = new ArrayVariant(VariantType.Int32, 3);
    arr[0] = 10;
    arr[1] = 20;
    arr[2] = 30;
    Console.WriteLine($"  Original: Size={arr.Size}, Values=[{arr[0]}, {arr[1]}, {arr[2]}]");

    arr.Resize(5);
    Console.WriteLine($"  After Resize(5): Size={arr.Size}");
    Console.Write($"  Values: ");
    for (int i = 0; i < arr.Size; i++)
    {
      Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();

    // Test resize with size and type
    Console.WriteLine("\nTesting resize with size and type change:");
    arr.Resize(3, VariantType.String);
    Console.WriteLine($"  After Resize(3, String): BaseType={arr.BaseType}, Size={arr.Size}");
    Console.Write($"  Values: ");
    for (int i = 0; i < arr.Size; i++)
    {
      Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();

    // Test resize with custom bounds
    Console.WriteLine("\nTesting resize with custom bounds:");
    arr.Resize(1, 3);
    Console.WriteLine($"  After Resize(1, 3): LowerBounds={arr.LowerBounds}, UpperBounds={arr.UpperBounds}, Size={arr.Size}");

    arr[1] = 1.1;
    arr[2] = 2.2;
    arr[3] = 3.3;
    Console.Write($"  Values: ");
    for (int i = 1; i <= 3; i++)
    {
      Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();

    // Test resize with bounds and type
    Console.WriteLine("\nTesting resize with bounds and type:");
    arr.Resize(0, 2, VariantType.Double);
    Console.WriteLine($"  After Resize(0, 2, Double): BaseType={arr.BaseType}, LowerBounds={arr.LowerBounds}, UpperBounds={arr.UpperBounds}");

    arr[0] = 1.1;
    arr[1] = 2.2;
    arr[2] = 3.3;
    Console.Write($"  Values: ");
    for (int i = 0; i <= 2; i++)
    {
      Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();

    // Test shrinking
    Console.WriteLine("\nTesting shrinking:");
    ArrayVariant shrinkArray = new ArrayVariant(VariantType.Int32, 5);
    for (int i = 0; i < 5; i++)
    {
      shrinkArray[i] = (i + 1) * 10;
    }
    Console.WriteLine($"  Before shrink: Size={shrinkArray.Size}, Count={shrinkArray.Count}");

    shrinkArray.Resize(2);
    Console.WriteLine($"  After Resize(2): Size={shrinkArray.Size}, Count={shrinkArray.Count}");
    Console.WriteLine($"  Remaining values: [{shrinkArray[0]}, {shrinkArray[1]}]");

    Console.WriteLine("\n✓ All resizing tests passed");
    Console.WriteLine();
    return true;
  }

  #endregion

  #region XML Serialization Tests

  static bool TestArrayVariantXmlSerialization()
  {
    Console.WriteLine("--- Testing ArrayVariant XML Serialization ---");      // Create test object
    var testData = CreateTestData();
    ShowOriginalData(testData);

    // Serialize to XML
    var xmlSerializer = new XmlSerializer(typeof(ArrayVariantTestData));
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
    ArrayVariantTestData? deserializedData;
    using (var stringReader = new StringReader(xmlString))
    {
      deserializedData = (ArrayVariantTestData?)xmlSerializer.Deserialize(stringReader);
    }

    if (!VerifyDeserializedData(deserializedData, testData)) return false;
    Console.WriteLine("\n✓ XML Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;
  }

  private static void ShowOriginalData(ArrayVariantTestData testData)
  {
    Console.WriteLine($"Original data:");
    Console.WriteLine($"  IntArray: Size={testData.IntArray.Size}, Count={testData.IntArray.Count}");
    Console.WriteLine($"  StringArray: Size={testData.StringArray.Size}, Count={testData.StringArray.Count}");
    Console.WriteLine($"  DoubleArray: Size={testData.DoubleArray.Size}, Count={testData.DoubleArray.Count}");
    Console.WriteLine($"  BoolArray: Size={testData.BoolArray.Size}, Count={testData.BoolArray.Count}");
    Console.WriteLine($"  CustomBoundsArray: LowerBounds={testData.CustomBoundsArray.LowerBounds}, UpperBounds={testData.CustomBoundsArray.UpperBounds}");
    Console.WriteLine($"  EmptyArray: Size={testData.EmptyArray.Size}");
    Console.WriteLine();
  }

  private static ArrayVariantTestData CreateTestData()
  {
    var testData = new ArrayVariantTestData
    {
      IntArray = new ArrayVariant(VariantType.Int32, 5),
      StringArray = new ArrayVariant(VariantType.String, 3),
      DoubleArray = new ArrayVariant(VariantType.Double, 4),
      BoolArray = new ArrayVariant(VariantType.Boolean, 2),
      CustomBoundsArray = new ArrayVariant(VariantType.Int32, 1, 3),
      EmptyArray = new ArrayVariant(VariantType.String, 0)
    };

    // Fill arrays
    for (int i = 0; i < 5; i++)
      testData.IntArray[i] = (i + 1) * 10;

    testData.StringArray[0] = "Alpha";
    testData.StringArray[1] = "Beta";
    testData.StringArray[2] = "Gamma";

    testData.DoubleArray[0] = 1.5;
    testData.DoubleArray[1] = 2.75;
    testData.DoubleArray[2] = 3.125;
    testData.DoubleArray[3] = 4.0625;

    testData.BoolArray[0] = true;
    testData.BoolArray[1] = false;

    testData.CustomBoundsArray[1] = 100;
    testData.CustomBoundsArray[2] = 200;
    testData.CustomBoundsArray[3] = 300;
    return testData;
  }

  private static bool VerifyDeserializedData(ArrayVariantTestData? deserializedData, ArrayVariantTestData testData)
  {
    if (deserializedData == null)
    {
      Console.WriteLine("✗ Deserialization returned null");
      return false;
    }

    // Verify deserialized data
    Console.WriteLine("Deserialized data:");
    Console.WriteLine($"  IntArray: Size={deserializedData.IntArray.Size}, Count={deserializedData.IntArray.Count}");
    if (!testData.IntArray.Equals(deserializedData.IntArray))
      return false;
    Console.WriteLine($"  StringArray: Size={deserializedData.StringArray.Size}, Count={deserializedData.StringArray.Count}");
    if (!testData.StringArray.Equals(deserializedData.StringArray))
      return false;
    Console.WriteLine($"  DoubleArray: Size={deserializedData.DoubleArray.Size}, Count={deserializedData.DoubleArray.Count}");
    if (!testData.DoubleArray.Equals(deserializedData.DoubleArray))
      return false;
    Console.WriteLine($"  BoolArray: Size={deserializedData.BoolArray.Size}, Count={deserializedData.BoolArray.Count}");
    if (!testData.BoolArray.Equals(deserializedData.BoolArray))
      return false;
    Console.WriteLine($"  CustomBoundsArray: LowerBounds={deserializedData.CustomBoundsArray.LowerBounds}, UpperBounds={deserializedData.CustomBoundsArray.UpperBounds}");
    if (!testData.CustomBoundsArray.Equals(deserializedData.CustomBoundsArray))
      return false;
    Console.WriteLine($"  EmptyArray: Size={deserializedData.EmptyArray.Size}");
    if (testData.EmptyArray.Size != deserializedData.EmptyArray.Size)
      return false;

    return true;
  }

  #endregion

  #region JSON Serialization Tests

  static bool TestArrayVariantJsonSerialization()
  {
    Console.WriteLine("--- Testing ArrayVariant JSON Serialization ---");      // Create test object
    var testData = CreateTestData();
    ShowOriginalData(testData); 
    Console.WriteLine();

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
    var deserializedData = JsonSerializer.Deserialize<ArrayVariantTestData>(jsonString, jsonOptions);

    if (!VerifyDeserializedData(deserializedData, testData)) return false;
    Console.WriteLine("\n✓ JSON Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;
  }

  #endregion

  #region Edge Cases Tests

  static bool TestArrayVariantEdgeCases()
  {
    Console.WriteLine("--- Testing ArrayVariant Edge Cases ---");      // Test empty array
    Console.WriteLine("Testing empty array:");
    ArrayVariant empty = new ArrayVariant(VariantType.Int32, 0);
    Console.WriteLine($"\n✓ Empty array: Size={empty.Size}, Count={empty.Count}");

    // Test single element array
    Console.WriteLine("\nTesting single element array:");
    ArrayVariant single = new ArrayVariant(VariantType.String, 1);
    single[0] = "OnlyOne";
    Console.WriteLine($"\n✓ Single element: Size={single.Size}, Value={single[0]}");

    // Test null values
    Console.WriteLine("\nTesting null values:");
    ArrayVariant nullTest = new ArrayVariant(VariantType.String, 3);
    nullTest[0] = "First";
    nullTest[1] = null;
    nullTest[2] = "Third";
    Console.WriteLine($"  Values: [{nullTest[0]}, {nullTest[1]}, {nullTest[2]}]");
    Console.WriteLine($"  Count (non-null): {nullTest.Count}");

    // Test Add method
    Console.WriteLine("\nTesting Add method:");
    ArrayVariant addTest = new ArrayVariant(VariantType.Int32, 3);
    addTest.Add(10);
    addTest.Add(20);
    addTest.Add(30);
    Console.WriteLine($"\n✓ Added 3 elements: [{addTest[0]}, {addTest[1]}, {addTest[2]}]");

    // Test equality
    Console.WriteLine("\nTesting equality:");
    ArrayVariant arr1 = new ArrayVariant(VariantType.Int32, 3);
    arr1[0] = 1;
    arr1[1] = 2;
    arr1[2] = 3;

    ArrayVariant arr2 = new ArrayVariant(VariantType.Int32, 3);
    arr2[0] = 1;
    arr2[1] = 2;
    arr2[2] = 3;

    ArrayVariant arr3 = new ArrayVariant(VariantType.Int32, 3);
    arr3[0] = 1;
    arr3[1] = 2;
    arr3[2] = 4;

    Console.WriteLine($"  arr1.Equals(arr2): {arr1.Equals(arr2)}");
    Console.WriteLine($"  arr1.Equals(arr3): {arr1.Equals(arr3)}");
    Console.WriteLine($"  arr1.Equals(null): {arr1.Equals(null)}");

    if (arr1 == null || !arr1.Equals(arr2))
    {
      Console.WriteLine("✗ Equality test FAILED");
      return false;
    }

    // Test different types equality
    Console.WriteLine("\nTesting equality with different types:");
    ArrayVariant intArr = new ArrayVariant(VariantType.Int32, 2);
    intArr[0] = 1;
    intArr[1] = 2;

    ArrayVariant strArr = new ArrayVariant(VariantType.String, 2);
    strArr[0] = "1";
    strArr[1] = "2";

    Console.WriteLine($"  Int array equals String array: {intArr.Equals(strArr)}");

    // Test Remove (should not work)
    Console.WriteLine("\nTesting Remove (not supported):");
    bool removed = arr1.Remove(2);
    Console.WriteLine($"  Remove returned: {removed} (expected false)");

    // Test IsReadOnly
    Console.WriteLine($"\nTesting IsReadOnly: {arr1.IsReadOnly}");

    // Test large array
    Console.WriteLine("\nTesting large array:");
    ArrayVariant largeArray = new ArrayVariant(VariantType.Int32, 1000);
    for (int i = 0; i < 1000; i++)
    {
      largeArray[i] = i;
    }
    Console.WriteLine($"\n✓ Created and filled array with {largeArray.Size} elements");
    Console.WriteLine($"  First element: {largeArray[0]}, Last element: {largeArray[999]}");

    // Test VariantType property
    Console.WriteLine($"\nTesting VariantType property: {arr1.VariantType}");

    Console.WriteLine("\n✓ All edge case tests completed");
    Console.WriteLine();
    return true;
  }

  #endregion

  #region Performance Tests

  static bool TestArrayVariantPerformance()
  {
    Console.WriteLine("--- Testing ArrayVariant Performance ---"); const int iterations = 10000;

    // Test construction
    var sw = System.Diagnostics.Stopwatch.StartNew();
    for (int i = 0; i < iterations; i++)
    {
      ArrayVariant arr = new ArrayVariant(VariantType.Int32, 10);
    }
    sw.Stop();
    Console.WriteLine($"Construction (10 elements) x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test element assignment
    ArrayVariant testArray = new ArrayVariant(VariantType.Int32, 100);
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      for (int j = 0; j < 100; j++)
      {
        testArray[j] = j;
      }
    }
    sw.Stop();
    Console.WriteLine($"Element assignment (100 elements) x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test element access
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      for (int j = 0; j < 100; j++)
      {
        var value = testArray[j];
      }
    }
    sw.Stop();
    Console.WriteLine($"Element access (100 elements) x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test enumeration
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      foreach (var item in testArray)
      {
        // Just enumerate
      }
    }
    sw.Stop();
    Console.WriteLine($"Enumeration (100 elements) x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test Contains
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      bool contains = testArray.Contains(50);
    }
    sw.Stop();
    Console.WriteLine($"Contains() x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test Resize
    sw.Restart();
    for (int i = 0; i < iterations / 10; i++)
    {
      ArrayVariant resizeArr = new ArrayVariant(VariantType.Int32, 10);
      resizeArr.Resize(20);
    }
    sw.Stop();
    Console.WriteLine($"Resize (10 to 20) x {iterations / 10}: {sw.ElapsedMilliseconds}ms");

    // Test JSON serialization
    var testObj = new ArrayVariantTestData
    {
      IntArray = new ArrayVariant(VariantType.Int32, 10),
      StringArray = new ArrayVariant(VariantType.String, 10),
      DoubleArray = new ArrayVariant(VariantType.Double, 10),
      BoolArray = new ArrayVariant(VariantType.Boolean, 10),
      CustomBoundsArray = new ArrayVariant(VariantType.Int32, 1, 10),
      EmptyArray = new ArrayVariant(VariantType.String, 0)
    };

    for (int i = 0; i < 10; i++)
    {
      testObj.IntArray[i] = i;
      testObj.StringArray[i] = $"Item{i}";
      testObj.DoubleArray[i] = i * 1.5;
      testObj.BoolArray[i] = i % 2 == 0;
      testObj.CustomBoundsArray[i + 1] = i * 10;
    }

    sw.Restart();
    for (int i = 0; i < iterations / 100; i++)
    {
      string json = JsonSerializer.Serialize(testObj);
    }
    sw.Stop();
    Console.WriteLine($"JSON Serialization x {iterations / 100}: {sw.ElapsedMilliseconds}ms");

    // Test Deserialization
    string jsonData = JsonSerializer.Serialize(testObj);
    sw.Restart();
    for (int i = 0; i < iterations / 100; i++)
    {
      var obj = JsonSerializer.Deserialize<ArrayVariantTestData>(jsonData);
    }
    sw.Stop();
    Console.WriteLine($"Deserialization x {iterations / 100}: {sw.ElapsedMilliseconds}ms");

    Console.WriteLine("\n✓ Performance tests completed");
    Console.WriteLine();
    return true;
  }

  #endregion
}

#region Test Helper Classes

/// <summary>
/// Test data class containing various ArrayVariant properties.
/// </summary>
[XmlRoot("ArrayVariantTestData")]
public class ArrayVariantTestData
{
  [XmlElement("IntArray")]
  public ArrayVariant IntArray { get; set; } = new ArrayVariant();

  [XmlElement("StringArray")]
  public ArrayVariant StringArray { get; set; } = new ArrayVariant();

  [XmlElement("DoubleArray")]
  public ArrayVariant DoubleArray { get; set; } = new ArrayVariant();

  [XmlElement("BoolArray")]
  public ArrayVariant BoolArray { get; set; } = new ArrayVariant();

  [XmlElement("CustomBoundsArray")]
  public ArrayVariant CustomBoundsArray { get; set; } = new ArrayVariant();

  [XmlElement("EmptyArray")]
  public ArrayVariant EmptyArray { get; set; } = new ArrayVariant();
}

#endregion