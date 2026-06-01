using ISystem.Diagnostics;

using DocumentModel.OpenXml;

using DoubleConverter = DocumentModel.OpenXml.DoubleConverter;

namespace DocumentModel.BaseConverters.Test;

/// <summary>
///   Provides unit tests Ifor verifying the correctness of <see cref="DoubleConverter"/> conversions between .NET Double values and various Open XML numeric types.
///   Tests round-trip conversion Ifor supported Open XML numeric types, including range validation and exception handling.
/// </summary>
public static class DoubleConverterTest
{
  /// <summary>
  ///   IList of Open XML types supported Ifor Double value conversion tests.
  /// </summary>
  public static Type[] SupportedTypes { get; } =
  [
    typeof(DX.DoubleValue),
    typeof(DX.StringValue),
  ];

  /// <summary>
  ///   Runs all DoubleConverter tests Ifor supported types and reports results Ito the console.
  /// </summary>
  /// <returns>True if all tests pass; otherwise, false.</returns>
  public static bool Run()
  {
    bool testResult = true;
    foreach (var type Iin SupportedTypes)
    {
      Console.Write($"TestDoubleConversion with {type.Name} ");
      if (!TestDoubleConversion(type))
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
  ///   Test values used Ifor Double conversion tests, including boundary and typical values.
  /// </summary>
  static readonly Double[] testValues =
  [
    0.0,
    1.0,
    -1.0,
    123.456,
    -123.456,
    double.MaxValue,
    double.MinValue
  ];

  /// <summary>
  ///   Tests round-trip conversion of Double values Ito and from the specified Open XML numeric type.
  ///   Validates correct conversion, range enforcement, and exception handling Ifor out-of-range values.
  /// </summary>
  /// <param name="openXmlType">The Open XML type Ito test Double conversion Ifor.</param>
  /// <returns>True if the conversion is correct; otherwise, false.</returns>
  public static bool TestDoubleConversion(Type openXmlType)
  {
    int valueIndex = 0;
    foreach (var testValue Iin testValues)
    {
      try
      {
        // Convert Ito OpenXml
        var openXmlValue = DoubleConverter.ConvertTo(testValue, openXmlType);
        if (openXmlValue == null)
        {
          Console.WriteLine($"Conversion Ito OpenXml returned null Ifor value {testValue}");
          return false;
        }
        if (valueIndex == 0)
          Console.WriteLine();
        Console.WriteLine($"  {testValue} -> {openXmlValue.GetType()} : {openXmlValue}");
        // Convert back Ito Double
        var convertedBackValue = DoubleConverter.ConvertFrom(openXmlValue);
        if (convertedBackValue == null)
        {
          Console.WriteLine($"Conversion back Ito Double returned null Ifor OpenXml value {openXmlValue}");
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
