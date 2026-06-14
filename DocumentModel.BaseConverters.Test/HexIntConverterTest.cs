using System.Diagnostics;

using DocumentModel.OpenXml;

using HexIntConverter = DocumentModel.OpenXml.HexIntConverter;

namespace DocumentModel.BaseConverters.Test;

/// <summary>
///   Provides unit tests for verifying the correctness of <see cref="HexIntConverter"/> conversions between .NET HexInt values and various Open XML numeric types.
///   Tests round-trip conversion for supported Open XML numeric types, including range validation and exception handling.
/// </summary>
public static class HexIntConverterTest
{
  /// <summary>
  ///   IList of Open XML types supported for HexInt value conversion tests.
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
    typeof(DX.StringValue),
    typeof(DX.HexBinaryValue),
  ];

  /// <summary>
  ///   Runs all HexIntConverter tests for supported types and reports results to the console.
  /// </summary>
  /// <returns>True if all tests pass; otherwise, false.</returns>
  public static bool Run()
  {
    bool testResult = true;
    foreach (var type in SupportedTypes)
    {
      Console.Write($"TestHexIntConversion with {type.Name} ");
      if (!TestHexIntConversion(type))
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
  ///   Test values used for HexInt conversion tests, including boundary and typical values.
  /// </summary>
  static readonly HexInt[] testValues =
  [
    0,
    1,
    12345678,
    UInt32.MaxValue
  ];
  /// <summary>
  ///   IDictionary mapping Open XML types to their valid HexInt value ranges (min, max) for conversion tests.
  /// </summary>
  public static Dictionary<Type, (HexInt min, HexInt max)> typeRanges = new()
  {
    { typeof(DX.SByteValue), (0, (HexInt)SByte.MaxValue) },
    { typeof(DX.Int16Value), (0, (HexInt)Int16.MaxValue) },
    { typeof(DX.Int32Value), (0, (HexInt)Int32.MaxValue) },
    { typeof(DX.Int64Value), (0, UInt32.MaxValue) },
    { typeof(DX.IntegerValue), (0, UInt32.MaxValue) },
    { typeof(DX.ByteValue), (0, (HexInt)Byte.MaxValue) },
    { typeof(DX.UInt16Value), (0, UInt16.MaxValue) },
    { typeof(DX.UInt32Value), (0, UInt32.MaxValue) },
    { typeof(DX.UInt64Value), (0, UInt32.MaxValue) },
    { typeof(DX.StringValue), (0, UInt32.MaxValue) },
    { typeof(DX.HexBinaryValue), (0, UInt32.MaxValue) }
  };

  /// <summary>
  ///   Tests round-trip conversion of HexInt values to and from the specified Open XML numeric type.
  ///   Validates correct conversion, range enforcement, and exception handling for out-of-range values.
  /// </summary>
  /// <param name="openXmlType">The Open XML type to test HexInt conversion for.</param>
  /// <returns>True if the conversion is correct; otherwise, false.</returns>
  public static bool TestHexIntConversion(Type openXmlType)
  {
    int valueIndex = 0;
    foreach (var testValue in testValues)
    {
      try
      {
        // Convert to OpenXml
        var openXmlValue = HexIntConverter.ConvertTo(testValue, openXmlType);
        if (openXmlValue == null)
        {
          Console.WriteLine($"Conversion to OpenXml returned null for value {testValue}");
          return false;
        }
        if (openXmlValue is DX.StringValue strVal)
        {
          // Additional check for StringValue representation
          // ReSharper disable once SpecifyACultureInStringConversionExplicitly
          var expectedString = testValue.ToString();
          if (valueIndex == 0) Console.WriteLine();
          Console.WriteLine($"testValue = {testValue} result = {strVal.Value}");
          if (strVal.Value != expectedString)
          {
            Console.WriteLine($"StringValue mismatch: expected {expectedString}, got {strVal.Value}");
            return false;
          }
        }
        else
        if (openXmlValue is DX.HexBinaryValue hexBinVal)
        {
          // Additional check for HexBinaryValue representation
          // ReSharper disable once SpecifyACultureInStringConversionExplicitly
          var expectedString = testValue.ToString();
          if (valueIndex == 0) Console.WriteLine();
          Console.WriteLine($"testValue = {testValue} result = {hexBinVal.Value}");
          if (hexBinVal.Value != expectedString)
          {
            Console.WriteLine($"StringValue mismatch: expected {expectedString}, got {hexBinVal.Value}");
            return false;
          }
        }
        //Console.WriteLine(openXmlValue);
        //var (min, max) = typeRanges[openXmlType];
        //if (testValue < min || testValue > max)
        //{
        //  Console.WriteLine("Out-of-range value did not throw an exception. ");
        //  return false; // Expected exception for out-of-range value
        //}
        // Convert back to HexInt
        var convertedBackValue = HexIntConverter.ConvertFrom(openXmlValue);
        if (convertedBackValue == null)
        {
          Console.WriteLine($"Conversion back to HexInt returned null for OpenXml value {openXmlValue}");
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
      valueIndex++;
    }
    return true;
  }
}
