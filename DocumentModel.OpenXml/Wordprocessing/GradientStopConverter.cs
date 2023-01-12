namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the GradientStop Class.
/// </summary>
public static class GradientStopConverter
{
  /// <summary>
  /// pos, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetStopPosition(DocumentFormat.OpenXml.Office2010.Word.GradientStop? openXmlElement)
  {
    return openXmlElement?.StopPosition?.Value;
  }
  
  public static void SetStopPosition(DocumentFormat.OpenXml.Office2010.Word.GradientStop? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.StopPosition = value;
  }
  
  /// <summary>
  /// RgbColorModelHex.
  /// </summary>
  public static DocumentModel.Wordprocessing.RgbColorModelHex? GetRgbColorModelHex(DocumentFormat.OpenXml.Office2010.Word.GradientStop? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.RgbColorModelHex>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.RgbColorModelHexConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRgbColorModelHex(DocumentFormat.OpenXml.Office2010.Word.GradientStop? openXmlElement, DocumentModel.Wordprocessing.RgbColorModelHex? value)
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
  
  /// <summary>
  /// SchemeColor.
  /// </summary>
  public static DocumentModel.Wordprocessing.SchemeColor? GetSchemeColor(DocumentFormat.OpenXml.Office2010.Word.GradientStop? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.SchemeColor>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.SchemeColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSchemeColor(DocumentFormat.OpenXml.Office2010.Word.GradientStop? openXmlElement, DocumentModel.Wordprocessing.SchemeColor? value)
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
  
  public static DocumentModel.Wordprocessing.GradientStop? CreateModelElement(DocumentFormat.OpenXml.Office2010.Word.GradientStop? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.GradientStop();
      value.StopPosition = GetStopPosition(openXmlElement);
      value.RgbColorModelHex = GetRgbColorModelHex(openXmlElement);
      value.SchemeColor = GetSchemeColor(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.GradientStop? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Word.GradientStop, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetStopPosition(openXmlElement, value?.StopPosition);
      SetRgbColorModelHex(openXmlElement, value?.RgbColorModelHex);
      SetSchemeColor(openXmlElement, value?.SchemeColor);
      return openXmlElement;
    }
    return default;
  }
}
