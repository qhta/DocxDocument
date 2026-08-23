using DMP = DocumentModel.Properties;

namespace DocumentModel.InOpenXml.Test;

/// <summary>
/// Comprehensive test for DocumentModel.BaseInterfaces implementation.
/// </summary>
public class ElementCollectionTest : _AbstractTestClass
{

  /// <summary>
  /// Runs all tests and reports the results.
  /// </summary>
  /// <returns>true if all tests pass; otherwise, false.</returns>
  public override bool Run()
  {
    Console.WriteLine($"===  {TestName} test ===\n");
    if (!TestIModelCollectionIndexerGetByInt()) return false;
    if (!TestIndexerGetString()) return false;
    if (!TestIModelCollectionIndexerSetByInt()) return false;
    if (!TestIModelCollectionEnumeration()) return false;
    if (!TestIModelCollectionMissingNameThrows()) return false;
    if (!TestIModelCollectionInvalidIndexTypeThrows()) return false;
    Console.WriteLine($"All {TestName} tests passed.\n");
    return true;
  }

  /// <summary>
  /// Tests the indexer get by int functionality of IModelCollection.
  /// </summary>
  /// <returns></returns>
  private bool TestIModelCollectionIndexerGetByInt()
  {
    var testMethodName = GetInvokingMethodName();
    Console.WriteLine($"--- {testMethodName} ---");
    var props = CreateSampleCollection();
    IModelCollection<DMP.ICustomProperty> modelCollection = props;

    var byInt = modelCollection[0];

    if (!ReferenceEquals(byInt, props[0]))
    {
      Console.WriteLine($"✗ {testMethodName} FAILED - unexpected item instance");
      return false;
    }

    Console.WriteLine($"✓ {testMethodName} passed\n");
    return true;
  }

  /// <summary>
  /// Tests the indexer get by string functionality of IModelCollection.
  /// </summary>
  /// <returns></returns>
  private bool TestIndexerGetString()
  {
    var testMethodName = GetInvokingMethodName();
    Console.WriteLine($"--- {testMethodName} ---");
    var props = CreateSampleCollection();
    IModelCollection<DMP.ICustomProperty> modelCollection = props;

    var byString = modelCollection["Second"];

    if (!ReferenceEquals(byString, props[1]))
    {
      Console.WriteLine($"✗ {testMethodName} FAILED - unexpected item instance");
      return false;
    }

    Console.WriteLine($"✓ {testMethodName} passed\n");
    return true;
  }

  /// <summary>
  /// Tests setting an element in the IModelCollection by integer index and verifies that the replacement is applied
  /// correctly.  
  /// </summary>
  /// <remarks>This method checks that assigning a new element to the IModelCollection using an integer index
  /// updates the collection as expected. It also verifies that no unexpected exceptions are thrown during the
  /// operation.</remarks>
  /// <returns>true if the replacement element is set successfully at the specified index; otherwise, false.</returns>
  private bool TestIModelCollectionIndexerSetByInt()
  {
    var testMethodName = GetInvokingMethodName();
    Console.WriteLine($"--- {testMethodName} ---");
    var props = CreateSampleCollection();
    IModelCollection<DMP.ICustomProperty> modelCollection = props;
    var replacement = new CustomProperty { Name = "Replacement", Value = "Updated" };

    try
    {
      modelCollection[1] = replacement;
    }
    catch (Exception ex)
    {
      Console.WriteLine($"✗ {testMethodName} FAILED - unexpected exception: {ex.GetType().Name}: {ex.Message}");
      return false;
    }

    if (!ReferenceEquals(props[1], replacement))
    {
      Console.WriteLine($"✗ {testMethodName} FAILED - replacement was not applied");
      return false;
    }

    Console.WriteLine($"✓ {testMethodName} passed\n");
    return true;
  }

  /// <summary>
  /// Tests the enumeration behavior of the IModelCollection interface to ensure items are iterated in the expected
  /// order and count.  
  /// </summary>
  /// <remarks>This method verifies that enumerating an IModelCollection of ICustomProperty yields exactly three
  /// items in the correct sequence. It outputs diagnostic messages to the console indicating the result of the
  /// test.</remarks>
  /// <returns>true if the IModelCollection enumeration produces the expected item count and order; otherwise, false.</returns>
  private bool TestIModelCollectionEnumeration()
  {
    var testMethodName = GetInvokingMethodName();
    Console.WriteLine($"--- {testMethodName} ---");
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
        Console.WriteLine($"✗ {testMethodName} FAILED - count is {names.Count}, expected 3");
        return false;
      }
      if (names[0] != "First" || names[1] != "Second" || names[2] != "Third")
      {
        Console.WriteLine($"✗ {testMethodName} FAILED - sequence order mismatch");
        return false;
      }

      Console.WriteLine($"✓ {testMethodName} passed\n");
      return true;
    }
  }

  /// <summary>
  /// Tests that accessing a missing string key in an IModelCollection throws a KeyNotFoundException.
  /// </summary>
  /// <remarks>This test verifies the correct exception handling behavior when attempting to access a
  /// non-existent key in an IModelCollection. It is intended to ensure that the collection implementation conforms to
  /// expected .NET collection semantics.</remarks>
  /// <returns>true if the KeyNotFoundException is thrown as expected; otherwise, false.</returns>
  private bool TestIModelCollectionMissingNameThrows()
  {
    var testMethodName = GetInvokingMethodName();
    Console.WriteLine($"--- {testMethodName} ---");
    {
      var props = CreateSampleCollection();
      IModelCollection<DMP.ICustomProperty> modelCollection = props;

      try
      {
        _ = modelCollection["MissingName"];
        Console.WriteLine($"✗ {testMethodName} FAILED - expected KeyNotFoundException");
        return false;
      }
      catch (KeyNotFoundException ex)
      {
        Debug.WriteLine($"Expected exception: {ex.GetType().Name} {ex.Message}");
        Console.WriteLine($"✓ {testMethodName} passed\n");
        return true;
      }
      catch (Exception ex)
      {
        Console.WriteLine($"✗ {testMethodName} FAILED - unexpected exception: {ex.GetType().Name}: {ex.Message}");
        return false;
      }
    }
  }

  /// <summary>
  /// Tests whether accessing an IModelCollection with an invalid index type throws the expected exception. 
  /// </summary>
  /// <remarks>This test verifies that the IModelCollection implementation correctly handles attempts to access
  /// elements using an unsupported index type, such as a double, by throwing an exception. The test is considered
  /// successful if an exception is thrown and unsuccessful otherwise.</remarks>
  /// <returns>true if the method throws an exception as expected when an invalid index type is used; otherwise, false.</returns>
  private bool TestIModelCollectionInvalidIndexTypeThrows()
  {
    var testMethodName = GetInvokingMethodName();
    Console.WriteLine($"--- {testMethodName} ---");
    {
      var props = CreateSampleCollection();
      IModelCollection<DMP.ICustomProperty> modelCollection = props;

      try
      {
        _ = modelCollection[1.5];
        Console.WriteLine($"✗ {testMethodName} FAILED - expected NotSupportedException");
        return false;
      }
      catch (NotSupportedException ex)
      {
        Debug.WriteLine($"Expected exception: {ex.GetType().Name} {ex.Message}");
        Console.WriteLine($"✓ {testMethodName} passed\n");
        return true;
      }
    }
  }

  private CustomProperties CreateSampleCollection()
  {
    var props = new CustomProperties();
    props.Add(new CustomProperty { Name = "First", Value = "One" });
    props.Add(new CustomProperty { Name = "Second", Value = 2 });
    props.Add(new CustomProperty { Name = "Third", Value = true });
    return props;
  }
}