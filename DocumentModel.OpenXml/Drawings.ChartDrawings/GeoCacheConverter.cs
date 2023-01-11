namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoCache Class.
/// </summary>
public static class GeoCacheConverter
{
  /// <summary>
  /// provider, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetProvider(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoCache? openXmlElement)
  {
    return openXmlElement?.Provider?.Value;
  }
  
  public static void SetProvider(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoCache? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Provider = new StringValue { Value = value };
      else
        openXmlElement.Provider = null;
  }
  
  public static String? GetXsdbase64Binary(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoCache? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Xsdbase64Binary");
  }
  
  public static void SetXsdbase64Binary(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoCache? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Xsdbase64Binary");
  }
  
  public static DocumentModel.Drawings.ChartDrawings.Clear? GetClear(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoCache? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Clear>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.ClearConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetClear(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoCache? openXmlElement, DocumentModel.Drawings.ChartDrawings.Clear? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Clear>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.ClearConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Clear>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.GeoCache? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoCache? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoCache();
      value.Provider = GetProvider(openXmlElement);
      value.Xsdbase64Binary = GetXsdbase64Binary(openXmlElement);
      value.Clear = GetClear(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.GeoCache? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoCache, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
