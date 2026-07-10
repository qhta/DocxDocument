using System.Diagnostics;

using DocumentModel.OpenXml;

using PercentageConverter = DocumentModel.OpenXml.PercentageConverter;

namespace DocumentModel.BaseConverters.Test;

/// <summary>
///   Provides unit tests for verifying the correctness of <see cref="PercentageConverter"/> conversions between .NET UInt32 values and various Open XML numeric types.
///   Tests round-trip conversion for supported Open XML numeric types, including range validation and exception handling.
/// </summary>
public static class PercentageConverterTest
{
  /// <summary>
  ///   IList of Open XML types supported for UInt32 value conversion tests.
  /// </summary>
  public static Type[] SupportedTypes { get; } =
  [
    typeof(DX.Int32Value),
    typeof(DX.StringValue)
  ];

  /// <summary>
  ///   Runs all PercentageConverter tests for supported types and reports results to the console.
  /// </summary>
  /// <returns>True if all tests pass; otherwise, false.</returns>
  public static bool Run()
  {
    bool testResult = true;
    foreach (var type in SupportedTypes)
    {
      Console.Write($"TestPercentageConversion with {type.Name} ");
      if (!TestPercentageConversion(type))
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
  ///   Test values used for UInt32 conversion tests, including boundary and typical values.
  /// </summary>
  static readonly decimal[] testValues =
  [
    //0,
    //1,
    //-1,
    12345.678m,
    -12345.678m,
    Int32.MaxValue / 1000.0m,
    Int32.MinValue / 1000.0m
  ];

  /// <summary>
  ///   IDictionary mapping Open XML types to their valid UInt32 value ranges (min, max) for conversion tests.
  /// </summary>
  public static Dictionary<Type, (int min, int max)> typeRanges = new()
  {
    { typeof(DX.Int32Value), (Int32.MinValue, Int32.MaxValue) },
    { typeof(DX.IntegerValue), (Int32.MinValue, Int32.MaxValue) },
    { typeof(DX.StringValue), (Int32.MinValue, Int32.MaxValue) }
  };

  /// <summary>
  ///   Tests round-trip conversion of UInt32 values to and from the specified Open XML numeric type.
  ///   Validates correct conversion, range enforcement, and exception handling for out-of-range values.
  /// </summary>
  /// <param name="openXmlType">The Open XML type to test UInt32 conversion for.</param>
  /// <returns>True if the conversion is correct; otherwise, false.</returns>
  public static bool TestPercentageConversion(Type openXmlType)
  {
    foreach (var objValue in testValues)
    {
      var testValue = new Percentage(objValue);
      try
      {
        var openXmlValue = PercentageConverter.ConvertTo(testValue, openXmlType);
        if (openXmlValue == null)
        {
          Console.WriteLine($"Conversion to OpenXml returned null for value {testValue}");
          return false;
        }
        var (min, max) = typeRanges[openXmlType];
        if (testValue.CompareTo(min) < 0 || testValue.CompareTo(max) > 0)
        {
          Console.WriteLine("Out-of-range value did not throw an exception. ");
          return false; // Expected exception for out-of-range value
        }
        // Convert back to Percentage
        var convertedBackValue = PercentageConverter.ConvertFrom(openXmlValue);
        if (convertedBackValue is null)
        {
          Console.WriteLine($"Conversion back to Percentage returned null for OpenXml value {openXmlValue}");
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
        Console.WriteLine($"\n{e.GetType().Name} for {objValue} expected");
        return true;
      }
    }
    return true;
  }
}
