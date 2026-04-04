using DMP = DocumentModel.Properties;

namespace DocumentModel.InOpenXml.Test;

/// <summary>
/// Comprehensive test for DocumentModel.BaseInterfaces implementation.
/// </summary>
public class ElementCollectionTest: _AbstractTestClass
{
  /// <summary>
  /// Runs all tests and reports the results.
  /// </summary>
  /// <returns>true if all tests pass; otherwise, false.</returns>
  public static bool Run()
  {
    Console.WriteLine("=== ElementCollectionTest ===\n");
    if (!TestIndexerGetByIntAndString()) return false;
    if (!TestIndexerSetByInt()) return false;
    if (!TestEnumeration()) return false;
    if (!TestMissingNameThrows()) return false;
    if (!TestInvalidIndexTypeThrows()) return false;

    Console.WriteLine("All ElementCollectionTest.\n");
    return true;
  }

  static bool TestIndexerGetByIntAndString()
  {
    Console.WriteLine("--- Test IModelCollection indexer get (int/string) ---");
    var props = CreateSampleCollection();
    IModelCollection<DMP.ICustomProperty> modelCollection = props;

    var byInt = modelCollection[0];
    var byString = modelCollection["Second"];

    if (!ReferenceEquals(byInt, props[0]))
    {
      Console.WriteLine("✗ IModelCollection indexer get by int FAILED - unexpected item instance");
      return false;
    }
    if (!ReferenceEquals(byString, props[1]))
    {
      Console.WriteLine("✗ IModelCollection indexer get by string FAILED - unexpected item instance");
      return false;
    }

    Console.WriteLine("✓ IModelCollection indexer get test passed\n");
    return true;
  }

  static bool TestIndexerSetByInt()
  {
    Console.WriteLine("--- Test IModelCollection indexer set (int) ---");
    var props = CreateSampleCollection();
    IModelCollection<DMP.ICustomProperty> modelCollection = props;
    var replacement = new CustomProperty { Name = "Replacement", Value = "Updated" };

    try
    {
      modelCollection[1] = replacement;
    }
    catch (Exception ex)
    {
      Console.WriteLine($"✗ IModelCollection indexer set by int FAILED - unexpected exception: {ex.GetType().Name}: {ex.Message}");
      return false;
    }

    if (!ReferenceEquals(props[1], replacement))
    {
      Console.WriteLine("✗ IModelCollection indexer set by int FAILED - replacement was not applied");
      return false;
    }

    Console.WriteLine("✓ IModelCollection indexer set by int test passed\n");
    return true;
  }

  static bool TestEnumeration()
  {
    Console.WriteLine("--- Test IModelCollection enumeration ---");
    {
      var props = CreateSampleCollection();
      IModelCollection<DMP.ICustomProperty> modelCollection = props;

      var names = new List<string?>();
      foreach (var item in modelCollection)
      {
        names.Add(item.Name);
      }

      if (names.Count != 3)
      {
        Console.WriteLine($"✗ IModelCollection enumeration FAILED - count is {names.Count}, expected 3");
        return false;
      }
      if (names[0] != "First" || names[1] != "Second" || names[2] != "Third")
      {
        Console.WriteLine("✗ IModelCollection enumeration FAILED - sequence order mismatch");
        return false;
      }

      Console.WriteLine("✓ IModelCollection enumeration test passed\n");
      return true;
    }
  }

  static bool TestMissingNameThrows()
  {
    Console.WriteLine("--- Test IModelCollection missing string key throws ---");
    {
      var props = CreateSampleCollection();
      IModelCollection<DMP.ICustomProperty> modelCollection = props;

      try
      {
        _ = modelCollection["MissingName"];
        Console.WriteLine("✗ IModelCollection missing string key test FAILED - expected KeyNotFoundException");
        return false;
      }
      catch (KeyNotFoundException)
      {
        Console.WriteLine("✓ IModelCollection missing string key throws test passed\n");
        return true;
      }
      catch (Exception ex)
      {
        Console.WriteLine($"✗ IModelCollection missing string key test FAILED - unexpected exception: {ex.GetType().Name}: {ex.Message}");
        return false;
      }
    }
  }

  static bool TestInvalidIndexTypeThrows()
  {
    Console.WriteLine("--- Test IModelCollection invalid index type throws ---");
    {
      var props = CreateSampleCollection();
      IModelCollection<DMP.ICustomProperty> modelCollection = props;

      try
      {
        _ = modelCollection[1.5];
        Console.WriteLine("✗ IModelCollection invalid index type test FAILED - expected NotSupportedException");
        return false;
      }
      catch (NotSupportedException)
      {
        Console.WriteLine("✓ IModelCollection invalid index type throws test passed\n");
        return true;
      }
      catch (Exception ex)
      {
        Console.WriteLine($"✗ IModelCollection invalid index type test FAILED - unexpected exception: {ex.GetType().Name}: {ex.Message}");
        return false;
      }
    }
  }

  static CustomProperties CreateSampleCollection()
  {
    var props = new CustomProperties();
    props.Add(new CustomProperty { Name = "First", Value = "One" });
    props.Add(new CustomProperty { Name = "Second", Value = 2 });
    props.Add(new CustomProperty { Name = "Third", Value = true });
    return props;
  }
}