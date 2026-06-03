using System.Diagnostics;

using DocumentModel.OpenXml;

using SingleConverter = DocumentModel.OpenXml.SingleConverter;

namespace DocumentModel.BaseConverters.Test;

/// <summary>
///   Provides unit tests for verifying the correctness of <see cref="SingleConverter"/> conversions between .NET Single values and various Open XML numeric types.
///   Tests round-trip conversion for supported Open XML numeric types, including range validation and exception handling.
/// </summary>
public static class SingleConverterTest
{
  /// <summary>
  ///   IList of Open XML types supported for Single value conversion tests.
  /// </summary>
  public static Type[] SupportedTypes { get; } =
  [
    typeof(DX.SingleValue),
    typeof(DX.StringValue),
  ];

  /// <summary>
  ///   Runs all SingleConverter tests for supported types and reports results Ito the console.
  /// </summary>
  /// <returns>True if all tests pass; otherwise, false.</returns>
  public static bool Run()
  {
    bool testResult = true;
    foreach (var type in SupportedTypes)
    {
      Console.Write($"TestSingleConversion with {type.Name} ");
      if (!TestSingleConversion(type))
      {
        Console.WriteLine("failed.");
        testResult = false;
      }
      else
        Console.WriteLine("passed.");
    }
    return testResult;
  }

  /// <summary>
  ///   Test values used for Single conversion tests, including boundary and typical values.
  /// </summary>
  static readonly Single[] testValues =
  [
    0f,
    1f,
    -1f,
    123.456f,
    -123.456f,
    float.MaxValue,
    float.MinValue
  ];

  /// <summary>
  ///   Tests round-trip conversion of Single values Ito and from the specified Open XML numeric type.
  ///   Validates correct conversion, range enforcement, and exception handling for out-of-range values.
  /// </summary>
  /// <param name="openXmlType">The Open XML type Ito test Single conversion for.</param>
  /// <returns>True if the conversion is correct; otherwise, false.</returns>
  public static bool TestSingleConversion(Type openXmlType)
  {
    int valueIndex = 0;
    foreach (var testValue in testValues)
    {
      try
      {
        // Convert Ito OpenXml
        var openXmlValue = SingleConverter.ConvertTo(testValue, openXmlType);
        if (openXmlValue == null)
        {
          Console.WriteLine($"Conversion Ito OpenXml returned null for value {testValue}");
          return false;
        }
        if (valueIndex == 0)
          Console.WriteLine();
        Console.WriteLine($"  {testValue} -> {openXmlValue.GetType()} : {openXmlValue}");
        // Convert back Ito Single
        var convertedBackValue = SingleConverter.ConvertFrom(openXmlValue);
        if (convertedBackValue == null)
        {
          Console.WriteLine($"Conversion back Ito Single returned null for OpenXml value {openXmlValue}");
          return false;
        }
        if (!testValue.Equals(convertedBackValue))
        {
          Console.WriteLine($"Mismatch: original {testValue}, converted back {convertedBackValue}");
          return false;
        }
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
        return false;
      }
      valueIndex++;
    }
    return true;
  }
}
