namespace DocumentModel.Wordprocessing;
/// <summary>
/// Converter class responsible for registering Open XML conversion delegates for table measurement properties,
/// specifically for the PixelsMeasure property in WordprocessingML documents.
/// This class ensures that the conversion logic for PixelsMeasure is properly integrated into the OpenXmlModelConverter framework,
/// allowing seamless translation between the DocumentModel representation and the Open XML SDK representation of table height properties.
/// </summary>
[DataContract]
[XmlRoot("PixelsMeasureOpenXmlConverter", Namespace = "DocumentModel.Wordprocessing")]
public static class PixelsMeasureOpenXmlConverter
{
  /// <summary>
  /// Registers the conversion delegates that enable conversion between the PixelsMeasure type and its Open XML
  /// representation.
  /// </summary>
  /// <remarks>Call this method to ensure that PixelsMeasure objects can be correctly converted to and from their
  /// Open XML equivalents when working with OpenXmlModelConverter. This registration is required before performing
  /// conversions involving PixelsMeasure in Open XML documents.</remarks>
  public static void RegisterOpenXmlConversion()
  {
    OpenXmlModelConverter.ConvertFromOpenXmlDelegates[typeof(DXW.PixelsMeasureType)] = ConvertFromOpenXmlPixelsMeasureType;
    OpenXmlModelConverter.ConvertToOpenXmlDelegates[typeof(DXW.PixelsMeasureType)] = ConvertToOpenXmlPixelsMeasureType;
  }

  /// <summary>
  /// Converts an Open XML PixelsMeasureType element to its corresponding domain model representation.
  /// </summary>
  /// <param name = "openXmlElement">The Open XML element to convert. Must be an instance of DXW.PixelsMeasureType to perform the conversion;
  /// otherwise, the method returns null.</param>
  /// <param name = "modelType">The target model type. Conversion is performed only if this is typeof(PixelsMeasure).</param>
  /// <returns>A PixelsMeasure object if the conversion is successful; otherwise, null.</returns>
  private static PixelsMeasure? ConvertFromOpenXmlPixelsMeasureType(object? openXmlElement, Type modelType)
  {
    if (openXmlElement is DXW.PixelsMeasureType pixelsMeasureType)
      return PixelsMeasure.FromOpenXml(pixelsMeasureType);
    return null;
  }

  /// <summary>
  /// Converts a model object representing PixelsMeasure to an Open XML PixelsMeasureType object if the specified type
  /// matches.
  /// </summary>
  /// <remarks>This method is intended for internal use when mapping model objects to Open XML types. If the
  /// provided model object is not compatible with the specified Open XML type, the method returns null without throwing
  /// an exception.</remarks>
  /// <param name = "modelObject">The model object to convert. Must be an instance of DocumentModel.PixelsMeasure to perform the conversion;
  /// otherwise, the method returns null.</param>
  /// <param name = "openXmlType">The target Open XML type. Conversion is performed only if this is typeof(DXW.PixelsMeasureType).</param>
  /// <returns>An Open XML PixelsMeasureType object if the conversion is successful; otherwise, null.</returns>
  private static object? ConvertToOpenXmlPixelsMeasureType(object? modelObject, Type openXmlType)
  {
    if (openXmlType == typeof(DXW.PixelsMeasureType) && modelObject is PixelsMeasure PixelsMeasure)
    {
      return PixelsMeasure.ToOpenXml(openXmlType);
    }

    return null;
  }
}