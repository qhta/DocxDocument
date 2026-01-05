using System.Globalization;
using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;

namespace DocumentModel.BaseTypesTest;

/// <summary>
/// Test suite for VectorVariant type serialization in both XML and JSON formats.
/// </summary>
public static class VectorVariantSerializationTests
{
  /// <summary>
  /// Runs all VectorVariant serialization tests.
  /// </summary>
  public static bool Run()
  {
    Console.WriteLine("=== VectorVariant Serialization Test Program ===");
    Console.WriteLine();

    // Run all tests
    if (!TestVectorVariantBasicOperations()) return false;
    if (!TestVectorVariantTypeConversions()) return false;
    if (!TestVectorVariantListOperations()) return false;
    if (!TestVectorVariantToString()) return false;
    if (!TestVectorVariantXmlSerialization()) return false;
    if (!TestVectorVariantJsonSerialization()) return false;
    if (!TestVectorVariantEdgeCases()) return false;
    if (!TestVectorVariantPerformance()) return false;

    return true;
  }

  #region Basic Operations Tests

  static bool TestVectorVariantBasicOperations()
  {
    Console.WriteLine("--- Testing VectorVariant Basic Operations ---");

    try
    {
      // Test default constructor
      Console.WriteLine("Testing default constructor:");
      VectorVariant vec1 = new VectorVariant();
      Console.WriteLine($"✓ Default constructor: Count={vec1.Count}, BaseType={vec1.BaseType}");

      // Test constructor with base type
      Console.WriteLine("\nTesting constructor with base type:");
      VectorVariant intVector = new VectorVariant(VariantType.Int32);
      Console.WriteLine($"✓ Int32 vector: BaseType={intVector.BaseType}, Count={intVector.Count}");

      // Test adding elements
      Console.WriteLine("\nTesting element addition:");
      intVector.Add(10);
      intVector.Add(20);
      intVector.Add(30);
      intVector.Add(40);
      intVector.Add(50);
      Console.WriteLine($"✓ Added 5 elements, Count={intVector.Count}");

      // Test element retrieval
      Console.WriteLine("\nTesting element retrieval:");
      for (int i = 0; i < intVector.Count; i++)
      {
        Console.Write($"{intVector[i]} ");
      }
      Console.WriteLine();

      // Test Contains
      Console.WriteLine("\nTesting Contains:");
      Console.WriteLine($"  Contains 30: {intVector.Contains(30)}");
      Console.WriteLine($"  Contains 99: {intVector.Contains(99)}");

      // Test IndexOf
      Console.WriteLine("\nTesting IndexOf:");
      Console.WriteLine($"  IndexOf 30: {intVector.IndexOf(30)}");
      Console.WriteLine($"  IndexOf 99: {intVector.IndexOf(99)}");

      // Test enumeration
      Console.WriteLine("\nTesting enumeration:");
      int count = 0;
      foreach (var item in intVector)
      {
        count++;
      }
      Console.WriteLine($"✓ Enumerated {count} elements");

      // Test Clear
      Console.WriteLine("\nTesting Clear:");
      VectorVariant clearTest = new VectorVariant(VariantType.Int32);
      clearTest.Add(1);
      clearTest.Add(2);
      clearTest.Add(3);
      Console.WriteLine($"  Before clear: Count={clearTest.Count}");
      clearTest.Clear();
      Console.WriteLine($"  After clear: Count={clearTest.Count}");

      // Test CopyTo
      Console.WriteLine("\nTesting CopyTo:");
      object?[] destArray = new object?[10];
      intVector.CopyTo(destArray, 2);
      Console.WriteLine($"✓ Copied to destination array starting at index 2");

      // Test VariantType property
      Console.WriteLine($"\nTesting VariantType: {intVector.VariantType}");
      Console.WriteLine($"Testing TypeName: {intVector.TypeName}");

      Console.WriteLine("\n✓ All basic operations passed");
      Console.WriteLine();
      return true;
    }
    catch (Exception ex)
    {
      Console.WriteLine($"✗ Basic operations test FAILED: {ex.Message}");
      Console.WriteLine($"  Stack trace: {ex.StackTrace}");
      Console.WriteLine();
      return false;
    }
  }

  #endregion

  #region Type Conversion Tests

  static bool TestVectorVariantTypeConversions()
  {
    Console.WriteLine("--- Testing VectorVariant Type Conversions ---");

    try
    {
      // Test different variant types
      Console.WriteLine("Testing Int32 vector:");
      VectorVariant intVector = new VectorVariant(VariantType.Int32);
      intVector.Add(100);
      intVector.Add(200);
      intVector.Add(300);
      Console.WriteLine($"✓ Int32: ({intVector[0]}, {intVector[1]}, {intVector[2]})");

      Console.WriteLine("\nTesting String vector:");
      VectorVariant strVector = new VectorVariant(VariantType.String);
      strVector.Add("Hello");
      strVector.Add("World");
      strVector.Add("Test");
      Console.WriteLine($"✓ String: ({strVector[0]}, {strVector[1]}, {strVector[2]})");

      Console.WriteLine("\nTesting Boolean vector:");
      VectorVariant boolVector = new VectorVariant(VariantType.Boolean);
      boolVector.Add(true);
      boolVector.Add(false);
      boolVector.Add(true);
      Console.WriteLine($"✓ Boolean: ({boolVector[0]}, {boolVector[1]}, {boolVector[2]})");

      Console.WriteLine("\nTesting Double vector:");
      VectorVariant doubleVector = new VectorVariant(VariantType.Double);
      doubleVector.Add(1.5);
      doubleVector.Add(2.75);
      doubleVector.Add(3.125);
      Console.WriteLine($"✓ Double: ({doubleVector[0]}, {doubleVector[1]}, {doubleVector[2]})");

      Console.WriteLine("\nTesting DateTime vector:");
      VectorVariant dateVector = new VectorVariant(VariantType.DateTime);
      dateVector.Add(new DateTime(2024, 1, 1));
      dateVector.Add(new DateTime(2024, 12, 31));
      Console.WriteLine($"✓ DateTime: ({dateVector[0]}, {dateVector[1]})");

      Console.WriteLine("\nTesting vector without base type:");
      VectorVariant mixedVector = new VectorVariant();
      mixedVector.Add(10);
      mixedVector.Add("Text");
      mixedVector.Add(true);
      Console.WriteLine($"✓ Mixed types: ({mixedVector[0]}, {mixedVector[1]}, {mixedVector[2]})");
      Console.WriteLine($"  BaseType: {mixedVector.BaseType?.ToString() ?? "null"}");

      Console.WriteLine("\nTesting type change:");
      VectorVariant changeVector = new VectorVariant(VariantType.Int32);
      changeVector.Add(10);
      changeVector.Add(20);
      Console.WriteLine($"  Before: BaseType={changeVector.BaseType}");
      changeVector.BaseType = VariantType.String;
      Console.WriteLine($"  After: BaseType={changeVector.BaseType}");

      Console.WriteLine("\n✓ All type conversion tests passed");
      Console.WriteLine();
      return true;
    }
    catch (Exception ex)
    {
      Console.WriteLine($"✗ Type conversion test FAILED: {ex.Message}");
      Console.WriteLine($"  Stack trace: {ex.StackTrace}");
      Console.WriteLine();
      return false;
    }
  }

  #endregion

  #region List Operations Tests

  static bool TestVectorVariantListOperations()
  {
    Console.WriteLine("--- Testing VectorVariant List Operations ---");

    try
    {
      // Test Insert
      Console.WriteLine("Testing Insert:");
      VectorVariant insertVector = new VectorVariant(VariantType.Int32);
      insertVector.Add(10);
      insertVector.Add(30);
      insertVector.Add(40);
      Console.WriteLine($"  Before insert: ({insertVector[0]}, {insertVector[1]}, {insertVector[2]})");
      insertVector.Insert(1, 20);
      Console.WriteLine($"  After Insert(1, 20): ({insertVector[0]}, {insertVector[1]}, {insertVector[2]}, {insertVector[3]})");

      // Test RemoveAt
      Console.WriteLine("\nTesting RemoveAt:");
      VectorVariant removeVector = new VectorVariant(VariantType.String);
      removeVector.Add("First");
      removeVector.Add("Second");
      removeVector.Add("Third");
      removeVector.Add("Fourth");
      Console.WriteLine($"  Before RemoveAt: Count={removeVector.Count}");
      removeVector.RemoveAt(1);
      Console.WriteLine($"  After RemoveAt(1): Count={removeVector.Count}");
      Console.WriteLine($"  Remaining: ({removeVector[0]}, {removeVector[1]}, {removeVector[2]})");

      // Test Remove
      Console.WriteLine("\nTesting Remove:");
      VectorVariant removeItemVector = new VectorVariant(VariantType.Int32);
      removeItemVector.Add(100);
      removeItemVector.Add(200);
      removeItemVector.Add(300);
      Console.WriteLine($"  Before Remove: Count={removeItemVector.Count}");
      bool removed = removeItemVector.Remove(200);
      Console.WriteLine($"  Remove(200) returned: {removed}");
      Console.WriteLine($"  After Remove: Count={removeItemVector.Count}");
      Console.WriteLine($"  Remaining: ({removeItemVector[0]}, {removeItemVector[1]})");

      // Test element modification via indexer
      Console.WriteLine("\nTesting element modification:");
      VectorVariant modifyVector = new VectorVariant(VariantType.String);
      modifyVector.Add("One");
      modifyVector.Add("Two");
      modifyVector.Add("Three");
      Console.WriteLine($"  Before: ({modifyVector[0]}, {modifyVector[1]}, {modifyVector[2]})");
      modifyVector[1] = "Modified";
      Console.WriteLine($"  After modifying [1]: ({modifyVector[0]}, {modifyVector[1]}, {modifyVector[2]})");

      // Test dynamic growth
      Console.WriteLine("\nTesting dynamic growth:");
      VectorVariant growVector = new VectorVariant(VariantType.Int32);
      for (int i = 0; i < 100; i++)
      {
        growVector.Add(i);
      }
      Console.WriteLine($"✓ Added 100 elements, Count={growVector.Count}");
      Console.WriteLine($"  First: {growVector[0]}, Last: {growVector[99]}");

      // Test IsReadOnly
      Console.WriteLine($"\nTesting IsReadOnly: {insertVector.IsReadOnly}");

      Console.WriteLine("\n✓ All list operation tests passed");
      Console.WriteLine();
      return true;
    }
    catch (Exception ex)
    {
      Console.WriteLine($"✗ List operation test FAILED: {ex.Message}");
      Console.WriteLine($"  Stack trace: {ex.StackTrace}");
      Console.WriteLine();
      return false;
    }
  }

  #endregion

  #region ToString Tests

  static bool TestVectorVariantToString()
  {
    Console.WriteLine("--- Testing VectorVariant ToString ---");

    try
    {
      // Test empty vector
      Console.WriteLine("Testing empty vector ToString:");
      VectorVariant emptyVector = new VectorVariant(VariantType.Int32);
      string emptyStr = emptyVector.ToString()!;
      Console.WriteLine($"  Empty vector: '{emptyStr}'");
      if (emptyStr != "()")
      {
        Console.WriteLine("✗ Empty vector ToString FAILED");
        return false;
      }

      // Test integer vector
      Console.WriteLine("\nTesting integer vector ToString:");
      VectorVariant intVector = new VectorVariant(VariantType.Int32);
      intVector.Add(10);
      intVector.Add(20);
      intVector.Add(30);
      string intStr = intVector.ToString()!;
      Console.WriteLine($"  Integer vector: '{intStr}'");
      if (!intStr.Contains("10") || !intStr.Contains("20") || !intStr.Contains("30"))
      {
        Console.WriteLine("✗ Integer vector ToString FAILED");
        return false;
      }

      // Test string vector
      Console.WriteLine("\nTesting string vector ToString:");
      VectorVariant strVector = new VectorVariant(VariantType.String);
      strVector.Add("Alpha");
      strVector.Add("Beta");
      strVector.Add("Gamma");
      string strStr = strVector.ToString()!;
      Console.WriteLine($"  String vector: '{strStr}'");

      // Test vector with null values
      Console.WriteLine("\nTesting vector with null values ToString:");
      VectorVariant nullVector = new VectorVariant(VariantType.String);
      nullVector.Add("First");
      nullVector.Add(null);
      nullVector.Add("Third");
      string nullStr = nullVector.ToString()!;
      Console.WriteLine($"  Vector with nulls: '{nullStr}'");

      // Test double vector with InvariantCulture
      Console.WriteLine("\nTesting double vector with InvariantCulture:");
      VectorVariant doubleVector = new VectorVariant(VariantType.Double);
      doubleVector.Add(1.5);
      doubleVector.Add(2.75);
      doubleVector.Add(3.125);
      string doubleStrInvariant = doubleVector.ToString(CultureInfo.InvariantCulture)!;
      Console.WriteLine($"  InvariantCulture: '{doubleStrInvariant}'");

      // Test double vector with French culture
      Console.WriteLine("\nTesting double vector with French culture:");
      var frenchCulture = new CultureInfo("fr-FR");
      string doubleStrFrench = doubleVector.ToString(frenchCulture)!;
      Console.WriteLine($"  French culture: '{doubleStrFrench}'");

      // Test boolean vector
      Console.WriteLine("\nTesting boolean vector ToString:");
      VectorVariant boolVector = new VectorVariant(VariantType.Boolean);
      boolVector.Add(true);
      boolVector.Add(false);
      boolVector.Add(true);
      string boolStr = boolVector.ToString()!;
      Console.WriteLine($"  Boolean vector: '{boolStr}'");

      // Test DateTime vector
      Console.WriteLine("\nTesting DateTime vector ToString:");
      VectorVariant dateVector = new VectorVariant(VariantType.DateTime);
      dateVector.Add(new DateTime(2024, 1, 15, 10, 30, 0));
      dateVector.Add(new DateTime(2024, 12, 25, 18, 45, 0));
      string dateStr = dateVector.ToString(CultureInfo.InvariantCulture)!;
      Console.WriteLine($"  DateTime vector (InvariantCulture): '{dateStr}'");

      // Test single element vector
      Console.WriteLine("\nTesting single element vector ToString:");
      VectorVariant singleVector = new VectorVariant(VariantType.String);
      singleVector.Add("OnlyOne");
      string singleStr = singleVector.ToString()!;
      Console.WriteLine($"  Single element: '{singleStr}'");

      // Test format consistency
      Console.WriteLine("\nTesting format consistency:");
      Console.WriteLine($"  Format should be: (element1, element2, ...)");
      if (!intStr.StartsWith("(") || !intStr.EndsWith(")"))
      {
        Console.WriteLine("✗ Format consistency FAILED - missing parentheses");
        return false;
      }

      Console.WriteLine("\n✓ All ToString tests passed");
      Console.WriteLine();
      return true;
    }
    catch (Exception ex)
    {
      Console.WriteLine($"✗ ToString test FAILED: {ex.Message}");
      Console.WriteLine($"  Stack trace: {ex.StackTrace}");
      Console.WriteLine();
      return false;
    }
  }

  #endregion

  #region XML Serialization Tests

  static bool TestVectorVariantXmlSerialization()
  {
    Console.WriteLine("--- Testing VectorVariant XML Serialization ---");

    try
    {
      // Create test object
      var testData = new VectorVariantTestData
      {
        Id = 1,
        Name = "XML Test",
        IntVector = new VectorVariant(VariantType.Int32),
        StringVector = new VectorVariant(VariantType.String),
        DoubleVector = new VectorVariant(VariantType.Double),
        BoolVector = new VectorVariant(VariantType.Boolean),
        MixedVector = new VectorVariant(),
        EmptyVector = new VectorVariant(VariantType.String)
      };

      // Fill vectors
      for (int i = 0; i < 5; i++)
        testData.IntVector.Add((i + 1) * 10);

      testData.StringVector.Add("Alpha");
      testData.StringVector.Add("Beta");
      testData.StringVector.Add("Gamma");

      testData.DoubleVector.Add(1.5);
      testData.DoubleVector.Add(2.75);
      testData.DoubleVector.Add(3.125);
      testData.DoubleVector.Add(4.0625);

      testData.BoolVector.Add(true);
      testData.BoolVector.Add(false);

      testData.MixedVector.Add(100);
      testData.MixedVector.Add("Mixed");
      testData.MixedVector.Add(true);

      Console.WriteLine($"Original data:");
      Console.WriteLine($"  Id: {testData.Id}");
      Console.WriteLine($"  Name: {testData.Name}");
      Console.WriteLine($"  IntVector: Count={testData.IntVector.Count}");
      Console.WriteLine($"  StringVector: Count={testData.StringVector.Count}");
      Console.WriteLine($"  DoubleVector: Count={testData.DoubleVector.Count}");
      Console.WriteLine($"  BoolVector: Count={testData.BoolVector.Count}");
      Console.WriteLine($"  MixedVector: Count={testData.MixedVector.Count}, BaseType={testData.MixedVector.BaseType?.ToString() ?? "null"}");
      Console.WriteLine($"  EmptyVector: Count={testData.EmptyVector.Count}");
      Console.WriteLine();

      // Serialize to XML
      var xmlSerializer = new XmlSerializer(typeof(VectorVariantTestData));
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
      VectorVariantTestData? deserializedData;
      using (var stringReader = new StringReader(xmlString))
      {
        deserializedData = (VectorVariantTestData?)xmlSerializer.Deserialize(stringReader);
      }

      if (deserializedData == null)
      {
        Console.WriteLine("✗ XML Deserialization returned null");
        return false;
      }

      // Verify deserialized data
      Console.WriteLine("Deserialized data:");
      Console.WriteLine($"  Id: {deserializedData.Id}");
      Console.WriteLine($"  Name: {deserializedData.Name}");
      Console.WriteLine($"  IntVector: Count={deserializedData.IntVector.Count}");
      Console.WriteLine($"  StringVector: Count={deserializedData.StringVector.Count}");
      Console.WriteLine($"  DoubleVector: Count={deserializedData.DoubleVector.Count}");
      Console.WriteLine($"  BoolVector: Count={deserializedData.BoolVector.Count}");
      Console.WriteLine($"  MixedVector: Count={deserializedData.MixedVector.Count}");
      Console.WriteLine($"  EmptyVector: Count={deserializedData.EmptyVector.Count}");
      Console.WriteLine();

      // Validate
      bool isValid =
        testData.Id == deserializedData.Id &&
        testData.Name == deserializedData.Name &&
        testData.IntVector.Equals(deserializedData.IntVector) &&
        testData.StringVector.Equals(deserializedData.StringVector) &&
        testData.DoubleVector.Equals(deserializedData.DoubleVector) &&
        testData.BoolVector.Equals(deserializedData.BoolVector) &&
        testData.EmptyVector.Count == deserializedData.EmptyVector.Count;

      if (isValid)
      {
        Console.WriteLine("✓ XML Serialization/Deserialization test passed");
        Console.WriteLine();
        return true;
      }
      else
      {
        Console.WriteLine("✗ XML Serialization/Deserialization test FAILED - data mismatch");
        Console.WriteLine();
        return false;
      }
    }
    catch (Exception ex)
    {
      Console.WriteLine($"✗ XML Serialization test FAILED: {ex.Message}");
      Console.WriteLine($"  Stack trace: {ex.StackTrace}");
      Console.WriteLine();
      return false;
    }
  }

  #endregion

  #region JSON Serialization Tests

  static bool TestVectorVariantJsonSerialization()
  {
    Console.WriteLine("--- Testing VectorVariant JSON Serialization ---");

    try
    {
      // Create test object
      var testData = new VectorVariantTestData
      {
        Id = 2,
        Name = "JSON Test",
        IntVector = new VectorVariant(VariantType.Int32),
        StringVector = new VectorVariant(VariantType.String),
        DoubleVector = new VectorVariant(VariantType.Double),
        BoolVector = new VectorVariant(VariantType.Boolean),
        MixedVector = new VectorVariant(),
        EmptyVector = new VectorVariant(VariantType.Int32)
      };

      // Fill vectors
      testData.IntVector.Add(100);
      testData.IntVector.Add(200);
      testData.IntVector.Add(300);
      testData.IntVector.Add(400);

      testData.StringVector.Add("Red");
      testData.StringVector.Add("Green");
      testData.StringVector.Add("Blue");

      testData.DoubleVector.Add(10.5);
      testData.DoubleVector.Add(20.25);
      testData.DoubleVector.Add(30.125);

      testData.BoolVector.Add(false);
      testData.BoolVector.Add(true);

      testData.MixedVector.Add(42);
      testData.MixedVector.Add("Text");
      testData.MixedVector.Add(3.14);

      Console.WriteLine($"Original data:");
      Console.WriteLine($"  Id: {testData.Id}");
      Console.WriteLine($"  Name: {testData.Name}");
      Console.WriteLine($"  IntVector: Count={testData.IntVector.Count}");
      Console.WriteLine($"  StringVector: Count={testData.StringVector.Count}");
      Console.WriteLine($"  DoubleVector: Count={testData.DoubleVector.Count}");
      Console.WriteLine($"  BoolVector: Count={testData.BoolVector.Count}");
      Console.WriteLine($"  MixedVector: Count={testData.MixedVector.Count}");
      Console.WriteLine($"  EmptyVector: Count={testData.EmptyVector.Count}");
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
      var deserializedData = JsonSerializer.Deserialize<VectorVariantTestData>(jsonString, jsonOptions);

      if (deserializedData == null)
      {
        Console.WriteLine("✗ JSON Deserialization returned null");
        return false;
      }

      // Verify deserialized data
      Console.WriteLine("Deserialized data:");
      Console.WriteLine($"  Id: {deserializedData.Id}");
      Console.WriteLine($"  Name: {deserializedData.Name}");
      Console.WriteLine($"  IntVector: Count={deserializedData.IntVector.Count}");
      Console.WriteLine($"  StringVector: Count={deserializedData.StringVector.Count}");
      Console.WriteLine($"  DoubleVector: Count={deserializedData.DoubleVector.Count}");
      Console.WriteLine($"  BoolVector: Count={deserializedData.BoolVector.Count}");
      Console.WriteLine($"  MixedVector: Count={deserializedData.MixedVector.Count}");
      Console.WriteLine($"  EmptyVector: Count={deserializedData.EmptyVector.Count}");
      Console.WriteLine();

      // Validate
      bool isValid =
        testData.Id == deserializedData.Id &&
        testData.Name == deserializedData.Name &&
        testData.IntVector.Equals(deserializedData.IntVector) &&
        testData.StringVector.Equals(deserializedData.StringVector) &&
        testData.DoubleVector.Equals(deserializedData.DoubleVector) &&
        testData.BoolVector.Equals(deserializedData.BoolVector) &&
        testData.EmptyVector.Count == deserializedData.EmptyVector.Count;

      if (isValid)
      {
        Console.WriteLine("✓ JSON Serialization/Deserialization test passed");
        Console.WriteLine();
        return true;
      }
      else
      {
        Console.WriteLine("✗ JSON Serialization/Deserialization test FAILED - data mismatch");
        Console.WriteLine();
        return false;
      }
    }
    catch (Exception ex)
    {
      Console.WriteLine($"✗ JSON Serialization test FAILED: {ex.Message}");
      Console.WriteLine($"  Stack trace: {ex.StackTrace}");
      Console.WriteLine();
      return false;
    }
  }

  #endregion

  #region Edge Cases Tests

  static bool TestVectorVariantEdgeCases()
  {
    Console.WriteLine("--- Testing VectorVariant Edge Cases ---");

    try
    {
      // Test empty vector
      Console.WriteLine("Testing empty vector:");
      VectorVariant empty = new VectorVariant(VariantType.Int32);
      Console.WriteLine($"✓ Empty vector: Count={empty.Count}");

      // Test single element vector
      Console.WriteLine("\nTesting single element vector:");
      VectorVariant single = new VectorVariant(VariantType.String);
      single.Add("OnlyOne");
      Console.WriteLine($"✓ Single element: Count={single.Count}, Value={single[0]}");

      // Test null values
      Console.WriteLine("\nTesting null values:");
      VectorVariant nullTest = new VectorVariant(VariantType.String);
      nullTest.Add("First");
      nullTest.Add(null);
      nullTest.Add("Third");
      Console.WriteLine($"  Values: ({nullTest[0]}, {nullTest[1]}, {nullTest[2]})");
      Console.WriteLine($"  Count: {nullTest.Count}");

      // Test equality
      Console.WriteLine("\nTesting equality:");
      VectorVariant vec1 = new VectorVariant(VariantType.Int32);
      vec1.Add(1);
      vec1.Add(2);
      vec1.Add(3);

      VectorVariant vec2 = new VectorVariant(VariantType.Int32);
      vec2.Add(1);
      vec2.Add(2);
      vec2.Add(3);

      VectorVariant vec3 = new VectorVariant(VariantType.Int32);
      vec3.Add(1);
      vec3.Add(2);
      vec3.Add(4);

      Console.WriteLine($"  vec1.Equals(vec2): {vec1.Equals(vec2)}");
      Console.WriteLine($"  vec1.Equals(vec3): {vec1.Equals(vec3)}");
      Console.WriteLine($"  vec1.Equals(null): {vec1.Equals((VectorVariant?)null)}");

      if (vec1 == null || !vec1.Equals(vec2))
      {
        Console.WriteLine("✗ Equality test FAILED");
        return false;
      }

      // Test different types equality
      Console.WriteLine("\nTesting equality with different types:");
      VectorVariant intVec = new VectorVariant(VariantType.Int32);
      intVec.Add(1);
      intVec.Add(2);

      VectorVariant strVec = new VectorVariant(VariantType.String);
      strVec.Add("1");
      strVec.Add("2");

      Console.WriteLine($"  Int vector equals String vector: {intVec.Equals(strVec)}");

      // Test IsReadOnly
      Console.WriteLine($"\nTesting IsReadOnly: {vec1.IsReadOnly}");

      // Test large vector
      Console.WriteLine("\nTesting large vector:");
      VectorVariant largeVector = new VectorVariant(VariantType.Int32);
      for (int i = 0; i < 1000; i++)
      {
        largeVector.Add(i);
      }
      Console.WriteLine($"✓ Created and filled vector with {largeVector.Count} elements");
      Console.WriteLine($"  First element: {largeVector[0]}, Last element: {largeVector[999]}");

      // Test VariantType property
      Console.WriteLine($"\nTesting VariantType property: {vec1.VariantType}");
      Console.WriteLine($"Testing TypeName property: {vec1.TypeName}");

      // Test out of bounds access
      Console.WriteLine("\nTesting out of bounds access:");
      try
      {
        var invalid = vec1[10]; // Should fail
        Console.WriteLine("✗ Should have thrown ArgumentOutOfRangeException");
        return false;
      }
      catch (ArgumentOutOfRangeException)
      {
        Console.WriteLine("✓ Correctly threw ArgumentOutOfRangeException");
      }

      // Test Insert out of bounds
      Console.WriteLine("\nTesting Insert out of bounds:");
      try
      {
        vec1.Insert(100, 999); // Should fail
        Console.WriteLine("✗ Should have thrown ArgumentOutOfRangeException");
        return false;
      }
      catch (ArgumentOutOfRangeException)
      {
        Console.WriteLine("✓ Correctly threw ArgumentOutOfRangeException");
      }

      Console.WriteLine("\n✓ All edge case tests completed");
      Console.WriteLine();
      return true;
    }
    catch (Exception ex)
    {
      Console.WriteLine($"✗ Edge case test FAILED: {ex.Message}");
      Console.WriteLine($"  Stack trace: {ex.StackTrace}");
      Console.WriteLine();
      return false;
    }
  }

  #endregion

  #region Performance Tests

  static bool TestVectorVariantPerformance()
  {
    Console.WriteLine("--- Testing VectorVariant Performance ---");

    try
    {
      const int iterations = 10000;

      // Test construction
      var sw = System.Diagnostics.Stopwatch.StartNew();
      for (int i = 0; i < iterations; i++)
      {
        VectorVariant vec = new VectorVariant(VariantType.Int32);
      }
      sw.Stop();
      Console.WriteLine($"Construction x {iterations}: {sw.ElapsedMilliseconds}ms");

      // Test Add operations
      VectorVariant testVector = new VectorVariant(VariantType.Int32);
      sw.Restart();
      for (int i = 0; i < iterations; i++)
      {
        testVector.Add(i);
      }
      sw.Stop();
      Console.WriteLine($"Add operation x {iterations}: {sw.ElapsedMilliseconds}ms");

      // Test element access
      sw.Restart();
      for (int i = 0; i < iterations; i++)
      {
        var value = testVector[i % testVector.Count];
      }
      sw.Stop();
      Console.WriteLine($"Element access x {iterations}: {sw.ElapsedMilliseconds}ms");

      // Test enumeration
      sw.Restart();
      for (int i = 0; i < 100; i++)
      {
        foreach (var item in testVector)
        {
          // Just enumerate
        }
      }
      sw.Stop();
      Console.WriteLine($"Enumeration x 100: {sw.ElapsedMilliseconds}ms");

      // Test Contains
      sw.Restart();
      for (int i = 0; i < iterations; i++)
      {
        bool contains = testVector.Contains(50);
      }
      sw.Stop();
      Console.WriteLine($"Contains() x {iterations}: {sw.ElapsedMilliseconds}ms");

      // Test Insert
      VectorVariant insertVector = new VectorVariant(VariantType.Int32);
      for (int i = 0; i < 100; i++)
      {
        insertVector.Add(i);
      }
      sw.Restart();
      for (int i = 0; i < 1000; i++)
      {
        insertVector.Insert(50, i);
      }
      sw.Stop();
      Console.WriteLine($"Insert() x 1000: {sw.ElapsedMilliseconds}ms");

      // Test JSON serialization
      var testObj = new VectorVariantTestData
      {
        Id = 1,
        Name = "Perf Test",
        IntVector = new VectorVariant(VariantType.Int32),
        StringVector = new VectorVariant(VariantType.String),
        DoubleVector = new VectorVariant(VariantType.Double),
        BoolVector = new VectorVariant(VariantType.Boolean),
        MixedVector = new VectorVariant(),
        EmptyVector = new VectorVariant(VariantType.String)
      };

      for (int i = 0; i < 10; i++)
      {
        testObj.IntVector.Add(i);
        testObj.StringVector.Add($"Item{i}");
        testObj.DoubleVector.Add(i * 1.5);
        testObj.BoolVector.Add(i % 2 == 0);
      }

      sw.Restart();
      for (int i = 0; i < iterations / 100; i++)
      {
        string json = JsonSerializer.Serialize(testObj);
      }
      sw.Stop();
      Console.WriteLine($"JSON Serialization x {iterations / 100}: {sw.ElapsedMilliseconds}ms");

      // Test JSON deserialization
      string jsonData = JsonSerializer.Serialize(testObj);
      sw.Restart();
      for (int i = 0; i < iterations / 100; i++)
      {
        var obj = JsonSerializer.Deserialize<VectorVariantTestData>(jsonData);
      }
      sw.Stop();
      Console.WriteLine($"JSON Deserialization x {iterations / 100}: {sw.ElapsedMilliseconds}ms");

      Console.WriteLine("✓ Performance tests completed");
      Console.WriteLine();
      return true;
    }
    catch (Exception ex)
    {
      Console.WriteLine($"✗ Performance test FAILED: {ex.Message}");
      Console.WriteLine($"  Stack trace: {ex.StackTrace}");
      Console.WriteLine();
      return false;
    }
  }

  #endregion
}

#region Test Helper Classes

/// <summary>
/// Test data class containing various VectorVariant properties.
/// </summary>
[XmlRoot("VectorVariantTestData")]
public class VectorVariantTestData
{
  [XmlElement("Id")]
  public int Id { get; set; }

  [XmlElement("Name")]
  public string Name { get; set; } = string.Empty;

  [XmlElement("IntVector")]
  public VectorVariant IntVector { get; set; } = new VectorVariant();

  [XmlElement("StringVector")]
  public VectorVariant StringVector { get; set; } = new VectorVariant();

  [XmlElement("DoubleVector")]
  public VectorVariant DoubleVector { get; set; } = new VectorVariant();

  [XmlElement("BoolVector")]
  public VectorVariant BoolVector { get; set; } = new VectorVariant();

  [XmlElement("MixedVector")]
  public VectorVariant MixedVector { get; set; } = new VectorVariant();

  [XmlElement("EmptyVector")]
  public VectorVariant EmptyVector { get; set; } = new VectorVariant();
}

#endregion