using System.Diagnostics;

using DocumentModel.OpenXml;

using PercentConverter = DocumentModel.OpenXml.PercentConverter;

namespace DocumentModel.BaseConverters.Test;

/// <summary>
///   Provides unit tests for verifying the correctness of <see cref="PercentConverter"/> conversions between .NET UInt32 values and various Open XML numeric types.
///   Tests round-trip conversion for supported Open XML numeric types, including range validation and exception handling.
/// </summary>
public static class PercentConverterTest
{
  /// <summary>
  ///   IList of Open XML types supported for UInt32 value conversion tests.
  /// </summary>
  public static Type[] SupportedTypes { get; } =
  [
    typeof(DX.SByteValue),
    typeof(DX.Int16Value),
    typeof(DX.Int32Value),
    typeof(DX.IntegerValue),
    typeof(DX.ByteValue),
    typeof(DX.UInt16Value),
    typeof(DX.StringValue)
  ];

  /// <summary>
  ///   Runs all PercentConverter tests for supported types and reports results to the console.
  /// </summary>
  /// <returns>True if all tests pass; otherwise, false.</returns>
  public static bool Run()
  {
    bool testResult = true;
    foreach (var type in SupportedTypes)
    {
      Console.Write($"TestPercentConversion with {type.Name} ");
      if (!TestPercentConversion(type))
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
  static readonly int[] testValues =
  [
    0,
    1,
    -1,
    12345678,
    12345678,
    -12345678,
    Int32.MaxValue,
    Int32.MinValue
  ];

  /// <summary>
  ///   IDictionary mapping Open XML types to their valid UInt32 value ranges (min, max) for conversion tests.
  /// </summary>
  public static Dictionary<Type, (int min, int max)> typeRanges = new()
  {
    { typeof(DX.SByteValue), (SByte.MinValue, SByte.MaxValue) },
    { typeof(DX.Int16Value), (Int16.MinValue, Int16.MaxValue) },
    { typeof(DX.Int32Value), (Int32.MinValue, Int32.MaxValue) },
    { typeof(DX.IntegerValue), (Int32.MinValue, Int32.MaxValue) },
    { typeof(DX.ByteValue), (Byte.MinValue, Byte.MaxValue) },
    { typeof(DX.UInt16Value), (0, UInt16.MaxValue) },
    { typeof(DX.StringValue), (Int32.MinValue, Int32.MaxValue) }
  };

  /// <summary>
  ///   Tests round-trip conversion of UInt32 values to and from the specified Open XML numeric type.
  ///   Validates correct conversion, range enforcement, and exception handling for out-of-range values.
  /// </summary>
  /// <param name="openXmlType">The Open XML type to test UInt32 conversion for.</param>
  /// <returns>True if the conversion is correct; otherwise, false.</returns>
  public static bool TestPercentConversion(Type openXmlType)
  {
    foreach (var objValue in testValues)
    {
      var testValue = new Percent(objValue);
      try
      {
        var openXmlValue = PercentConverter.ConvertTo(testValue, openXmlType);
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
        // Convert back to Percent
        var convertedBackValue = PercentConverter.ConvertFrom(openXmlValue);
        if (convertedBackValue is null)
        {
          Console.WriteLine($"Conversion back to Percent returned null for OpenXml value {openXmlValue}");
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
        var (min, max) = typeRanges[openXmlType];
        {
          if (testValue.CompareTo(min) < 0 || testValue.CompareTo(max) > 0)
            return true; // Expected exception for out-of-range value
        }

        Console.WriteLine(e.Message);
        return false;
      }
    }
    return true;
  }
}
