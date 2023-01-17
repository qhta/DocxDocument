namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the FillToRectangle Class.
/// </summary>
public static class FillToRectangleConverter
{
  /// <summary>
  /// l, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetLeft(DocumentFormat.OpenXml.Office2010.Word.FillToRectangle openXmlElement)
  {
    return openXmlElement.Left?.Value;
  }
  
  private static void SetLeft(DocumentFormat.OpenXml.Office2010.Word.FillToRectangle openXmlElement, Int32? value)
  {
    openXmlElement.Left = value;
  }
  
  /// <summary>
  /// t, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetTop(DocumentFormat.OpenXml.Office2010.Word.FillToRectangle openXmlElement)
  {
    return openXmlElement.Top?.Value;
  }
  
  private static void SetTop(DocumentFormat.OpenXml.Office2010.Word.FillToRectangle openXmlElement, Int32? value)
  {
    openXmlElement.Top = value;
  }
  
  /// <summary>
  /// r, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetRight(DocumentFormat.OpenXml.Office2010.Word.FillToRectangle openXmlElement)
  {
    return openXmlElement.Right?.Value;
  }
  
  private static void SetRight(DocumentFormat.OpenXml.Office2010.Word.FillToRectangle openXmlElement, Int32? value)
  {
    openXmlElement.Right = value;
  }
  
  /// <summary>
  /// b, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetBottom(DocumentFormat.OpenXml.Office2010.Word.FillToRectangle openXmlElement)
  {
    return openXmlElement.Bottom?.Value;
  }
  
  private static void SetBottom(DocumentFormat.OpenXml.Office2010.Word.FillToRectangle openXmlElement, Int32? value)
  {
    openXmlElement.Bottom = value;
  }
  
  public static DocumentModel.Wordprocessing.FillToRectangle? CreateModelElement(DocumentFormat.OpenXml.Office2010.Word.FillToRectangle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.FillToRectangle();
      value.Left = GetLeft(openXmlElement);
      value.Top = GetTop(openXmlElement);
      value.Right = GetRight(openXmlElement);
      value.Bottom = GetBottom(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.FillToRectangle? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Word.FillToRectangle, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLeft(openXmlElement, value?.Left);
      SetTop(openXmlElement, value?.Top);
      SetRight(openXmlElement, value?.Right);
      SetBottom(openXmlElement, value?.Bottom);
      return openXmlElement;
    }
    return default;
  }
}
