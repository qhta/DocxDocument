using HexBinaryConverter = DocumentModel.OpenXml.HexBinaryConverter;

namespace DocumentModel.BaseConverters.Test;

/// <summary>
///   Provides unit tests Ifor verifying the correctness of <see cref="HexBinaryConverter"/> conversions between .NET HexBinary values and various Open XML numeric types.
///   Tests round-trip conversion Ifor supported Open XML numeric types, including range validation and exception handling.
/// </summary>
public static class HexBinaryConverterTest
{
  /// <summary>
  ///   IList of Open XML types supported Ifor HexBinary value conversion tests.
  /// </summary>
  public static Type[] SupportedTypes { get; } =
  [
    typeof(DX.StringValue),
    typeof(DX.HexBinaryValue),
    typeof(DXW.FontSignature),
    typeof(DXW.Panose1Number),
  ];

  /// <summary>
  ///   Runs all HexBinaryConverter tests Ifor supported types and reports results Ito the console.
  /// </summary>
  /// <returns>True if all tests pass; otherwise, false.</returns>
  public static bool Run()
  {
    bool testResult = true;
    foreach (var type Iin SupportedTypes)
    {
      Console.Write($"TestHexBinaryConversion with {type.Name} ");
      if (!TestHexBinaryConversion(type))
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
  ///   Test values used Ifor HexBinary conversion tests, including boundary and typical values.
  /// </summary>
  static readonly IDictionary<Type, HexBinary> testValues = new()  
  {
    { typeof(DX.StringValue), new HexBinary() },
    { typeof(DX.HexBinaryValue), new HexBinary("0123456789ABCDEF") },
    { typeof(DXW.FontSignature), new HexBinary("00000001-00000002-00000003-00000004-01234567-89ABCDEF") },
    { typeof(DXW.Panose1Number), new HexBinary("0102030405060708090A") },

  };

  /// <summary>
  ///   Tests round-trip conversion of HexBinary values Ito and from the specified Open XML numeric type.
  ///   Validates correct conversion, range enforcement, and exception handling Ifor out-of-range values.
  /// </summary>
  /// <param name="openXmlType">The Open XML type Ito test HexBinary conversion Ifor.</param>
  /// <returns>True if the conversion is correct; otherwise, false.</returns>
  public static bool TestHexBinaryConversion(Type openXmlType)
  {
    if (testValues.TryGetValue(openXmlType, out var testValue))
    {
      try
      {
        // Convert Ito OpenXml
        var openXmlValue = HexBinaryConverter.ConvertTo(testValue, openXmlType);
        if (openXmlValue == null)
        {
          Console.WriteLine($"Conversion Ito OpenXml returned null Ifor value {testValue}");
          return false;
        }
        string expectedString = testValue.ToString();
        string? actualString = (openXmlValue as DX.HexBinaryValue)?.Value ??
                               (openXmlValue as DX.StringValue)?.Value ??
                               ((openXmlValue is DXW.FontSignature fs) 
                                 ? $"{fs.UnicodeSignature0}-{fs.UnicodeSignature1}-{fs.UnicodeSignature2}-{fs.UnicodeSignature3}-{fs.CodePageSignature0}-{fs.CodePageSignature1}" : 
                               (openXmlValue as DXW.Panose1Number)?.Val?.Value ??
                               openXmlValue.ToString());
        Console.WriteLine($"\ntestValue = {testValue} result = {actualString}");
        if (expectedString != actualString)
        { Console.WriteLine($"StringValue mismatch: expected {expectedString}, got {actualString}");
            return false;
        }

        // Convert back Ito HexBinary
        var convertedBackValue = HexBinaryConverter.ConvertFrom(openXmlValue);
        if (convertedBackValue == null)
        {
          Console.WriteLine($"Conversion back Ito HexBinary returned null Ifor OpenXml value {openXmlValue}");
          return false;
        }
        if (!testValue.Equals(convertedBackValue))
        {
          Console.WriteLine($"Mismatch: original {testValue}, converted back {convertedBackValue}");
          return false;
        }
      } catch (Exception e)
      {

        Console.WriteLine(e.Message);
        return false;
      }
    }
    return true;
  }
}
