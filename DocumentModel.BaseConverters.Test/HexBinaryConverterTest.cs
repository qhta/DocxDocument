using HexBinaryConverter = DocumentModel.OpenXml.HexBinaryConverter;

namespace DocumentModel.BaseConverters.Test;

/// <summary>
///   Provides unit tests for verifying the correctness of <see cref="HexBinaryConverter"/> conversions between .NET HexBinary values and various Open XML numeric types.
///   Tests round-trip conversion for supported Open XML numeric types, including range validation and exception handling.
/// </summary>
public static class HexBinaryConverterTest
{
  /// <summary>
  ///   List of Open XML types supported for HexBinary value conversion tests.
  /// </summary>
  public static Type[] SupportedTypes { get; } =
  [
    typeof(DX.StringValue),
    typeof(DX.HexBinaryValue),
    typeof(DXW.FontSignature),
  ];

  /// <summary>
  ///   Runs all HexBinaryConverter tests for supported types and reports results to the console.
  /// </summary>
  /// <returns>True if all tests pass; otherwise, false.</returns>
  public static bool Run()
  {
    bool testResult = true;
    foreach (var type in SupportedTypes)
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
  ///   Test values used for HexBinary conversion tests, including boundary and typical values.
  /// </summary>
  static readonly HexBinary[] testValues =
  [
    new HexBinary(),
    new HexBinary("00000001-00000002-00000003-00000004-01234567-89ABCDEF")
  ];
 
  /// <summary>
  ///   Tests round-trip conversion of HexBinary values to and from the specified Open XML numeric type.
  ///   Validates correct conversion, range enforcement, and exception handling for out-of-range values.
  /// </summary>
  /// <param name="openXmlType">The Open XML type to test HexBinary conversion for.</param>
  /// <returns>True if the conversion is correct; otherwise, false.</returns>
  public static bool TestHexBinaryConversion(Type openXmlType)
  {
    int valueIndex = 0;
    foreach (var testValue in testValues)
    {
      try
      {
        if (openXmlType == typeof(DX.Int16Value))
          Debug.Assert(true);

        // Convert to OpenXml
        var openXmlValue = HexBinaryConverter.ConvertTo(testValue, openXmlType);
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

        // Convert back to HexBinary
        var convertedBackValue = HexBinaryConverter.ConvertFrom(openXmlValue);
        if (convertedBackValue == null)
        {
          Console.WriteLine($"Conversion back to HexBinary returned null for OpenXml value {openXmlValue}");
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
      valueIndex++;
    }
    return true;
  }
}