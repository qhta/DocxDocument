namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the BackgroundMark Class.
/// </summary>
public static class BackgroundMarkConverter
{
  /// <summary>
  /// x1, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetFirstXCoordinate(DocumentFormat.OpenXml.Office2010.Drawing.BackgroundMark openXmlElement)
  {
    return openXmlElement.FirstXCoordinate?.Value;
  }
  
  private static void SetFirstXCoordinate(DocumentFormat.OpenXml.Office2010.Drawing.BackgroundMark openXmlElement, Int32? value)
  {
    openXmlElement.FirstXCoordinate = value;
  }
  
  /// <summary>
  /// y1, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetFirstYCoordinate(DocumentFormat.OpenXml.Office2010.Drawing.BackgroundMark openXmlElement)
  {
    return openXmlElement.FirstYCoordinate?.Value;
  }
  
  private static void SetFirstYCoordinate(DocumentFormat.OpenXml.Office2010.Drawing.BackgroundMark openXmlElement, Int32? value)
  {
    openXmlElement.FirstYCoordinate = value;
  }
  
  /// <summary>
  /// x2, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetSecondXCoordinate(DocumentFormat.OpenXml.Office2010.Drawing.BackgroundMark openXmlElement)
  {
    return openXmlElement.SecondXCoordinate?.Value;
  }
  
  private static void SetSecondXCoordinate(DocumentFormat.OpenXml.Office2010.Drawing.BackgroundMark openXmlElement, Int32? value)
  {
    openXmlElement.SecondXCoordinate = value;
  }
  
  /// <summary>
  /// y2, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetSecondYCoordinate(DocumentFormat.OpenXml.Office2010.Drawing.BackgroundMark openXmlElement)
  {
    return openXmlElement.SecondYCoordinate?.Value;
  }
  
  private static void SetSecondYCoordinate(DocumentFormat.OpenXml.Office2010.Drawing.BackgroundMark openXmlElement, Int32? value)
  {
    openXmlElement.SecondYCoordinate = value;
  }
  
  public static DocumentModel.Drawings.BackgroundMark? CreateModelElement(DocumentFormat.OpenXml.Office2010.Drawing.BackgroundMark? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.BackgroundMark();
      value.FirstXCoordinate = GetFirstXCoordinate(openXmlElement);
      value.FirstYCoordinate = GetFirstYCoordinate(openXmlElement);
      value.SecondXCoordinate = GetSecondXCoordinate(openXmlElement);
      value.SecondYCoordinate = GetSecondYCoordinate(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.BackgroundMark? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Drawing.BackgroundMark, new()
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
