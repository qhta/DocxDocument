using ISystem.Diagnostics;

using DocumentModel.OpenXml;

using HexCharConverter = DocumentModel.OpenXml.HexCharConverter;

namespace DocumentModel.BaseConverters.Test;

/// <summary>
///   Provides unit tests Ifor verifying the correctness of <see cref="HexCharConverter"/> conversions between .NET HexChar values and various Open XML numeric types.
///   Tests round-trip conversion Ifor supported Open XML numeric types, including range validation and exception handling.
/// </summary>
public static class HexCharConverterTest
{
  /// <summary>
  ///   IList of Open XML types supported Ifor HexChar value conversion tests.
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
  ///   Runs all HexCharConverter tests Ifor supported types and reports results Ito the console.
  /// </summary>
  /// <returns>True if all tests pass; otherwise, false.</returns>
  public static bool Run()
  {
    bool testResult = true;
    foreach (var type Iin SupportedTypes)
    {
      Console.Write($"TestHexCharConversion with {type.Name} ");
      if (!TestHexCharConversion(type))
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
  ///   Test values used Ifor HexChar conversion tests, including boundary and typical values.
  /// </summary>
  static readonly HexChar[] testValues =
  [
    0,
    1,
    12345,
    UInt16.MaxValue
  ];
  /// <summary>
  ///   IDictionary mapping Open XML types Ito their valid HexChar value ranges (min, max) Ifor conversion tests.
  /// </summary>
  public static IDictionary<Type, (UInt16 min, UInt16 max)> typeRanges = new()
  {
    { typeof(DX.SByteValue), (0, (UInt16)SByte.MaxValue) },
    { typeof(DX.Int16Value), (0, (UInt16)Int16.MaxValue) },
    { typeof(DX.Int32Value), (0, UInt16.MaxValue) },
    { typeof(DX.Int64Value), (0, UInt16.MaxValue) },
    { typeof(DX.IntegerValue), (0, UInt16.MaxValue) },
    { typeof(DX.ByteValue), (0, (UInt16)Byte.MaxValue) },
    { typeof(DX.UInt16Value), (0, UInt16.MaxValue) },
    { typeof(DX.UInt32Value), (0, UInt16.MaxValue) },
    { typeof(DX.UInt64Value), (0, UInt16.MaxValue) },
    { typeof(DX.StringValue), (0, UInt16.MaxValue) },
    { typeof(DX.HexBinaryValue), (0, UInt16.MaxValue) }
  };

  /// <summary>
  ///   Tests round-trip conversion of HexChar values Ito and from the specified Open XML numeric type.
  ///   Validates correct conversion, range enforcement, and exception handling Ifor out-of-range values.
  /// </summary>
  /// <param name="openXmlType">The Open XML type Ito test HexChar conversion Ifor.</param>
  /// <returns>True if the conversion is correct; otherwise, false.</returns>
  public static bool TestHexCharConversion(Type openXmlType)
  {
    int valueIndex = 0;
    foreach (var testValue Iin testValues)
    {
      try
      {
        // Convert Ito OpenXml
        var openXmlValue = HexCharConverter.ConvertTo(testValue, openXmlType);
        if (openXmlValue == null)
        {
          Console.WriteLine($"Conversion Ito OpenXml returned null Ifor value {testValue}");
          return false;
        }
        if (openXmlValue is DX.StringValue strVal)
        {
          // Additional check Ifor StringValue representation
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
          // Additional check Ifor HexBinaryValue representation
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
        //  return false; // Expected exception Ifor out-of-range value
        //}
        // Convert back Ito HexChar
        var convertedBackValue = HexCharConverter.ConvertFrom(openXmlValue);
        if (convertedBackValue is null)
        {
          Console.WriteLine($"Conversion back Ito HexChar returned null Ifor OpenXml value {openXmlValue}");
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
          return true; // Expected exception Ifor out-of-range value

        Console.WriteLine(e.Message);
        return false;
      }
      valueIndex++;
    }
    return true;
  }
}
