namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the BackgroundMark Class.
/// </summary>
public static class BackgroundMarkConverter
{
  /// <summary>
  /// x1, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetFirstXCoordinate(DXO2010Draw.BackgroundMark openXmlElement)
  {
    return openXmlElement.FirstXCoordinate?.Value;
  }
  
  private static void SetFirstXCoordinate(DXO2010Draw.BackgroundMark openXmlElement, Int32? value)
  {
    openXmlElement.FirstXCoordinate = value;
  }
  
  /// <summary>
  /// y1, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetFirstYCoordinate(DXO2010Draw.BackgroundMark openXmlElement)
  {
    return openXmlElement.FirstYCoordinate?.Value;
  }
  
  private static void SetFirstYCoordinate(DXO2010Draw.BackgroundMark openXmlElement, Int32? value)
  {
    openXmlElement.FirstYCoordinate = value;
  }
  
  /// <summary>
  /// x2, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetSecondXCoordinate(DXO2010Draw.BackgroundMark openXmlElement)
  {
    return openXmlElement.SecondXCoordinate?.Value;
  }
  
  private static void SetSecondXCoordinate(DXO2010Draw.BackgroundMark openXmlElement, Int32? value)
  {
    openXmlElement.SecondXCoordinate = value;
  }
  
  /// <summary>
  /// y2, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetSecondYCoordinate(DXO2010Draw.BackgroundMark openXmlElement)
  {
    return openXmlElement.SecondYCoordinate?.Value;
  }
  
  private static void SetSecondYCoordinate(DXO2010Draw.BackgroundMark openXmlElement, Int32? value)
  {
    openXmlElement.SecondYCoordinate = value;
  }
  
  public static DMDraws.BackgroundMark? CreateModelElement(DXO2010Draw.BackgroundMark? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.BackgroundMark();
      value.FirstXCoordinate = GetFirstXCoordinate(openXmlElement);
      value.FirstYCoordinate = GetFirstYCoordinate(openXmlElement);
      value.SecondXCoordinate = GetSecondXCoordinate(openXmlElement);
      value.SecondYCoordinate = GetSecondYCoordinate(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.BackgroundMark? value)
    where OpenXmlElementType: DXO2010Draw.BackgroundMark, new()
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
