namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Glow Class.
/// </summary>
public static class GlowConverter
{
  /// <summary>
  /// rad, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int64? GetGlowRadius(DocumentFormat.OpenXml.Office2010.Word.Glow openXmlElement)
  {
    return openXmlElement.GlowRadius?.Value;
  }
  
  private static void SetGlowRadius(DocumentFormat.OpenXml.Office2010.Word.Glow openXmlElement, Int64? value)
  {
    openXmlElement.GlowRadius = value;
  }
  
  /// <summary>
  /// RgbColorModelHex.
  /// </summary>
  private static DocumentModel.Wordprocessing.RgbColorModelHex? GetRgbColorModelHex(DocumentFormat.OpenXml.Office2010.Word.Glow openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.RgbColorModelHex>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.RgbColorModelHexConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRgbColorModelHex(DocumentFormat.OpenXml.Office2010.Word.Glow openXmlElement, DocumentModel.Wordprocessing.RgbColorModelHex? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.RgbColorModelHex>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.RgbColorModelHexConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.RgbColorModelHex>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// SchemeColor.
  /// </summary>
  private static DocumentModel.Wordprocessing.SchemeColor? GetSchemeColor(DocumentFormat.OpenXml.Office2010.Word.Glow openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.SchemeColor>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.SchemeColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSchemeColor(DocumentFormat.OpenXml.Office2010.Word.Glow openXmlElement, DocumentModel.Wordprocessing.SchemeColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.SchemeColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.SchemeColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.SchemeColor>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.Glow? CreateModelElement(DocumentFormat.OpenXml.Office2010.Word.Glow? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Glow();
      value.GlowRadius = GetGlowRadius(openXmlElement);
      value.RgbColorModelHex = GetRgbColorModelHex(openXmlElement);
      value.SchemeColor = GetSchemeColor(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Glow? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Word.Glow, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGlowRadius(openXmlElement, value?.GlowRadius);
      SetRgbColorModelHex(openXmlElement, value?.RgbColorModelHex);
      SetSchemeColor(openXmlElement, value?.SchemeColor);
      return openXmlElement;
    }
    return default;
  }
}
