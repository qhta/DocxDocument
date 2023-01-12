namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ForegroundMark Class.
/// </summary>
public static class ForegroundMarkConverter
{
  /// <summary>
  /// x1, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetFirstXCoordinate(DocumentFormat.OpenXml.Office2010.Drawing.ForegroundMark? openXmlElement)
  {
    return openXmlElement?.FirstXCoordinate?.Value;
  }
  
  public static void SetFirstXCoordinate(DocumentFormat.OpenXml.Office2010.Drawing.ForegroundMark? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.FirstXCoordinate = value;
  }
  
  /// <summary>
  /// y1, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetFirstYCoordinate(DocumentFormat.OpenXml.Office2010.Drawing.ForegroundMark? openXmlElement)
  {
    return openXmlElement?.FirstYCoordinate?.Value;
  }
  
  public static void SetFirstYCoordinate(DocumentFormat.OpenXml.Office2010.Drawing.ForegroundMark? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.FirstYCoordinate = value;
  }
  
  /// <summary>
  /// x2, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetSecondXCoordinate(DocumentFormat.OpenXml.Office2010.Drawing.ForegroundMark? openXmlElement)
  {
    return openXmlElement?.SecondXCoordinate?.Value;
  }
  
  public static void SetSecondXCoordinate(DocumentFormat.OpenXml.Office2010.Drawing.ForegroundMark? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.SecondXCoordinate = value;
  }
  
  /// <summary>
  /// y2, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetSecondYCoordinate(DocumentFormat.OpenXml.Office2010.Drawing.ForegroundMark? openXmlElement)
  {
    return openXmlElement?.SecondYCoordinate?.Value;
  }
  
  public static void SetSecondYCoordinate(DocumentFormat.OpenXml.Office2010.Drawing.ForegroundMark? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.SecondYCoordinate = value;
  }
  
  public static DocumentModel.Drawings.ForegroundMark? CreateModelElement(DocumentFormat.OpenXml.Office2010.Drawing.ForegroundMark? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ForegroundMark();
      value.FirstXCoordinate = GetFirstXCoordinate(openXmlElement);
      value.FirstYCoordinate = GetFirstYCoordinate(openXmlElement);
      value.SecondXCoordinate = GetSecondXCoordinate(openXmlElement);
      value.SecondYCoordinate = GetSecondYCoordinate(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ForegroundMark? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Drawing.ForegroundMark, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFirstXCoordinate(openXmlElement, value?.FirstXCoordinate);
      SetFirstYCoordinate(openXmlElement, value?.FirstYCoordinate);
      SetSecondXCoordinate(openXmlElement, value?.SecondXCoordinate);
      SetSecondYCoordinate(openXmlElement, value?.SecondYCoordinate);
      return openXmlElement;
    }
    return default;
  }
}
