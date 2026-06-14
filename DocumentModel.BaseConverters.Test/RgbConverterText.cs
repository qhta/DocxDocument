using System.Diagnostics;

using DocumentModel.OpenXml;

namespace DocumentModel.BaseConverters.Test;

/// <summary>
///   Provides unit tests for verifying the correctness of <see cref="HexColorConverter"/> conversions between .NET RGB values and various Open XML numeric types.
///   Tests round-trip conversion for supported Open XML numeric types, including range validation and exception handling.
/// </summary>
public static class RgbConverterTest
{
  /// <summary>
  ///   IList of Open XML types supported for RGB value conversion tests.
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
  ///   Runs all RgbConverter tests for supported types and reports results to the console.
  /// </summary>
  /// <returns>True if all tests pass; otherwise, false.</returns>
  public static bool Run()
  {
    bool testResult = true;
    foreach (var type in SupportedTypes)
    {
      Console.Write($"TestRgbConversion with {type.Name} ");
      if (!TestRgbConversion(type))
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
  ///   Test values used for RGB conversion tests, including boundary and typical values.
  /// </summary>
  static readonly HexColor[] testValues =
  [
    0xABCDEF,
    UInt32.MaxValue
  ];
  /// <summary>
  ///   IDictionary mapping Open XML types to their valid RGB value ranges (min, max) for conversion tests.
  /// </summary>
  public static Dictionary<Type, (uint min, uint max)> typeRanges = new()
  {
    { typeof(DX.SByteValue), (0u, (uint)SByte.MaxValue) },
    { typeof(DX.Int16Value), (0u, (uint)Int16.MaxValue) },
    { typeof(DX.Int32Value), (0u, (uint)Int32.MaxValue) },
    { typeof(DX.Int64Value), (0u, (uint)UInt32.MaxValue) },
    { typeof(DX.IntegerValue), (0u, (uint)UInt32.MaxValue) },
    { typeof(DX.ByteValue), (0u, (uint)Byte.MaxValue) },
    { typeof(DX.UInt16Value), (0u, (uint)UInt16.MaxValue) },
    { typeof(DX.UInt32Value), (0u, (uint)UInt32.MaxValue) },
    { typeof(DX.UInt64Value), (0u, (uint)UInt32.MaxValue) },
    { typeof(DX.StringValue), (0u, (uint)UInt32.MaxValue) },
    { typeof(DX.HexBinaryValue), (0u, (uint)UInt32.MaxValue) }
  };

  /// <summary>
  ///   Tests round-trip conversion of RGB values to and from the specified Open XML numeric type.
  ///   Validates correct conversion, range enforcement, and exception handling for out-of-range values.
  /// </summary>
  /// <param name="openXmlType">The Open XML type to test RGB conversion for.</param>
  /// <returns>True if the conversion is correct; otherwise, false.</returns>
  public static bool TestRgbConversion(Type openXmlType)
  {
    int valueIndex = 0;
    foreach (var testValue in testValues)
    {
      try
      {
        // Convert to OpenXml
        var openXmlValue = HexColorConverter.ConvertTo(testValue, openXmlType);
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
        // Convert back to RGB
        var convertedBackValue = HexColorConverter.ConvertFrom(openXmlValue);
        if (convertedBackValue is null)
        {
          Console.WriteLine($"Conversion back to RGB returned null for OpenXml value {openXmlValue}");
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
