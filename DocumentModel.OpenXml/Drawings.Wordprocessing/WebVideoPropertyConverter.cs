namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
/// Defines the WebVideoProperty Class.
/// </summary>
public static class WebVideoPropertyConverter
{
  /// <summary>
  /// embeddedHtml, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetEmbeddedHtml(DocumentFormat.OpenXml.Office2013.Word.Drawing.WebVideoProperty openXmlElement)
  {
    return openXmlElement?.EmbeddedHtml?.Value;
  }
  
  private static void SetEmbeddedHtml(DocumentFormat.OpenXml.Office2013.Word.Drawing.WebVideoProperty openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.EmbeddedHtml = new StringValue { Value = value };
    else
      openXmlElement.EmbeddedHtml = null;
  }
  
  /// <summary>
  /// h, this property is only available in Office 2013 and later.
  /// </summary>
  private static UInt32? GetHeight(DocumentFormat.OpenXml.Office2013.Word.Drawing.WebVideoProperty openXmlElement)
  {
    return openXmlElement.Height?.Value;
  }
  
  private static void SetHeight(DocumentFormat.OpenXml.Office2013.Word.Drawing.WebVideoProperty openXmlElement, UInt32? value)
  {
    openXmlElement.Height = value;
  }
  
  /// <summary>
  /// w, this property is only available in Office 2013 and later.
  /// </summary>
  private static UInt32? GetWidth(DocumentFormat.OpenXml.Office2013.Word.Drawing.WebVideoProperty openXmlElement)
  {
    return openXmlElement.Width?.Value;
  }
  
  private static void SetWidth(DocumentFormat.OpenXml.Office2013.Word.Drawing.WebVideoProperty openXmlElement, UInt32? value)
  {
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
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetEmbeddedHtml(openXmlElement, value?.EmbeddedHtml);
      SetHeight(openXmlElement, value?.Height);
      SetWidth(openXmlElement, value?.Width);
      return openXmlElement;
    }
    return default;
  }
}
