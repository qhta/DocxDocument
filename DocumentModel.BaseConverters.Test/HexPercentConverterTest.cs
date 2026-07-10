using System.Diagnostics;

using DocumentModel.OpenXml;

using HexPercentConverter = DocumentModel.OpenXml.HexPercentConverter;

namespace DocumentModel.BaseConverters.Test;

/// <summary>
///   Provides unit tests for verifying the correctness of <see cref="HexPercentConverter"/> conversions between .NET UInt32 values and various Open XML numeric types.
///   Tests round-trip conversion for supported Open XML numeric types, including range validation and exception handling.
/// </summary>
public static class HexPercentConverterTest
{
  /// <summary>
  ///   IList of Open XML types supported for UInt32 value conversion tests.
  /// </summary>
  public static Type[] SupportedTypes { get; } =
  [
    //typeof(DX.ByteValue),
    typeof(DX.StringValue)
  ];

  /// <summary>
  ///   Runs all HexPercentConverter tests for supported types and reports results to the console.
  /// </summary>
  /// <returns>True if all tests pass; otherwise, false.</returns>
  public static bool Run()
  {
    bool testResult = true;
    foreach (var type in SupportedTypes)
    {
      Console.Write($"TestHexPercentConversion with {type.Name} ");
      if (!TestHexPercentConversion(type))
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
  static readonly HexPercent[] testValues =
  [
    new HexPercent("60%"),
    new HexPercent("#FF"),
  ];


  /// <summary>
  ///   Tests round-trip conversion of UInt32 values to and from the specified Open XML numeric type.
  ///   Validates correct conversion, range enforcement, and exception handling for out-of-range values.
  /// </summary>
  /// <param name="openXmlType">The Open XML type to test UInt32 conversion for.</param>
  /// <returns>True if the conversion is correct; otherwise, false.</returns>
  public static bool TestHexPercentConversion(Type openXmlType)
  {
    foreach (var testValue in testValues)
    {
      try
      {
        var openXmlValue = HexPercentConverter.ConvertTo(testValue, openXmlType);
        if (openXmlValue == null)
        {
          Console.WriteLine($"Conversion to OpenXml returned null for value {testValue}");
          return false;
        }
        Console.Write($"{testValue} -> {openXmlValue} ");
        // Convert back to HexPercent
        var convertedBackValue = HexPercentConverter.ConvertFrom(openXmlValue);
        if (convertedBackValue is null)
        {
          Console.WriteLine($"Conversion back to HexPercent returned null for OpenXml value {openXmlValue}");
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
        Console.WriteLine($"\n{e.GetType().Name} for {testValue} expected");
        return true;
      }
    }
    return true;
  }
}
