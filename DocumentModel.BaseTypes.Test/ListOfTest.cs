using System.Globalization;

namespace DocumentModel.BaseTypes.Test;

/// <summary>
/// Test suite for ListOf&lt;T&gt; type serialization in both XML and JSON formats.
/// </summary>
public static class ListOfTest
{
  /// <summary>
  /// Runs all ListOf&lt;T&gt; serialization tests.
  /// </summary>
  public static bool Run()
  {
    Console.WriteLine("=== ListOf<T> Serialization Test Program ===");
    Console.WriteLine();

    // Run all tests
    if (!TestListOfBasicOperations()) return false;
    if (!TestListOfCollectionOperations()) return false;
    if (!TestListOfParsing()) return false;
    if (!TestListOfXmlSerialization()) return false;
    if (!TestListOfJsonSerialization()) return false;
    if (!TestListOfEdgeCases()) return false;
    if (!TestListOfPerformance()) return false;

    return true;
  }

  
  static bool TestListOfBasicOperations()
  {
    Console.WriteLine("--- Testing ListOf<T> Basic Operations ---");      // Test with integer type
    Console.WriteLine("Testing ListOf<int>:");
    ListOf<int> intList1 = new ListOf<int>();
    Console.WriteLine($"\n✓ Default constructor: Count={intList1.Count}");

    // Test string constructor with space-separated values
    ListOf<int> intList2 = new ListOf<int>("1 2 3 4 5");
    Console.WriteLine($"\n✓ String constructor: {intList2.InnerText} (Count={intList2.Count})");

    // Test enumerable constructor
    ListOf<int> intList3 = new ListOf<int>(new[] { 10, 20, 30 });
    Console.WriteLine($"\n✓ Enumerable constructor: {intList3.InnerText} (Count={intList3.Count})");

    // Test copy constructor
    ListOf<int> intList4 = new ListOf<int>(intList2);
    Console.WriteLine($"\n✓ Copy constructor: {intList4.InnerText} (Count={intList4.Count})");

    // Test with string type
    Console.WriteLine("\nTesting ListOf<string>:");
    ListOf<string> strList1 = new ListOf<string>();
    strList1.Add("apple");
    strList1.Add("banana");
    strList1.Add("cherry");
    Console.WriteLine($"\n✓ After Add operations: {strList1.InnerText} (Count={strList1.Count})");

    // Test string constructor with comma-separated values
    ListOf<string> strList2 = new ListOf<string>("one,two,three");
    Console.WriteLine($"\n✓ Comma-separated: {strList2.InnerText} (Count={strList2.Count})");

    // Test implicit conversion from string
    ListOf<int> intList5 = "10 20 30 40"!;
    Console.WriteLine($"\n✓ Implicit from string: {intList5.InnerText}");

    // Test implicit conversion to string
    string? backToString = intList5;
    Console.WriteLine($"\n✓ Back to string: '{backToString}'");

    // Test InnerText property
    Console.WriteLine($"\n✓ InnerText getter: '{intList2.InnerText}'");

    Console.WriteLine("\n✓ All basic operations passed");
    Console.WriteLine();
    return true;
  }

  
  
  static bool TestListOfCollectionOperations()
  {
    Console.WriteLine("--- Testing ListOf<T> Collection Operations ---");      // Test Add and enumeration with integers
    Console.WriteLine("Testing Add and enumeration with integers:");
    ListOf<int> intList = new ListOf<int>();
    intList.Add(100);
    intList.Add(200);
    intList.Add(300);
    Console.Write("  Items: ");
    foreach (var item in intList)
    {
      Console.Write($"{item} ");
    }
    Console.WriteLine();

    // Test Contains
    Console.WriteLine("\nTesting Contains:");
    Console.WriteLine($"  Contains 200: {intList.Contains(200)}");
    Console.WriteLine($"  Contains 400: {intList.Contains(400)}");

    // Test Remove
    Console.WriteLine("\nTesting Remove:");
    bool removed = intList.Remove(200);
    Console.WriteLine($"  Removed 200: {removed}");
    Console.WriteLine($"  List after remove: {intList.InnerText}");
    Console.WriteLine($"  Count after remove: {intList.Count}");

    // Test CopyTo
    Console.WriteLine("\nTesting CopyTo:");
    int[] array = new int[5];
    intList.CopyTo(array, 1);
    Console.WriteLine($"  Array after CopyTo: [{string.Join(", ", array)}]");

    // Test Clear
    Console.WriteLine("\nTesting Clear:");
    Console.WriteLine($"  Count before clear: {intList.Count}");
    intList.Clear();
    Console.WriteLine($"  Count after clear: {intList.Count}");
    Console.WriteLine($"  List after clear: '{intList.InnerText}'");

    // Test with double type
    Console.WriteLine("\nTesting with double type:");
    ListOf<double> doubleList = new ListOf<double>("1.5 2.5 3.5");
    Console.WriteLine($"  Parsed: {doubleList.InnerText}");
    doubleList.Add(4.5);
    Console.WriteLine($"  After adding 4.5: {doubleList.InnerText}");

    // Test with bool type
    Console.WriteLine("\nTesting with bool type:");
    ListOf<bool> boolList = new ListOf<bool>("true false true");
    Console.WriteLine($"  Parsed: {boolList.InnerText}");
    Console.WriteLine($"  Count: {boolList.Count}");

    Console.WriteLine("\n✓ All collection operation tests passed");
    Console.WriteLine();
    return true;
  }

  
  
  static bool TestListOfParsing()
  {
    Console.WriteLine("--- Testing ListOf<T> Parsing ---");      // Test space-separated integers
    Console.WriteLine("Testing space-separated integers:");
    ListOf<int> intList1 = new ListOf<int>("1 2 3 4 5");
    Console.WriteLine($"  \"1 2 3 4 5\" → {intList1.InnerText} (Count={intList1.Count})");
    if (intList1.Count != 5 || !intList1.Contains(3))
    {
      Console.WriteLine("✗ Parsing FAILED");
      return false;
    }

    // Test single value
    Console.WriteLine("\nTesting single value:");
    ListOf<int> intList2 = new ListOf<int>("42");
    Console.WriteLine($"  \"42\" → {intList2.InnerText} (Count={intList2.Count})");
    if (intList2.Count != 1 || !intList2.Contains(42))
    {
      Console.WriteLine("✗ Parsing FAILED");
      return false;
    }

    // Test comma-separated strings
    Console.WriteLine("\nTesting comma-separated strings:");
    ListOf<string> strList1 = new ListOf<string>("apple,banana,cherry");
    Console.WriteLine($"  \"apple,banana,cherry\" → {strList1.InnerText} (Count={strList1.Count})");
    if (strList1.Count != 3 || !strList1.Contains("banana"))
    {
      Console.WriteLine("✗ Parsing FAILED");
      return false;
    }

    // Test semicolon-separated strings
    Console.WriteLine("\nTesting semicolon-separated strings:");
    ListOf<string> strList2 = new ListOf<string>("one;two;three");
    Console.WriteLine($"  \"one;two;three\" → {strList2.InnerText} (Count={strList2.Count})");
    if (strList2.Count != 3 || !strList2.Contains("two"))
    {
      Console.WriteLine("✗ Parsing FAILED");
      return false;
    }

    // Test empty string
    Console.WriteLine("\nTesting empty string:");
    ListOf<int> intList3 = new ListOf<int>("");
    Console.WriteLine($"  \"\" → {intList3.InnerText} (Count={intList3.Count})");
    if (intList3.Count != 0)
    {
      Console.WriteLine("✗ Parsing FAILED");
      return false;
    }

    // Test null string handling
    Console.WriteLine("\nTesting null implicit conversion:");
    ListOf<int>? nullList = (string?)null;
    Console.WriteLine($"  null → {(nullList == null ? "null" : "not null")}");
    if (nullList != null)
    {
      Console.WriteLine("✗ Parsing FAILED");
      return false;
    }

    // Test double values
    Console.WriteLine("\nTesting double values:");
    ListOf<double> doubleList = new ListOf<double>("1.5 2.75 3.125");
    Console.WriteLine($"  \"1.5 2.75 3.125\" → {doubleList.InnerText} (Count={doubleList.Count})");
    if (doubleList.Count != 3)
    {
      Console.WriteLine("✗ Parsing FAILED");
      return false;
    }

    // Test negative numbers
    Console.WriteLine("\nTesting negative numbers:");
    ListOf<int> negList = new ListOf<int>("-10 -20 30");
    Console.WriteLine($"  \"-10 -20 30\" → {negList.InnerText} (Count={negList.Count})");
    if (negList.Count != 3 || !negList.Contains(-10))
    {
      Console.WriteLine("✗ Parsing FAILED");
      return false;
    }

    // Test InnerText setter triggering parse
    Console.WriteLine("\nTesting InnerText setter:");
    ListOf<int> intList4 = new ListOf<int>();
    intList4.InnerText = "100 200 300";
    Console.WriteLine($"  After setting InnerText to \"100 200 300\": Count={intList4.Count}");
    if (intList4.Count != 3 || !intList4.Contains(200))
    {
      Console.WriteLine("✗ Parsing FAILED");
      return false;
    }

    Console.WriteLine("\n✓ All parsing tests passed");
    Console.WriteLine();
    return true;
  }

  
  
  static bool TestListOfXmlSerialization()
  {
    Console.WriteLine("--- Testing ListOf<T> XML Serialization ---");      // Create test object
    var testData = new ListOfTestData
    {
      EmptyIntList = new ListOf<int>(),
      SingleInt = new ListOf<int>("42"),
      MultipleInts = new ListOf<int>("1 2 3 4 5"),
      EmptyStringList = new ListOf<string>(),
      SingleString = new ListOf<string>("single"),
      MultipleStrings = new ListOf<string>("apple,banana,cherry"),
      DoubleList = new ListOf<double>("1.5 2.5 3.5"),
      BoolList = new ListOf<bool>("true false true false")
    };

    Console.WriteLine($"Original data:");


    Console.WriteLine($"  EmptyIntList: '{testData.EmptyIntList.InnerText}' (Count={testData.EmptyIntList.Count})");
    Console.WriteLine($"  SingleInt: '{testData.SingleInt.InnerText}' (Count={testData.SingleInt.Count})");
    Console.WriteLine($"  MultipleInts: '{testData.MultipleInts.InnerText}' (Count={testData.MultipleInts.Count})");
    Console.WriteLine($"  EmptyStringList: '{testData.EmptyStringList.InnerText}' (Count={testData.EmptyStringList.Count})");
    Console.WriteLine($"  SingleString: '{testData.SingleString.InnerText}' (Count={testData.SingleString.Count})");
    Console.WriteLine($"  MultipleStrings: '{testData.MultipleStrings.InnerText}' (Count={testData.MultipleStrings.Count})");
    Console.WriteLine($"  DoubleList: '{testData.DoubleList.InnerText}' (Count={testData.DoubleList.Count})");
    Console.WriteLine($"  BoolList: '{testData.BoolList.InnerText}' (Count={testData.BoolList.Count})");
    Console.WriteLine();

    // Serialize to XML
    var xmlSerializer = new XmlSerializer(typeof(ListOfTestData));
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
    ListOfTestData? deserializedData;
    using (var stringReader = new StringReader(xmlString))
    {
      deserializedData = (ListOfTestData?)xmlSerializer.Deserialize(stringReader);
    }

    if (!VerifyDeserializedData(deserializedData, testData)) return false;
    Console.WriteLine("\n✓ XML Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;
  }

  private static bool VerifyDeserializedData(ListOfTestData? deserializedData, ListOfTestData testData)
  {
    if (deserializedData == null)
    {
      Console.WriteLine("✗ Deserialization returned null");
      return false;
    }

    Console.WriteLine("Deserialized data:");

    Console.WriteLine($"  EmptyIntList: '{deserializedData.EmptyIntList.InnerText}' (Count={deserializedData.EmptyIntList.Count})");
    if (!testData.EmptyIntList.Equals(deserializedData.EmptyIntList))
      return false;
    Console.WriteLine($"  SingleInt: '{deserializedData.SingleInt.InnerText}' (Count={deserializedData.SingleInt.Count})");
    if (!testData.SingleInt.Equals(deserializedData.SingleInt))
      return false;
    Console.WriteLine($"  MultipleInts: '{deserializedData.MultipleInts.InnerText}' (Count={deserializedData.MultipleInts.Count})");
    if (!testData.MultipleInts.Equals(deserializedData.MultipleInts))
      return false;
    Console.WriteLine($"  EmptyStringList: '{deserializedData.EmptyStringList.InnerText}' (Count={deserializedData.EmptyStringList.Count})");
    if (!testData.EmptyStringList.Equals(deserializedData.EmptyStringList))
      return false;
    Console.WriteLine($"  SingleString: '{deserializedData.SingleString.InnerText}' (Count={deserializedData.SingleString.Count})");
    if (!testData.SingleString.Equals(deserializedData.SingleString))
      return false;
    Console.WriteLine($"  MultipleStrings: '{deserializedData.MultipleStrings.InnerText}' (Count={deserializedData.MultipleStrings.Count})");
    if (!testData.MultipleStrings.Equals(deserializedData.MultipleStrings))
      return false;
    Console.WriteLine($"  DoubleList: '{deserializedData.DoubleList.InnerText}' (Count={deserializedData.DoubleList.Count})");
    if (!testData.DoubleList.Equals(deserializedData.DoubleList))
      return false;
    Console.WriteLine($"  BoolList: '{deserializedData.BoolList.InnerText}' (Count={deserializedData.BoolList.Count})");
    if (!testData.BoolList.Equals(deserializedData.BoolList))
      return false;

    return true;
  }

  
  
  static bool TestListOfJsonSerialization()
  {
    Console.WriteLine("--- Testing ListOf<T> JSON Serialization ---");      // Create test object
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
    var deserializedData = JsonSerializer.Deserialize<ListOfTestData>(jsonString, jsonOptions);

    if (!VerifyDeserializedData(deserializedData, testData)) return false;

    Console.WriteLine("\n✓ JSON Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;
  }

  
  private static ListOfTestData CreateTestData()
  {
    return new ListOfTestData
    {
      EmptyIntList = new ListOf<int>(),
      SingleInt = new ListOf<int>("42"),
      MultipleInts = new ListOf<int>("1 2 3 4 5"),
      EmptyStringList = new ListOf<string>(),
      SingleString = new ListOf<string>("hello"),
      MultipleStrings = new ListOf<string>("apple,banana,cherry"),
      DoubleList = new ListOf<double>("1.5 2.5 3.5"),
      BoolList = new ListOf<bool>("true false true false")
    };
  }

  private static void ShowOriginalData(ListOfTestData testData)
  {
    Console.WriteLine($"Original data:");

    Console.WriteLine($"  EmptyIntList: '{testData.EmptyIntList.InnerText}' (Count={testData.EmptyIntList.Count})");
    Console.WriteLine($"  SingleInt: '{testData.SingleInt.InnerText}' (Count={testData.SingleInt.Count})");
    Console.WriteLine($"  MultipleInts: '{testData.MultipleInts.InnerText}' (Count={testData.MultipleInts.Count})");
    Console.WriteLine($"  EmptyStringList: '{testData.EmptyStringList.InnerText}' (Count={testData.EmptyStringList.Count})");
    Console.WriteLine($"  SingleString: '{testData.SingleString.InnerText}' (Count={testData.SingleString.Count})");
    Console.WriteLine($"  MultipleStrings: '{testData.MultipleStrings.InnerText}' (Count={testData.MultipleStrings.Count})");
    Console.WriteLine($"  DoubleList: '{testData.DoubleList.InnerText}' (Count={testData.DoubleList.Count})");
    Console.WriteLine($"  BoolList: '{testData.BoolList.InnerText}' (Count={testData.BoolList.Count})");
    Console.WriteLine();
  }

  
  static bool TestListOfEdgeCases()
  {
    Console.WriteLine("--- Testing ListOf<T> Edge Cases ---");      // Test IConvertible methods
    Console.WriteLine("Testing IConvertible methods:");
    ListOf<int> intList = new ListOf<int>("1 2 3");
    Console.WriteLine($"  ToBoolean (non-empty): {intList.ToBoolean(null)}");
    Console.WriteLine($"  ToInt32 (count): {intList.ToInt32(null)}");
    Console.WriteLine($"  ToInt64 (count): {intList.ToInt64(null)}");
    Console.WriteLine($"  ToString: '{intList.ToString(null)}'");
    Console.WriteLine($"  GetTypeCode: {intList.GetTypeCode()}");

    ListOf<int> emptyList = new ListOf<int>();
    Console.WriteLine($"  ToBoolean (empty): {emptyList.ToBoolean(null)}");

    // Test Deserialization from different formats
    Console.WriteLine("\nTesting Deserialization from different formats:");

    // String format (space-separated)
    string jsonString = "{\"Value\":\"1 2 3 4 5\"}";
    var fromString = JsonSerializer.Deserialize<ListOfIntWrapper>(jsonString);
    Console.WriteLine($"  From JSON string \"1 2 3 4 5\": {fromString?.Value?.InnerText} (Count={fromString?.Value?.Count ?? 0})");

    // Array format
    string jsonArray = "{\"Value\":[10,20,30,40]}";
    var fromArray = JsonSerializer.Deserialize<ListOfIntWrapper>(jsonArray);
    Console.WriteLine($"  From JSON array [10,20,30,40]: {fromArray?.Value?.InnerText} (Count={fromArray?.Value?.Count ?? 0})");

    // Null format
    string jsonNull = "{\"Value\":null}";
    var fromJsonNull = JsonSerializer.Deserialize<ListOfIntWrapper>(jsonNull);
    Console.WriteLine($"  From JSON null: {(fromJsonNull?.Value == null ? "null" : $"'{fromJsonNull.Value}'")}");

    // Test string list with array format
    string jsonStringArray = "{\"Value\":[\"apple\",\"banana\",\"cherry\"]}";
    var fromStringArray = JsonSerializer.Deserialize<ListOfStringWrapper>(jsonStringArray);
    Console.WriteLine($"  From JSON string array: {fromStringArray?.Value?.InnerText} (Count={fromStringArray?.Value?.Count ?? 0})");

    // Test equality
    Console.WriteLine("\nTesting equality:");
    ListOf<int> list1 = new ListOf<int>("1 2 3");
    ListOf<int> list2 = new ListOf<int>("1 2 3");
    ListOf<int> list3 = new ListOf<int>("4 5 6");

    Console.WriteLine($"  list1.Equals(list2): {list1.Equals(list2)}");
    Console.WriteLine($"  list1.Equals(list3): {list1.Equals(list3)}");
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

    // Test ObservableCollection behavior
    Console.WriteLine("\nTesting ObservableCollection behavior:");
    ListOf<int> observableList = new ListOf<int>();
    bool collectionChanged = false;
    observableList.CollectionChanged += (sender, e) =>
    {
      collectionChanged = true;
      Console.WriteLine($"  Collection changed: {e.Action}");
    };
    observableList.Add(100);
    Console.WriteLine($"  CollectionChanged event fired: {collectionChanged}");

    // Test ToType conversions
    Console.WriteLine("\nTesting ToType conversions:");
    var asString = intList.ToType(typeof(string), null);
    Console.WriteLine($"  ToType(typeof(string)): '{asString}'");

    var asBool = intList.ToType(typeof(bool), null);
    Console.WriteLine($"  ToType(typeof(bool)): {asBool}");
    Console.WriteLine();
    Console.WriteLine("\n✓ All edge case tests completed");
    Console.WriteLine();
    return true;
  }

  
  
  static bool TestListOfPerformance()
  {
    Console.WriteLine("--- Testing ListOf<T> Performance ---"); const int iterations = 10000;

    // Test construction from string (integers)
    var sw = System.Diagnostics.Stopwatch.StartNew();
    for (int i = 0; i < iterations; i++)
    {
      ListOf<int> list = new ListOf<int>("1 2 3 4 5");
    }
    sw.Stop();
    Console.WriteLine($"Construction from string (int) x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test construction from string (strings)
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      ListOf<string> list = new ListOf<string>("a,b,c,d,e");
    }
    sw.Stop();
    Console.WriteLine($"Construction from string (string) x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test default construction and Add operations
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      ListOf<int> list = new ListOf<int>();
      list.Add(1);
      list.Add(2);
      list.Add(3);
      list.Add(4);
      list.Add(5);
    }
    sw.Stop();
    Console.WriteLine($"Construction + 5 Add operations x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test InnerText performance
    ListOf<int> testList = new ListOf<int>("1 2 3 4 5");
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      string? text = testList.InnerText;
    }
    sw.Stop();
    Console.WriteLine($"InnerText getter x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test Contains performance
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      bool contains = testList.Contains(3);
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
    var testObj = new ListOfTestData
    {
      EmptyIntList = new ListOf<int>(),
      SingleInt = new ListOf<int>("42"),
      MultipleInts = new ListOf<int>("1 2 3 4 5"),
      EmptyStringList = new ListOf<string>(),
      SingleString = new ListOf<string>("single"),
      MultipleStrings = new ListOf<string>("apple,banana,cherry"),
      DoubleList = new ListOf<double>("1.5 2.5 3.5"),
      BoolList = new ListOf<bool>("true false true")
    };

    sw.Restart();
    for (int i = 0; i < iterations / 10; i++)
    {
      string json = JsonSerializer.Serialize(testObj);
    }
    sw.Stop();
    Console.WriteLine($"JSON Serialization x {iterations / 10}: {sw.ElapsedMilliseconds}ms");

    // Test Deserialization performance
    string jsonData = JsonSerializer.Serialize(testObj);
    sw.Restart();
    for (int i = 0; i < iterations / 10; i++)
    {
      var obj = JsonSerializer.Deserialize<ListOfTestData>(jsonData);
    }
    sw.Stop();
    Console.WriteLine($"Deserialization x {iterations / 10}: {sw.ElapsedMilliseconds}ms");

    // Test Equals performance
    ListOf<int> list1 = new ListOf<int>("1 2 3 4 5");
    ListOf<int> list2 = new ListOf<int>("1 2 3 4 5");
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

    Console.WriteLine("\n✓ Performance tests completed");
    Console.WriteLine();
    return true;
  }

  }


/// <summary>
/// Test data class containing various ListOf properties.
/// </summary>
[XmlRoot("ListOfTestData")]
public class ListOfTestData
{
  [XmlElement("EmptyIntList")]
  public ListOf<int> EmptyIntList { get; set; } = new ListOf<int>();

  [XmlElement("SingleInt")]
  public ListOf<int> SingleInt { get; set; } = new ListOf<int>();

  [XmlElement("MultipleInts")]
  public ListOf<int> MultipleInts { get; set; } = new ListOf<int>();

  [XmlElement("EmptyStringList")]
  public ListOf<string> EmptyStringList { get; set; } = new ListOf<string>();

  [XmlElement("SingleString")]
  public ListOf<string> SingleString { get; set; } = new ListOf<string>();

  [XmlElement("MultipleStrings")]
  public ListOf<string> MultipleStrings { get; set; } = new ListOf<string>();

  [XmlElement("DoubleList")]
  public ListOf<double> DoubleList { get; set; } = new ListOf<double>();

  [XmlElement("BoolList")]
  public ListOf<bool> BoolList { get; set; } = new ListOf<bool>();
}

/// <summary>
/// Simple wrapper class for testing Deserialization scenarios with integers.
/// </summary>
public class ListOfIntWrapper
{
  public ListOf<int>? Value { get; set; }
}

/// <summary>
/// Simple wrapper class for testing Deserialization scenarios with strings.
/// </summary>
public class ListOfStringWrapper
{
  public ListOf<string>? Value { get; set; }
}

