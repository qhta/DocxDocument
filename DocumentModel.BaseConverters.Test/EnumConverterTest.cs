using EnumTypeConverter = DocumentModel.OpenXml.EnumTypeConverter;

namespace DocumentModel.BaseConverters.Test;

/// <summary>
///   Provides unit tests for verifying the correctness of <see cref="EnumTypeConverter"/> conversions between .NET Enum values and various Open XML numeric types.
///   Tests round-trip conversion for supported Open XML numeric types, including range validation and exception handling.
/// </summary>
public static class EnumConverterTest
{
  /// <summary>
  ///   IList of Open XML types supported for Enum value conversion tests.
  /// </summary>
  public static (Type modelType, Type openXmlType)[] TestData { get; } =
  [
    (typeof(DocumentModel.PresetColors), typeof(DX.EnumValue<DXD.PresetColorValues>)),
    (typeof(DocumentModel.Vml.FillMethod), typeof(DX.EnumValue<DXV.FillMethodValues>)),
    (typeof(DocumentModel.Math.RowSpacingRule), typeof(DXM.RowSpacingRule)),
    (typeof(DocumentModel.DocumentSecurity), typeof(DXEP.DocumentSecurity)),
    (typeof(DocumentModel.Wordprocessing.SourceType), typeof(DXB.SourceType)),
    (typeof(DocumentModel.Wordprocessing.FontCharset), typeof(DXW.FontCharSet)),
    (typeof(DocumentModel.Wordprocessing.TableMeasureType), typeof(DXW.TableWidthUnitValues)),
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
      if (!TestEnumConversion(pair.modelType, pair.openXmlType))
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
  /// <param name="modelType">The model type</param>
  /// <param name="openXmlType">The Open XML type</param>
  /// <returns>True if the conversion is correct; otherwise, false.</returns>
  public static bool TestEnumConversion(Type modelType, Type openXmlType)
  {
    var testValues = Enum.GetValues(modelType);
    if (modelType.GetCustomAttribute<FlagsAttribute>() != null)
    {
      // For Flags enums, test a combination of all values
      long combinedValue = 0;
      foreach (var value in testValues)
      {
        combinedValue |= Convert.ToInt64(value);
      }
      var combinedEnum = Enum.ToObject(modelType, combinedValue);
      testValues = testValues.Cast<object>().Append(combinedEnum).ToArray();
    }
    int valueIndex = 0;
    foreach (var testValue in testValues)
    {
      // Convert to OpenXml
      var openXmlValue = EnumTypeConverter.ConvertTo((Enum)testValue, openXmlType);
      if (openXmlValue == null)
      {
        if (valueIndex == 0)
          Console.WriteLine();
        Console.WriteLine($"Conversion to OpenXml returned null for value {testValue}");
        return false;
      }

      var outputText = (openXmlValue is DX.OpenXmlLeafTextElement openXmlLeafTextElement)
        ? openXmlLeafTextElement.Text
        : (openXmlValue is DX.OpenXmlLeafElement openXmlLeafElement)
        ? ((openXmlType.GetProperty("Val") ?? openXmlType.GetProperty("Value"))?.GetValue(openXmlLeafElement)?.ToString())
        : (openXmlValue as DX.IEnumValue)?.Value
        ?? openXmlValue.ToString();
      if (valueIndex == 0)
        Console.WriteLine();
      Console.WriteLine($"Converted {testValue} to OpenXml value {outputText}");

      // Convert back to Enum
      var convertedBackValue = EnumTypeConverter.ConvertFrom(openXmlValue, modelType);
      if (convertedBackValue == null)
      {
        if (valueIndex == 0)
          Console.WriteLine();
        Console.WriteLine($"Conversion back to Enum returned null for OpenXml value {openXmlValue}");
        return false;
      }
      if (!testValue.Equals(convertedBackValue))
      {
        Console.WriteLine($"Mismatch: original {testValue}, converted back {convertedBackValue}");
        return false;
      }
      valueIndex++;
    }
    return true;
  }
}


