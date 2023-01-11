namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the BackgroundMark Class.
/// </summary>
public static class BackgroundMarkConverter
{
  /// <summary>
  /// x1, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetFirstXCoordinate(DocumentFormat.OpenXml.Office2010.Drawing.BackgroundMark? openXmlElement)
  {
    return openXmlElement?.FirstXCoordinate?.Value;
  }
  
  public static void SetFirstXCoordinate(DocumentFormat.OpenXml.Office2010.Drawing.BackgroundMark? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.FirstXCoordinate = value;
  }
  
  /// <summary>
  /// y1, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetFirstYCoordinate(DocumentFormat.OpenXml.Office2010.Drawing.BackgroundMark? openXmlElement)
  {
    return openXmlElement?.FirstYCoordinate?.Value;
  }
  
  public static void SetFirstYCoordinate(DocumentFormat.OpenXml.Office2010.Drawing.BackgroundMark? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.FirstYCoordinate = value;
  }
  
  /// <summary>
  /// x2, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetSecondXCoordinate(DocumentFormat.OpenXml.Office2010.Drawing.BackgroundMark? openXmlElement)
  {
    return openXmlElement?.SecondXCoordinate?.Value;
  }
  
  public static void SetSecondXCoordinate(DocumentFormat.OpenXml.Office2010.Drawing.BackgroundMark? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.SecondXCoordinate = value;
  }
  
  /// <summary>
  /// y2, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetSecondYCoordinate(DocumentFormat.OpenXml.Office2010.Drawing.BackgroundMark? openXmlElement)
  {
    return openXmlElement?.SecondYCoordinate?.Value;
  }
  
  public static void SetSecondYCoordinate(DocumentFormat.OpenXml.Office2010.Drawing.BackgroundMark? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
