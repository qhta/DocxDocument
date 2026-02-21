using System.Diagnostics;

using DocumentModel.OpenXml;

using UInt64Converter = DocumentModel.OpenXml.UInt64Converter;

namespace DocumentModel.BaseConverters.Test;

/// <summary>
///   Provides unit tests for verifying the correctness of <see cref="OpenXml.UInt64Converter"/> conversions between .NET UInt64 values and various Open XML numeric types.
///   Tests round-trip conversion for supported Open XML numeric types, including range validation and exception handling.
/// </summary>
public static class UInt64ConverterTest
{
  /// <summary>
  ///   List of Open XML types supported for UInt64 value conversion tests.
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
  ///   Runs all UInt64Converter tests for supported types and reports results to the console.
  /// </summary>
  /// <returns>True if all tests pass; otherwise, false.</returns>
  public static bool Run()
  {
    bool testResult = true;
    foreach (var type in SupportedTypes)
    {
      Console.Write($"TestUInt64Conversion with {type.Name} ");
      if (!TestUInt64Conversion(type))
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
  ///   Test values used for UInt64 conversion tests, including boundary and typical values.
  /// </summary>
  static readonly UInt64[] testValues =
  [
    0,
    0,
    0,
    0,
    1,
    12345678901234567890,
    UInt64.MaxValue
  ];
  /// <summary>
  ///   Dictionary mapping Open XML types to their valid UInt64 value ranges (min, max) for conversion tests.
  /// </summary>
  public static Dictionary<Type, (UInt64 min, UInt64 max)> typeRanges = new()
  {
    { typeof(DX.SByteValue), (0, (UInt64)SByte.MaxValue) },
    { typeof(DX.Int16Value), (0, (UInt64)Int16.MaxValue) },
    { typeof(DX.Int32Value), (0, (UInt64)Int32.MaxValue) },
    { typeof(DX.Int64Value), (0, Int64.MaxValue) },
    { typeof(DX.IntegerValue), (0, Int64.MaxValue) },
    { typeof(DX.ByteValue), (0, Byte.MaxValue) },
    { typeof(DX.UInt16Value), (0, UInt16.MaxValue) },
    { typeof(DX.UInt32Value), (0, UInt32.MaxValue) },
    { typeof(DX.UInt64Value), (0, UInt64.MaxValue) },
    { typeof(DX.StringValue), (0, UInt64.MaxValue) }
  };

  /// <summary>
  ///   Tests round-trip conversion of UInt64 values to and from the specified Open XML numeric type.
  ///   Validates correct conversion, range enforcement, and exception handling for out-of-range values.
  /// </summary>
  /// <param name="openXmlType">The Open XML type to test UInt64 conversion for.</param>
  /// <returns>True if the conversion is correct; otherwise, false.</returns>
  public static bool TestUInt64Conversion(Type openXmlType)
  {
    foreach (var testValue in testValues)
    {
      try
      {
        // Convert to OpenXml
        var openXmlValue = UInt64Converter.ConvertTo(testValue, openXmlType);
        if (openXmlValue == null)
        {
          Console.WriteLine($"Conversion to OpenXml returned null for value {testValue}");
          return false;
        }
        var (min, max) = typeRanges[openXmlType];
        if (testValue < min || testValue > max)
        {
          Console.WriteLine("Out-of-range value did not throw an exception. ");
          return false; // Expected exception for out-of-range value
        }

        // Convert back to UInt64
        var convertedBackValue = UInt64Converter.ConvertFrom(openXmlValue);
        if (convertedBackValue == null)
        {
          Console.WriteLine($"Conversion back to UInt64 returned null for OpenXml value {openXmlValue}");
          return false;
        }
        if (!testValue.Equals(convertedBackValue))
        {
          Console.WriteLine($"Mismatch: original {testValue}, converted back {convertedBackValue}");
          return false;
        }
      } catch (Exception e)
      {
        var (min, max) = typeRanges[openXmlType];
        if (testValue < min || testValue > max)
          return true; // Expected exception for out-of-range value

        Console.WriteLine(e.Message);
        return false;
      }
    }
    return true;
  }
}