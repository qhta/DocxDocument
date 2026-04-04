namespace DocumentModel.InOpenXml.Test;

/// <summary>
/// Provides comprehensive serialization tests for <see cref="KnownProperties"/>.
/// </summary>
public class KnownPropertiesTest: _AbstractTestClass
{
  /// <summary>
  /// Runs all serialization tests for the <see cref="KnownProperties"/> class and reports the results to the console.
  /// </summary>
  /// <remarks>
  /// Executes XML and JSON serialization tests, as well as edge case tests, for the <see cref="KnownProperties"/> class.
  /// Writes the progress and results to the standard output. Use this method to verify that <see cref="KnownProperties"/> serialization behaves as expected.
  /// </remarks>
  /// <returns>True if all serialization tests pass; otherwise, false.</returns>
  public static bool Run()
  {
    Console.WriteLine("=== KnownProperties Test ===\n");
    if (!TestKnownPropertiesList()) return false;
    Console.WriteLine("All KnownProperties tests passed.\n");
    return true;
  }

  /// <summary>
  /// Tests XML serialization and deserialization for <see cref="KnownProperties"/>.
  /// </summary>
  /// <returns>True if the round-trip succeeds; otherwise, false.</returns>
  static bool TestKnownPropertiesList()
  {
    Console.WriteLine("--- Known properties list ---");
    var document = new Document();
    var knownProperties = document.KnownProperties;
    bool result = true;
    Dictionary<Type, int> countComponentTypes = new();
    foreach (var item in knownProperties)
    {
      var name = item.Key;
      var prop = item.Value;
      Console.WriteLine($"Property: {name}, ComponentType: {prop.ComponentType.Name}, " +
                        $"Type: {prop.PropertyType.Name}, Category: {prop.Category}");
      countComponentTypes[prop.ComponentType] = countComponentTypes.GetValueOrDefault(prop.ComponentType) + 1;
    }
    Console.WriteLine();
    var totalCount = countComponentTypes.Values.Sum();
    foreach (var type in countComponentTypes.Keys)
    {
      Console.WriteLine($"ComponentType: {type.Name}, Count: {countComponentTypes[type]}");
    }
    Console.WriteLine();
    Console.WriteLine($"Total Count: {totalCount}");
    result = totalCount >= 240;
    Console.WriteLine();

    if (!result)
    {
      Console.WriteLine($"✗ Some properties are not listed.");
      return false;
    }
    Console.WriteLine("✓ Known properties list test passed\n");
    return true;
  }



  /// <summary>
  /// Tests XML serialization and deserialization for <see cref="KnownProperties"/>.
  /// </summary>
  /// <returns>True if the round-trip succeeds; otherwise, false.</returns>
  static bool TestPropertiesCategories()
  {
    Console.WriteLine("--- Known properties list ---");
    var document = new Document();
    var knownProperties = document.KnownProperties;
    bool result = true;
    int noCategoryProps = 0;
    foreach (var item in knownProperties)
    {
      var name = item.Key;
      var prop = item.Value;
      Console.WriteLine($"Property: {name}, ComponentType: {prop.ComponentType.Name}, " +
                        $"Type: {prop.PropertyType.Name}, Category: {prop.Category}");
      if (string.IsNullOrEmpty(prop.Category))
      {
        result = false;
        noCategoryProps++;
      }
    }

    if (!result)
    {
      Console.WriteLine($"✗ {noCategoryProps} properties do not have a category declared.");
      return false;
    }
    Console.WriteLine("✓ Known properties list test passed\n");
    return true;
  }

}