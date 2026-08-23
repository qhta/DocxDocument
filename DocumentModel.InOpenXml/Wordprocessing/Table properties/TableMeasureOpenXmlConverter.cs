namespace DocumentModel.Wordprocessing;
/// <summary>
/// Converter class responsible for registering Open XML conversion delegates for table measurement properties,
/// specifically for the TableWidth property in WordprocessingML documents.
/// This class ensures that the conversion logic for TableWidth is properly integrated into the OpenXmlModelConverter framework,
/// allowing seamless translation between the DocumentModel representation and the Open XML SDK representation of table width properties.
/// </summary>
[DataContract]
[XmlRoot("TableMeasureOpenXmlConverter", Namespace = "DocumentModel.Wordprocessing")]
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
  /// <param name = "openXmlElement">The Open XML element to convert. Must be an instance of DXW.TableWidth to perform the conversion;
  /// otherwise, the method returns null.</param>
  /// <param name = "modelType">The target model type. Conversion is performed only if this is typeof(TableMeasure).</param>
  /// <returns>A TableMeasure object if the conversion is successful; otherwise, null.</returns>
  private static TableMeasure? ConvertFromOpenXmlTableWidth(object? openXmlElement, Type modelType)
  {
    if (openXmlElement is DXW.TableWidth tableWidth)
      return TableMeasure.FromOpenXml(tableWidth.Width, tableWidth.Type);
    return null;
  }

  /// <summary>
  /// Converts a table measurement model object to an OpenXml TableWidth object if the specified type matches.
  /// </summary>
  /// <param name = "modelObject">The model object representing the table measurement to convert. This should be an instance of TableMeasure or
  /// null.</param>
  /// <param name = "openXmlType">The target OpenXml type for conversion. Must be typeof(DXW.TableWidth) to perform the conversion.</param>
  /// <returns>A new DXW.TableWidth object representing the converted table measurement if the parameters are valid; otherwise,
  /// null.</returns>
  private static object? ConvertToOpenXmlTableWidth(object? modelObject, Type openXmlType)
  {
    if (openXmlType == typeof(DXW.TableWidth) && modelObject is TableMeasure tableMeasure)
    {
      var (width, widthType) = tableMeasure.ToOpenXml();
      return new DXW.TableWidth
      {
        Width = width,
        Type = widthType
      };
    }

    return null;
  }
}