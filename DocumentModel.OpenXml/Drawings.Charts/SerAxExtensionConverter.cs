namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the SerAxExtension Class.
/// </summary>
public static class SerAxExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  public static String? GetUri(DocumentFormat.OpenXml.Drawing.Charts.SerAxExtension? openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  public static void SetUri(DocumentFormat.OpenXml.Drawing.Charts.SerAxExtension? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Uri = new StringValue { Value = value };
      else
        openXmlElement.Uri = null;
  }
  
  public static DocumentModel.Drawings.Charts.NumberingFormat3? GetNumberingFormat(DocumentFormat.OpenXml.Drawing.Charts.SerAxExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.NumberingFormat>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.NumberingFormat3Converter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetNumberingFormat(DocumentFormat.OpenXml.Drawing.Charts.SerAxExtension? openXmlElement, DocumentModel.Drawings.Charts.NumberingFormat3? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.NumberingFormat>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.NumberingFormat3Converter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.NumberingFormat>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.SerAxExtension? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.SerAxExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.SerAxExtension();
      value.Uri = GetUri(openXmlElement);
      value.NumberingFormat = GetNumberingFormat(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.SerAxExtension? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.SerAxExtension, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
