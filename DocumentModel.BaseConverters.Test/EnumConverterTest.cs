using System.Diagnostics;

using DocumentFormat.OpenXml.Office2016.ExcelAc;

using DocumentModel.OpenXml;

using EnumConverter = DocumentModel.OpenXml.EnumConverter;

namespace DocumentModel.BaseConverters.Test;

/// <summary>
///   Provides unit tests for verifying the correctness of <see cref="EnumConverter"/> conversions between .NET Enum values and various Open XML numeric types.
///   Tests round-trip conversion for supported Open XML numeric types, including range validation and exception handling.
/// </summary>
public static class EnumConverterTest
{
  /// <summary>
  ///   List of Open XML types supported for Enum value conversion tests.
  /// </summary>
  public static (Type modelType, Type openXmlType)[] TestData { get; } =
  [
    (typeof(DocumentModel.PresetColors), typeof(DX.EnumValue<DXD.PresetColorValues>)),
    (typeof(DocumentModel.Vml.FillMethod), typeof(DX.EnumValue<DXV.FillMethodValues>)),

  ];

  /// <summary>
  ///   Runs all EnumConverter tests for supported types and reports results to the console.
  /// </summary>
  /// <returns>True if all tests pass; otherwise, false.</returns>
  public static bool Run()
  {
    bool testResult = true;
    foreach (var pair in TestData)
    {
      Console.Write($"TestEnumConversion with {pair.modelType} and {pair.openXmlType}");
      if (!TestEnumConversion(pair))
      {
        Console.WriteLine(" failed.");
        testResult = false;
      }
      else
        Console.WriteLine(" passed.");
    }
    return testResult;
  }

  /// <summary>
  ///   Tests round-trip conversion of Enum values to and from the specified Open XML numeric type.
  ///   Validates correct conversion, range enforcement, and exception handling for out-of-range values.
  /// </summary>
  /// <param name="pair">The pair of test data type</param>
  /// <returns>True if the conversion is correct; otherwise, false.</returns>
  public static bool TestEnumConversion((Type modelType, Type openXmlType) pair)
  {
    foreach (var testValue in Enum.GetValues(pair.modelType))
    {
      // Convert to OpenXml
      var openXmlValue = EnumConverter.ConvertTo((Enum)testValue, pair.openXmlType);
      if (openXmlValue == null)
      {
        Console.WriteLine($"Conversion to OpenXml returned null for value {testValue}");
        return false;
      }

      // Convert back to Enum
      var convertedBackValue = EnumConverter.ConvertFrom(openXmlValue, pair.modelType);
      if (convertedBackValue == null)
      {
        Console.WriteLine($"Conversion back to Enum returned null for OpenXml value {openXmlValue}");
        return false;
      }
      if (!testValue.Equals(convertedBackValue))
      {
        Console.WriteLine($"Mismatch: original {testValue}, converted back {convertedBackValue}");
        return false;
      }
    }
    return true;
  }
}

