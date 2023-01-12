namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the ExtrusionColor Class.
/// </summary>
public static class ExtrusionColorConverter
{
  public static DocumentModel.Wordprocessing.RgbColorModelHex? GetRgbColorModelHex(DocumentFormat.OpenXml.Office2010.Word.ExtrusionColor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.RgbColorModelHex>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.RgbColorModelHexConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRgbColorModelHex(DocumentFormat.OpenXml.Office2010.Word.ExtrusionColor? openXmlElement, DocumentModel.Wordprocessing.RgbColorModelHex? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Wordprocessing.SchemeColor? GetSchemeColor(DocumentFormat.OpenXml.Office2010.Word.ExtrusionColor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.SchemeColor>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.SchemeColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSchemeColor(DocumentFormat.OpenXml.Office2010.Word.ExtrusionColor? openXmlElement, DocumentModel.Wordprocessing.SchemeColor? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Wordprocessing.ExtrusionColor? CreateModelElement(DocumentFormat.OpenXml.Office2010.Word.ExtrusionColor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.ExtrusionColor();
      value.RgbColorModelHex = GetRgbColorModelHex(openXmlElement);
      value.SchemeColor = GetSchemeColor(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.ExtrusionColor? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Word.ExtrusionColor, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
