namespace DocumentModel.Wordprocessing;

/// <summary>
/// Converter class responsible for registering Open XML conversion delegates for table measurement properties,
/// specifically for the TableWidth property in WordprocessingML documents.
/// This class ensures that the conversion logic for TableWidth is properly integrated into the OpenXmlModelConverter framework,
/// allowing seamless translation between the DocumentModel representation and the Open XML SDK representation of table width properties.
/// </summary>
public static class TableMeasureOpenXmlConverter
{
  /// <summary>
  /// Registers the conversion delegates that enable conversion between the TableWidth type and its Open XML
  /// representation.
  /// </summary>
  /// <remarks>Call this method to ensure that TableWidth objects can be correctly converted to and from their
  /// Open XML equivalents when working with OpenXmlModelConverter. This registration is required before performing
  /// conversions involving TableWidth in Open XML documents.</remarks>
  public static void RegisterOpenXmlConversion()
  {
    OpenXmlModelConverter.ConvertFromOpenXmlDelegates[typeof(DXW.TableWidth)] = ConvertFromOpenXmlTableWidth;
    OpenXmlModelConverter.ConvertToOpenXmlDelegates[typeof(DXW.TableWidth)] = ConvertToOpenXmlTableWidth;
  }


  /// <summary>
  /// Converts an Open XML TableWidth element to its corresponding domain model representation.
  /// </summary>
  /// <param name="openXmlElement">The Open XML element to convert. Must be an instance of DXW.TableWidth to perform the conversion;
  /// otherwise, the method returns null.</param>
  /// <param name="modelType">The target model type. Conversion is performed only if this is typeof(TableMeasure).</param>
  /// <returns>A TableMeasure object if the conversion is successful; otherwise, null.</returns>
  private static TableMeasure? ConvertFromOpenXmlTableWidth(object? openXmlElement, Type modelType)
  {
    if (openXmlElement is DXW.TableWidth tableWidth)
    {
      if (tableWidth.Type == null || tableWidth.Width == null)
        return null;
      if (tableWidth.Type == DXW.TableWidthUnitValues.Nil)
        return new TableMeasure("nil");
      if (tableWidth.Type == DXW.TableWidthUnitValues.Auto)
        return new TableMeasure("auto");
      if (tableWidth.Type == DXW.TableWidthUnitValues.Pct)
        return new TableMeasure(tableWidth.Width.ToString()!+"%");
      if (tableWidth.Type == DXW.TableWidthUnitValues.Dxa)
        return new TableMeasure(tableWidth.Width.ToString()!);
    }
    return null;
  }


  /// <summary>
  /// Converts a model object representing table width to an Open XML TableWidth  object if the specified type
  /// matches.
  /// </summary>
  /// <remarks>This method is intended for internal use when mapping model objects to Open XML types. If the
  /// provided model object is not compatible with the specified Open XML type, the method returns null without throwing
  /// an exception.</remarks>
  /// <param name="modelObject">The model object to convert. Must be an instance of DocumentModel.HeadingPairs to perform the conversion;
  /// otherwise, the method returns null.</param>
  /// <param name="openXmlType">The target Open XML type. Conversion is performed only if this is typeof(DXW.TableWidth).</param>
  /// <returns>An Open XML TableWidth object if the conversion is successful; otherwise, null.</returns>
  private static object? ConvertToOpenXmlTableWidth(object? modelObject, Type openXmlType)
  {
    if (openXmlType == typeof(DXW.TableWidth))
    {
      if (modelObject is TableMeasure tableMeasure)
        return new DXW.TableWidth
        {
          Width = tableMeasure.IntValue.ToString(),
          // ReSharper disable once InvokeAsExtensionMember
          Type = EnumTypeConverter.CreateOpenXmlEnumValue<DXW.TableWidthUnitValues, TableMeasureType>(tableMeasure.Type)
        };
    }
    return null;
  }

}