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
  ///   List of Open XML types supported for UInt32 value conversion tests.
  /// </summary>
  public static Type[] SupportedTypes { get; } =
  [
    typeof(DX.SByteValue),
    typeof(DX.Int16Value),
    typeof(DX.Int32Value),
    typeof(DX.Int64Value),
    typeof(DX.IntegerValue),
    typeof(DX.ByteValue),
    typeof(DX.UInt16Value),
    typeof(DX.UInt32Value),
    typeof(DX.UInt64Value),
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
  static readonly Percent[] testValues =
  [
    0,
    1,
    -1,
    12345678,
    12345678,
    -12345678,
    Decimal.MaxValue,
    Decimal.MinValue
  ];

  /// <summary>
  ///   Dictionary mapping Open XML types to their valid UInt32 value ranges (min, max) for conversion tests.
  /// </summary>
  public static Dictionary<Type, (object min, object max)> typeRanges = new()
  {
    { typeof(DX.SByteValue), (SByte.MinValue, SByte.MaxValue) },
    { typeof(DX.Int16Value), (Int16.MinValue, Int16.MaxValue) },
    { typeof(DX.Int32Value), (Int32.MinValue, Int32.MaxValue) },
    { typeof(DX.Int64Value), (Int64.MinValue, Int64.MaxValue) },
    { typeof(DX.IntegerValue), (Int64.MinValue, Int64.MaxValue) },
    { typeof(DX.ByteValue), (Byte.MinValue, Byte.MaxValue) },
    { typeof(DX.UInt16Value), (0, UInt16.MaxValue) },
    { typeof(DX.UInt32Value), (0, UInt32.MaxValue) },
    { typeof(DX.UInt64Value), (0, UInt64.MaxValue) },
    { typeof(DX.StringValue), (Decimal.MinValue, Decimal.MaxValue) }
  };

  /// <summary>
  ///   Tests round-trip conversion of UInt32 values to and from the specified Open XML numeric type.
  ///   Validates correct conversion, range enforcement, and exception handling for out-of-range values.
  /// </summary>
  /// <param name="openXmlType">The Open XML type to test UInt32 conversion for.</param>
  /// <returns>True if the conversion is correct; otherwise, false.</returns>
  public static bool TestPercentConversion(Type openXmlType)
  {
    foreach (var testValue in testValues)
    {
      try
      {
        if (openXmlType == typeof(DX.Int16Value))
          Debug.Assert(true);

        // Convert to OpenXml
        // ReSharper disable once SpecifyACultureInStringConversionExplicitly

        if (testValue.ToString() == "-1%" && openXmlType == typeof(DX.Int32Value))
          Debug.Assert(true); 
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
        if (convertedBackValue == null)
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