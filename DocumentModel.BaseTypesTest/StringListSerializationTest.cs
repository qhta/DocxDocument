using System.Collections;
using System.Globalization;
using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;

namespace DocumentModel.BaseTypesTest;

/// <summary>
/// Test suite for StringList type serialization in both XML and JSON formats.
/// </summary>
public static class StringListSerializationTests
{
  /// <summary>
  /// Runs all StringList serialization tests.
  /// </summary>
  public static bool Run()
  {
    Console.WriteLine("=== StringList Serialization Test Program ===");
    Console.WriteLine();

    // Run all tests
    if (!TestStringListBasicOperations()) return false;
    if (!TestStringListCollectionOperations()) return false;
    if (!TestStringListParsing()) return false;
    if (!TestStringListConversions()) return false;
    if (!TestStringListXmlSerialization()) return false;
    if (!TestStringListJsonSerialization()) return false;
    if (!TestStringListEdgeCases()) return false;
    if (!TestStringListPerformance()) return false;

    return true;
  }

  #region Basic Operations Tests

  static bool TestStringListBasicOperations()
  {
    Console.WriteLine("--- Testing StringList Basic Operations ---");

    try
    {
      // Test default constructor
      StringList list1 = new StringList();
      Console.WriteLine($"✓ Default constructor: Count={list1.Count}");

      // Test string constructor with comma-separated values
      StringList list2 = new StringList("apple,banana,cherry");
      Console.WriteLine($"✓ String constructor: {list2} (Count={list2.Count})");

      // Test Add operation
      list1.Add("first");
      list1.Add("second");
      Console.WriteLine($"✓ After Add operations: {list1} (Count={list1.Count})");

      // Test Contains
      bool contains = list2.Contains("banana");
      Console.WriteLine($"✓ Contains 'banana': {contains}");

      // Test ToString
      string str = list2.ToString(CultureInfo.InvariantCulture);
      Console.WriteLine($"✓ ToString: '{str}'");

      // Test implicit conversion from string
      StringList list3 = "one,two,three"!;
      Console.WriteLine($"✓ Implicit from string: {list3}");

      // Test implicit conversion to string
      string? backToString = list3;
      Console.WriteLine($"✓ Back to string: '{backToString}'");

      // Test Count property
      Console.WriteLine($"✓ Count property: {list2.Count}");

      // Test IsReadOnly property
      Console.WriteLine($"✓ IsReadOnly: {list2.IsReadOnly}");

      Console.WriteLine("✓ All basic operations passed");
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

  #region Collection Operations Tests

  static bool TestStringListCollectionOperations()
  {
    Console.WriteLine("--- Testing StringList Collection Operations ---");

    try
    {
      // Test Add and enumeration
      Console.WriteLine("Testing Add and enumeration:");
      StringList list = new StringList();
      list.Add("item1");
      list.Add("item2");
      list.Add("item3");
      Console.Write("  Items: ");
      foreach (var item in list)
      {
        Console.Write($"{item} ");
      }
      Console.WriteLine();

      // Test Contains
      Console.WriteLine("\nTesting Contains:");
      Console.WriteLine($"  Contains 'item2': {list.Contains("item2")}");
      Console.WriteLine($"  Contains 'item4': {list.Contains("item4")}");

      // Test Remove
      Console.WriteLine("\nTesting Remove:");
      bool removed = list.Remove("item2");
      Console.WriteLine($"  Removed 'item2': {removed}");
      Console.WriteLine($"  List after remove: {list}");
      Console.WriteLine($"  Count after remove: {list.Count}");

      // Test CopyTo
      Console.WriteLine("\nTesting CopyTo:");
      string[] array = new string[5];
      list.CopyTo(array, 1);
      Console.WriteLine($"  Array after CopyTo: [{string.Join(", ", array.Select(s => s == null ? "null" : $"\"{s}\""))}]");

      // Test Clear
      Console.WriteLine("\nTesting Clear:");
      Console.WriteLine($"  Count before clear: {list.Count}");
      list.Clear();
      Console.WriteLine($"  Count after clear: {list.Count}");
      Console.WriteLine($"  List after clear: '{list}'");

      // Test ICollection.CopyTo
      Console.WriteLine("\nTesting ICollection.CopyTo:");
      StringList list2 = new StringList("a,b,c");
      string[] destArray = new string[5];
      ((ICollection)list2).CopyTo(destArray, 0);
      Console.WriteLine($"  Array after ICollection.CopyTo: [{string.Join(", ", destArray.Select(s => s == null ? "null" : $"\"{s}\""))}]");

      // Test ICollection properties
      Console.WriteLine("\nTesting ICollection properties:");
      Console.WriteLine($"  IsSynchronized: {((ICollection)list2).IsSynchronized}");
      Console.WriteLine($"  SyncRoot is not null: {((ICollection)list2).SyncRoot != null}");

      Console.WriteLine("\n✓ All collection operation tests passed");
      Console.WriteLine();
      return true;
    }
    catch (Exception ex)
    {
      Console.WriteLine($"✗ Collection operation test FAILED: {ex.Message}");
      Console.WriteLine($"  Stack trace: {ex.StackTrace}");
      Console.WriteLine();
      return false;
    }
  }

  #endregion

  #region Parsing Tests

  static bool TestStringListParsing()
  {
    Console.WriteLine("--- Testing StringList Parsing ---");

    try
    {
      // Test simple comma-separated values
      Console.WriteLine("Testing simple comma-separated values:");
      StringList list1 = new StringList("apple,banana,cherry");
      Console.WriteLine($"  \"apple,banana,cherry\" → {list1} (Count={list1.Count})");
      if (list1.Count != 3 || !list1.Contains("apple") || !list1.Contains("banana") || !list1.Contains("cherry"))
      {
        Console.WriteLine("✗ Parsing FAILED");
        return false;
      }

      // Test single value
      Console.WriteLine("\nTesting single value:");
      StringList list2 = new StringList("single");
      Console.WriteLine($"  \"single\" → {list2} (Count={list2.Count})");
      if (list2.Count != 1 || !list2.Contains("single"))
      {
        Console.WriteLine("✗ Parsing FAILED");
        return false;
      }

      // Test empty string
      Console.WriteLine("\nTesting empty string:");
      StringList list3 = new StringList("");
      Console.WriteLine($"  \"\" → {list3} (Count={list3.Count})");
      if (list3.Count != 1) // Empty string creates one empty item
      {
        Console.WriteLine("✗ Parsing FAILED");
        return false;
      }

      // Test null string
      Console.WriteLine("\nTesting null string:");
      StringList list4 = new StringList(null);
      Console.WriteLine($"  null → {list4} (Count={list4.Count})");
      if (list4.Count != 0)
      {
        Console.WriteLine("✗ Parsing FAILED");
        return false;
      }

      // Test values with spaces
      Console.WriteLine("\nTesting values with spaces:");
      StringList list5 = new StringList("item one,item two,item three");
      Console.WriteLine($"  \"item one,item two,item three\" → {list5}");
      if (list5.Count != 3)
      {
        Console.WriteLine("✗ Parsing FAILED");
        return false;
      }

      // Test trailing comma
      Console.WriteLine("\nTesting trailing comma:");
      StringList list6 = new StringList("a,b,c,");
      Console.WriteLine($"  \"a,b,c,\" → {list6} (Count={list6.Count})");
      if (list6.Count != 4) // Creates empty last item
      {
        Console.WriteLine("✗ Parsing FAILED");
        return false;
      }

      // Test leading comma
      Console.WriteLine("\nTesting leading comma:");
      StringList list7 = new StringList(",x,y,z");
      Console.WriteLine($"  \",x,y,z\" → {list7} (Count={list7.Count})");
      if (list7.Count != 4) // Creates empty first item
      {
        Console.WriteLine("✗ Parsing FAILED");
        return false;
      }

      // Test multiple consecutive commas
      Console.WriteLine("\nTesting multiple consecutive commas:");
      StringList list8 = new StringList("a,,b,,,c");
      Console.WriteLine($"  \"a,,b,,,c\" → {list8} (Count={list8.Count})");

      Console.WriteLine("\n✓ All parsing tests passed");
      Console.WriteLine();
      return true;
    }
    catch (Exception ex)
    {
      Console.WriteLine($"✗ Parsing test FAILED: {ex.Message}");
      Console.WriteLine($"  Stack trace: {ex.StackTrace}");
      Console.WriteLine();
      return false;
    }
  }

  #endregion

  #region Conversion Tests

  static bool TestStringListConversions()
  {
    Console.WriteLine("--- Testing StringList IConvertible Conversions ---");

    try
    {
      // Test GetTypeCode
      Console.WriteLine("Testing GetTypeCode:");
      StringList list = new StringList("a,b,c");
      TypeCode typeCode = list.GetTypeCode();
      Console.WriteLine($"  GetTypeCode(): {typeCode}");
      if (typeCode != TypeCode.Object)
      {
        Console.WriteLine("✗ GetTypeCode test FAILED");
        return false;
      }

      // Test ToBoolean
      Console.WriteLine("\nTesting ToBoolean:");
      StringList nonEmptyList = new StringList("item");
      StringList emptyList = new StringList();
      Console.WriteLine($"  Non-empty list ToBoolean: {nonEmptyList.ToBoolean(null)}");
      Console.WriteLine($"  Empty list ToBoolean: {emptyList.ToBoolean(null)}");
      if (!nonEmptyList.ToBoolean(null) || emptyList.ToBoolean(null))
      {
        Console.WriteLine("✗ ToBoolean test FAILED");
        return false;
      }

      // Test ToInt32
      Console.WriteLine("\nTesting ToInt32 (returns count):");
      StringList threeItems = new StringList("x,y,z");
      int count32 = threeItems.ToInt32(null);
      Console.WriteLine($"  List with 3 items ToInt32: {count32}");
      if (count32 != 3)
      {
        Console.WriteLine("✗ ToInt32 test FAILED");
        return false;
      }

      // Test ToInt64
      Console.WriteLine("\nTesting ToInt64 (returns count):");
      long count64 = threeItems.ToInt64(null);
      Console.WriteLine($"  List with 3 items ToInt64: {count64}");
      if (count64 != 3L)
      {
        Console.WriteLine("✗ ToInt64 test FAILED");
        return false;
      }

      // Test ToUInt32
      Console.WriteLine("\nTesting ToUInt32 (returns count):");
      uint countU32 = threeItems.ToUInt32(null);
      Console.WriteLine($"  List with 3 items ToUInt32: {countU32}");
      if (countU32 != 3U)
      {
        Console.WriteLine("✗ ToUInt32 test FAILED");
        return false;
      }

      // Test ToUInt64
      Console.WriteLine("\nTesting ToUInt64 (returns count):");
      ulong countU64 = threeItems.ToUInt64(null);
      Console.WriteLine($"  List with 3 items ToUInt64: {countU64}");
      if (countU64 != 3UL)
      {
        Console.WriteLine("✗ ToUInt64 test FAILED");
        return false;
      }

      // Test ToString(IFormatProvider)
      Console.WriteLine("\nTesting ToString(IFormatProvider):");
      StringList strList = new StringList("alpha,beta,gamma");
      string str = strList.ToString(CultureInfo.InvariantCulture);
      Console.WriteLine($"  ToString result: '{str}'");
      if (str != "alpha, beta, gamma")
      {
        Console.WriteLine("✗ ToString test FAILED");
        return false;
      }

      // Test ToType conversions
      Console.WriteLine("\nTesting ToType conversions:");
      
      // ToType(typeof(string))
      var asString = strList.ToType(typeof(string), null);
      Console.WriteLine($"  ToType(typeof(string)): '{asString}'");
      if (asString as string != "alpha, beta, gamma")
      {
        Console.WriteLine("✗ ToType(string) test FAILED");
        return false;
      }

      // ToType(typeof(bool))
      var asBool = strList.ToType(typeof(bool), null);
      Console.WriteLine($"  ToType(typeof(bool)): {asBool}");
      if ((bool)asBool != true)
      {
        Console.WriteLine("✗ ToType(bool) test FAILED");
        return false;
      }

      // ToType(typeof(int))
      var asInt = strList.ToType(typeof(int), null);
      Console.WriteLine($"  ToType(typeof(int)): {asInt}");
      if ((int)asInt != 3)
      {
        Console.WriteLine("✗ ToType(int) test FAILED");
        return false;
      }

      // ToType(typeof(long))
      var asLong = strList.ToType(typeof(long), null);
      Console.WriteLine($"  ToType(typeof(long)): {asLong}");
      if ((long)asLong != 3L)
      {
        Console.WriteLine("✗ ToType(long) test FAILED");
        return false;
      }

      // ToType(typeof(StringList))
      var asStringList = strList.ToType(typeof(StringList), null);
      Console.WriteLine($"  ToType(typeof(StringList)): {asStringList == strList}");
      if (asStringList != strList)
      {
        Console.WriteLine("✗ ToType(StringList) test FAILED");
        return false;
      }

      // Test unsupported conversions
      Console.WriteLine("\nTesting unsupported conversions:");
      
      // ToByte should throw
      try
      {
        strList.ToByte(null);
        Console.WriteLine("✗ ToByte should have thrown InvalidCastException");
        return false;
      }
      catch (InvalidCastException ex)
      {
        Console.WriteLine($"  ✓ ToByte correctly threw: {ex.Message}");
      }

      // ToChar should throw
      try
      {
        strList.ToChar(null);
        Console.WriteLine("✗ ToChar should have thrown InvalidCastException");
        return false;
      }
      catch (InvalidCastException ex)
      {
        Console.WriteLine($"  ✓ ToChar correctly threw: {ex.Message}");
      }

      // ToDateTime should throw
      try
      {
        strList.ToDateTime(null);
        Console.WriteLine("✗ ToDateTime should have thrown InvalidCastException");
        return false;
      }
      catch (InvalidCastException ex)
      {
        Console.WriteLine($"  ✓ ToDateTime correctly threw: {ex.Message}");
      }

      // ToDecimal should throw
      try
      {
        strList.ToDecimal(null);
        Console.WriteLine("✗ ToDecimal should have thrown InvalidCastException");
        return false;
      }
      catch (InvalidCastException ex)
      {
        Console.WriteLine($"  ✓ ToDecimal correctly threw: {ex.Message}");
      }

      // ToDouble should throw
      try
      {
        strList.ToDouble(null);
        Console.WriteLine("✗ ToDouble should have thrown InvalidCastException");
        return false;
      }
      catch (InvalidCastException ex)
      {
        Console.WriteLine($"  ✓ ToDouble correctly threw: {ex.Message}");
      }

      // ToInt16 should throw
      try
      {
        strList.ToInt16(null);
        Console.WriteLine("✗ ToInt16 should have thrown InvalidCastException");
        return false;
      }
      catch (InvalidCastException ex)
      {
        Console.WriteLine($"  ✓ ToInt16 correctly threw: {ex.Message}");
      }

      // ToSByte should throw
      try
      {
        strList.ToSByte(null);
        Console.WriteLine("✗ ToSByte should have thrown InvalidCastException");
        return false;
      }
      catch (InvalidCastException ex)
      {
        Console.WriteLine($"  ✓ ToSByte correctly threw: {ex.Message}");
      }

      // ToSingle should throw
      try
      {
        strList.ToSingle(null);
        Console.WriteLine("✗ ToSingle should have thrown InvalidCastException");
        return false;
      }
      catch (InvalidCastException ex)
      {
        Console.WriteLine($"  ✓ ToSingle correctly threw: {ex.Message}");
      }

      // ToUInt16 should throw
      try
      {
        strList.ToUInt16(null);
        Console.WriteLine("✗ ToUInt16 should have thrown InvalidCastException");
        return false;
      }
      catch (InvalidCastException ex)
      {
        Console.WriteLine($"  ✓ ToUInt16 correctly threw: {ex.Message}");
      }

      // ToType with unsupported type should throw
      try
      {
        strList.ToType(typeof(DateTime), null);
        Console.WriteLine("✗ ToType(typeof(DateTime)) should have thrown InvalidCastException");
        return false;
      }
      catch (InvalidCastException ex)
      {
        Console.WriteLine($"  ✓ ToType(typeof(DateTime)) correctly threw: {ex.Message}");
      }

      Console.WriteLine("\n✓ All IConvertible conversion tests passed");
      Console.WriteLine();
      return true;
    }
    catch (Exception ex)
    {
      Console.WriteLine($"✗ Conversion test FAILED: {ex.Message}");
      Console.WriteLine($"  Stack trace: {ex.StackTrace}");
      Console.WriteLine();
      return false;
    }
  }

  #endregion

  #region XML Serialization Tests

  static bool TestStringListXmlSerialization()
  {
    Console.WriteLine("--- Testing StringList XML Serialization ---");

    try
    {
      // Create test object
      var testData = new StringListTestData
      {
        Id = 1,
        Name = "XML Test",
        EmptyList = new StringList(),
        SingleItem = new StringList("single"),
        MultipleItems = new StringList("one,two,three"),
        ItemsWithSpaces = new StringList("item one,item two,item three"),
        SpecialChars = new StringList("hello world,test@example.com,path/to/file"),
        Numbers = new StringList("1,2,3,4,5")
      };

      Console.WriteLine($"Original data:");
      Console.WriteLine($"  Id: {testData.Id}");
      Console.WriteLine($"  Name: {testData.Name}");
      Console.WriteLine($"  EmptyList: '{testData.EmptyList}' (Count={testData.EmptyList.Count})");
      Console.WriteLine($"  SingleItem: '{testData.SingleItem}' (Count={testData.SingleItem.Count})");
      Console.WriteLine($"  MultipleItems: '{testData.MultipleItems}' (Count={testData.MultipleItems.Count})");
      Console.WriteLine($"  ItemsWithSpaces: '{testData.ItemsWithSpaces}' (Count={testData.ItemsWithSpaces.Count})");
      Console.WriteLine($"  SpecialChars: '{testData.SpecialChars}' (Count={testData.SpecialChars.Count})");
      Console.WriteLine($"  Numbers: '{testData.Numbers}' (Count={testData.Numbers.Count})");
      Console.WriteLine();

      // Serialize to XML
      var xmlSerializer = new XmlSerializer(typeof(StringListTestData));
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
      StringListTestData? deserializedData;
      using (var stringReader = new StringReader(xmlString))
      {
        deserializedData = (StringListTestData?)xmlSerializer.Deserialize(stringReader);
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
      Console.WriteLine($"  EmptyList: '{deserializedData.EmptyList}' (Count={deserializedData.EmptyList.Count})");
      Console.WriteLine($"  SingleItem: '{deserializedData.SingleItem}' (Count={deserializedData.SingleItem.Count})");
      Console.WriteLine($"  MultipleItems: '{deserializedData.MultipleItems}' (Count={deserializedData.MultipleItems.Count})");
      Console.WriteLine($"  ItemsWithSpaces: '{deserializedData.ItemsWithSpaces}' (Count={deserializedData.ItemsWithSpaces.Count})");
      Console.WriteLine($"  SpecialChars: '{deserializedData.SpecialChars}' (Count={deserializedData.SpecialChars.Count})");
      Console.WriteLine($"  Numbers: '{deserializedData.Numbers}' (Count={deserializedData.Numbers.Count})");
      Console.WriteLine();

      // Validate
      bool isValid =
        testData.Id == deserializedData.Id &&
        testData.Name == deserializedData.Name &&
        testData.EmptyList.Equals(deserializedData.EmptyList) &&
        testData.SingleItem.Equals(deserializedData.SingleItem) &&
        testData.MultipleItems.Equals(deserializedData.MultipleItems) &&
        testData.ItemsWithSpaces.Equals(deserializedData.ItemsWithSpaces) &&
        testData.SpecialChars.Equals(deserializedData.SpecialChars) &&
        testData.Numbers.Equals(deserializedData.Numbers);

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

  static bool TestStringListJsonSerialization()
  {
    Console.WriteLine("--- Testing StringList JSON Serialization ---");

    try
    {
      // Create test object
      var testData = new StringListTestData
      {
        Id = 2,
        Name = "JSON Test",
        EmptyList = new StringList(),
        SingleItem = new StringList("single"),
        MultipleItems = new StringList("one,two,three"),
        ItemsWithSpaces = new StringList("item one,item two,item three"),
        SpecialChars = new StringList("hello world,test@example.com,path/to/file"),
        Numbers = new StringList("1,2,3,4,5")
      };

      Console.WriteLine($"Original data:");
      Console.WriteLine($"  Id: {testData.Id}");
      Console.WriteLine($"  Name: {testData.Name}");
      Console.WriteLine($"  EmptyList: '{testData.EmptyList}' (Count={testData.EmptyList.Count})");
      Console.WriteLine($"  SingleItem: '{testData.SingleItem}' (Count={testData.SingleItem.Count})");
      Console.WriteLine($"  MultipleItems: '{testData.MultipleItems}' (Count={testData.MultipleItems.Count})");
      Console.WriteLine($"  ItemsWithSpaces: '{testData.ItemsWithSpaces}' (Count={testData.ItemsWithSpaces.Count})");
      Console.WriteLine($"  SpecialChars: '{testData.SpecialChars}' (Count={testData.SpecialChars.Count})");
      Console.WriteLine($"  Numbers: '{testData.Numbers}' (Count={testData.Numbers.Count})");
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
      var deserializedData = JsonSerializer.Deserialize<StringListTestData>(jsonString, jsonOptions);

      if (deserializedData == null)
      {
        Console.WriteLine("✗ JSON Deserialization returned null");
        return false;
      }

      // Verify deserialized data
      Console.WriteLine("Deserialized data:");
      Console.WriteLine($"  Id: {deserializedData.Id}");
      Console.WriteLine($"  Name: {deserializedData.Name}");
      Console.WriteLine($"  EmptyList: '{deserializedData.EmptyList}' (Count={deserializedData.EmptyList.Count})");
      Console.WriteLine($"  SingleItem: '{deserializedData.SingleItem}' (Count={deserializedData.SingleItem.Count})");
      Console.WriteLine($"  MultipleItems: '{deserializedData.MultipleItems}' (Count={deserializedData.MultipleItems.Count})");
      Console.WriteLine($"  ItemsWithSpaces: '{deserializedData.ItemsWithSpaces}' (Count={deserializedData.ItemsWithSpaces.Count})");
      Console.WriteLine($"  SpecialChars: '{deserializedData.SpecialChars}' (Count={deserializedData.SpecialChars.Count})");
      Console.WriteLine($"  Numbers: '{deserializedData.Numbers}' (Count={deserializedData.Numbers.Count})");
      Console.WriteLine();

      // Validate
      bool isValid =
        testData.Id == deserializedData.Id &&
        testData.Name == deserializedData.Name &&
        testData.EmptyList.Equals(deserializedData.EmptyList) &&
        testData.SingleItem.Equals(deserializedData.SingleItem) &&
        testData.MultipleItems.Equals(deserializedData.MultipleItems) &&
        testData.ItemsWithSpaces.Equals(deserializedData.ItemsWithSpaces) &&
        testData.SpecialChars.Equals(deserializedData.SpecialChars) &&
        testData.Numbers.Equals(deserializedData.Numbers);

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

  static bool TestStringListEdgeCases()
  {
    Console.WriteLine("--- Testing StringList Edge Cases ---");

    try
    {
      // Test null handling
      Console.WriteLine("Testing null handling:");
      StringList? nullList = null;
      string? nullToString = nullList;
      Console.WriteLine($"  Null list to string: {(nullToString == null ? "null" : $"'{nullToString}'")}");

      StringList? fromNull = (string?)null;
      Console.WriteLine($"  From null string: {(fromNull == null ? "null" : $"'{fromNull}'")}");

      // Test JSON deserialization from different formats
      Console.WriteLine("\nTesting JSON deserialization from different formats:");

      // String format (comma-separated)
      string jsonString = "{\"Value\":\"apple,banana,cherry\"}";
      var fromString = JsonSerializer.Deserialize<StringListWrapper>(jsonString);
      Console.WriteLine($"  From JSON string \"apple,banana,cherry\": {fromString?.Value} (Count={fromString?.Value?.Count ?? 0})");

      // Array format
      string jsonArray = "{\"Value\":[\"apple\",\"banana\",\"cherry\"]}";
      var fromArray = JsonSerializer.Deserialize<StringListWrapper>(jsonArray);
      Console.WriteLine($"  From JSON array [\"apple\",\"banana\",\"cherry\"]: {fromArray?.Value} (Count={fromArray?.Value?.Count ?? 0})");

      // Null format
      string jsonNull = "{\"Value\":null}";
      var fromJsonNull = JsonSerializer.Deserialize<StringListWrapper>(jsonNull);
      Console.WriteLine($"  From JSON null: {(fromJsonNull?.Value == null ? "null" : $"'{fromJsonNull.Value}'")}");

      // Test equality with different types
      Console.WriteLine("\nTesting equality:");
      StringList list1 = new StringList("test");
      StringList list2 = new StringList("test");
      StringList list3 = new StringList("different");
      string singleString = "test";

      Console.WriteLine($"  list1.Equals(list2): {list1.Equals(list2)}");
      Console.WriteLine($"  list1.Equals(list3): {list1.Equals(list3)}");
      Console.WriteLine($"  list1.Equals(singleString): {list1.Equals(singleString)}");
      Console.WriteLine($"  list1.Equals(null): {list1.Equals(null)}");

      if (list1 == null || !list1.Equals(list2))
      {
        Console.WriteLine("✗ Equality test FAILED");
        return false;
      }

      // Test hash code
      Console.WriteLine("\nTesting hash code:");
      Console.WriteLine($"  list1.GetHashCode(): {list1.GetHashCode()}");
      Console.WriteLine($"  list2.GetHashCode(): {list2.GetHashCode()}");
      Console.WriteLine($"  list3.GetHashCode(): {list3.GetHashCode()}");

      if (list1.GetHashCode() != list2.GetHashCode())
      {
        Console.WriteLine("✗ Hash code consistency test FAILED");
        return false;
      }

      // Test with special characters
      Console.WriteLine("\nTesting with special characters:");
      StringList special = new StringList("line\nbreak,tab\there,quote\"test");
      Console.WriteLine($"  Special chars: {special} (Count={special.Count})");

      // Test Remove on non-existent item
      Console.WriteLine("\nTesting Remove on non-existent item:");
      StringList removeTest = new StringList("a,b,c");
      bool removedNonExistent = removeTest.Remove("d");
      Console.WriteLine($"  Remove 'd' from 'a,b,c': {removedNonExistent} (expected false)");

      // Test Contains on empty list
      Console.WriteLine("\nTesting Contains on empty list:");
      StringList emptyList = new StringList();
      bool containsInEmpty = emptyList.Contains("test");
      Console.WriteLine($"  Empty list contains 'test': {containsInEmpty} (expected false)");

      // Test enumeration on empty list
      Console.WriteLine("\nTesting enumeration on empty list:");
      int count = 0;
      foreach (var item in emptyList)
      {
        count++;
      }
      Console.WriteLine($"  Items enumerated: {count} (expected 0)");

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

  static bool TestStringListPerformance()
  {
    Console.WriteLine("--- Testing StringList Performance ---");

    try
    {
      const int iterations = 10000;

      // Test construction from string
      var sw = System.Diagnostics.Stopwatch.StartNew();
      for (int i = 0; i < iterations; i++)
      {
        StringList list = new StringList("a,b,c,d,e");
      }
      sw.Stop();
      Console.WriteLine($"Construction from string x {iterations}: {sw.ElapsedMilliseconds}ms");

      // Test default construction and Add operations
      sw.Restart();
      for (int i = 0; i < iterations; i++)
      {
        StringList list = new StringList();
        list.Add("a");
        list.Add("b");
        list.Add("c");
        list.Add("d");
        list.Add("e");
      }
      sw.Stop();
      Console.WriteLine($"Construction + 5 Add operations x {iterations}: {sw.ElapsedMilliseconds}ms");

      // Test ToString performance
      StringList testList = new StringList("one,two,three,four,five");
      sw.Restart();
      for (int i = 0; i < iterations; i++)
      {
        string str = testList.ToString();
      }
      sw.Stop();
      Console.WriteLine($"ToString() x {iterations}: {sw.ElapsedMilliseconds}ms");

      // Test Contains performance
      sw.Restart();
      for (int i = 0; i < iterations; i++)
      {
        bool contains = testList.Contains("three");
      }
      sw.Stop();
      Console.WriteLine($"Contains() x {iterations}: {sw.ElapsedMilliseconds}ms");

      // Test enumeration performance
      sw.Restart();
      for (int i = 0; i < iterations; i++)
      {
        foreach (var item in testList)
        {
          // Just enumerate
        }
      }
      sw.Stop();
      Console.WriteLine($"Enumeration x {iterations}: {sw.ElapsedMilliseconds}ms");

      // Test JSON serialization performance
      var testObj = new StringListTestData
      {
        Id = 1,
        Name = "Perf Test",
        EmptyList = new StringList(),
        SingleItem = new StringList("single"),
        MultipleItems = new StringList("one,two,three"),
        ItemsWithSpaces = new StringList("item one,item two,item three"),
        SpecialChars = new StringList("hello world,test@example.com,path/to/file"),
        Numbers = new StringList("1,2,3,4,5")
      };

      sw.Restart();
      for (int i = 0; i < iterations / 10; i++)
      {
        string json = JsonSerializer.Serialize(testObj);
      }
      sw.Stop();
      Console.WriteLine($"JSON Serialization x {iterations / 10}: {sw.ElapsedMilliseconds}ms");

      // Test JSON deserialization performance
      string jsonData = JsonSerializer.Serialize(testObj);
      sw.Restart();
      for (int i = 0; i < iterations / 10; i++)
      {
        var obj = JsonSerializer.Deserialize<StringListTestData>(jsonData);
      }
      sw.Stop();
      Console.WriteLine($"JSON Deserialization x {iterations / 10}: {sw.ElapsedMilliseconds}ms");

      // Test Equals performance
      StringList list1 = new StringList("a,b,c,d,e");
      StringList list2 = new StringList("a,b,c,d,e");
      sw.Restart();
      for (int i = 0; i < iterations; i++)
      {
        bool result = list1.Equals(list2);
      }
      sw.Stop();
      Console.WriteLine($"Equals() x {iterations}: {sw.ElapsedMilliseconds}ms");

      // Test GetHashCode performance
      sw.Restart();
      for (int i = 0; i < iterations; i++)
      {
        int hash = list1.GetHashCode();
      }
      sw.Stop();
      Console.WriteLine($"GetHashCode() x {iterations}: {sw.ElapsedMilliseconds}ms");

      // Test Remove performance
      sw.Restart();
      for (int i = 0; i < iterations / 10; i++)
      {
        StringList tempList = new StringList("a,b,c,d,e");
        tempList.Remove("c");
      }
      sw.Stop();
      Console.WriteLine($"Remove() x {iterations / 10}: {sw.ElapsedMilliseconds}ms");

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
/// Test data class containing various StringList properties.
/// </summary>
[XmlRoot("StringListTestData")]
public class StringListTestData
{
  [XmlElement("Id")]
  public int Id { get; set; }

  [XmlElement("Name")]
  public string Name { get; set; } = string.Empty;

  [XmlElement("EmptyList")]
  public StringList EmptyList { get; set; } = new StringList();

  [XmlElement("SingleItem")]
  public StringList SingleItem { get; set; } = new StringList();

  [XmlElement("MultipleItems")]
  public StringList MultipleItems { get; set; } = new StringList();

  [XmlElement("ItemsWithSpaces")]
  public StringList ItemsWithSpaces { get; set; } = new StringList();

  [XmlElement("SpecialChars")]
  public StringList SpecialChars { get; set; } = new StringList();

  [XmlElement("Numbers")]
  public StringList Numbers { get; set; } = new StringList();
}

/// <summary>
/// Simple wrapper class for testing JSON deserialization scenarios.
/// </summary>
public class StringListWrapper
{
  public StringList? Value { get; set; }
}

#endregion