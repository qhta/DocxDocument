namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the ContourColor Class.
/// </summary>
public static class ContourColorConverter
{
  private static DocumentModel.Wordprocessing.RgbColorModelHex? GetRgbColorModelHex(DocumentFormat.OpenXml.Office2010.Word.ContourColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.RgbColorModelHex>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.RgbColorModelHexConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRgbColorModelHex(DocumentFormat.OpenXml.Office2010.Word.ContourColor openXmlElement, DocumentModel.Wordprocessing.RgbColorModelHex? value)
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
  
  private static DocumentModel.Wordprocessing.SchemeColor? GetSchemeColor(DocumentFormat.OpenXml.Office2010.Word.ContourColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.SchemeColor>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.SchemeColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSchemeColor(DocumentFormat.OpenXml.Office2010.Word.ContourColor openXmlElement, DocumentModel.Wordprocessing.SchemeColor? value)
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
  
  public static DocumentModel.Wordprocessing.ContourColor? CreateModelElement(DocumentFormat.OpenXml.Office2010.Word.ContourColor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.ContourColor();
      value.RgbColorModelHex = GetRgbColorModelHex(openXmlElement);
      value.SchemeColor = GetSchemeColor(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.ContourColor? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Word.ContourColor, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRgbColorModelHex(openXmlElement, value?.RgbColorModelHex);
      SetSchemeColor(openXmlElement, value?.SchemeColor);
      return openXmlElement;
    }
    return default;
  }
}
