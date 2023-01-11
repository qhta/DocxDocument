namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
/// Defines the WebVideoProperty Class.
/// </summary>
public static class WebVideoPropertyConverter
{
  /// <summary>
  /// embeddedHtml, this property is only available in Office 2013 and later.
  /// </summary>
  public static String? GetEmbeddedHtml(DocumentFormat.OpenXml.Office2013.Word.Drawing.WebVideoProperty? openXmlElement)
  {
    return openXmlElement?.EmbeddedHtml?.Value;
  }
  
  public static void SetEmbeddedHtml(DocumentFormat.OpenXml.Office2013.Word.Drawing.WebVideoProperty? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.EmbeddedHtml = new StringValue { Value = value };
      else
        openXmlElement.EmbeddedHtml = null;
  }
  
  /// <summary>
  /// h, this property is only available in Office 2013 and later.
  /// </summary>
  public static UInt32? GetHeight(DocumentFormat.OpenXml.Office2013.Word.Drawing.WebVideoProperty? openXmlElement)
  {
    return openXmlElement?.Height?.Value;
  }
  
  public static void SetHeight(DocumentFormat.OpenXml.Office2013.Word.Drawing.WebVideoProperty? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Height = value;
  }
  
  /// <summary>
  /// w, this property is only available in Office 2013 and later.
  /// </summary>
  public static UInt32? GetWidth(DocumentFormat.OpenXml.Office2013.Word.Drawing.WebVideoProperty? openXmlElement)
  {
    return openXmlElement?.Width?.Value;
  }
  
  public static void SetWidth(DocumentFormat.OpenXml.Office2013.Word.Drawing.WebVideoProperty? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Width = value;
  }
  
  public static DocumentModel.Drawings.Wordprocessing.WebVideoProperty? CreateModelElement(DocumentFormat.OpenXml.Office2013.Word.Drawing.WebVideoProperty? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Wordprocessing.WebVideoProperty();
      value.EmbeddedHtml = GetEmbeddedHtml(openXmlElement);
      value.Height = GetHeight(openXmlElement);
      value.Width = GetWidth(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Wordprocessing.WebVideoProperty? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.Word.Drawing.WebVideoProperty, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
