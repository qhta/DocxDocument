namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ForegroundMark Class.
/// </summary>
public static class ForegroundMarkConverter
{
  /// <summary>
  /// x1, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetFirstXCoordinate(DXO10D.ForegroundMark openXmlElement)
  {
    return openXmlElement?.FirstXCoordinate?.Value;
  }
  
  private static bool CmpFirstXCoordinate(DXO10D.ForegroundMark openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.FirstXCoordinate?.Value == value) return true;
    diffs?.Add(objName, "FirstXCoordinate", openXmlElement?.FirstXCoordinate?.Value, value);
    return false;
  }
  
  private static void SetFirstXCoordinate(DXO10D.ForegroundMark openXmlElement, Int32? value)
  {
    openXmlElement.FirstXCoordinate = value;
  }
  
  /// <summary>
  /// y1, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetFirstYCoordinate(DXO10D.ForegroundMark openXmlElement)
  {
    return openXmlElement?.FirstYCoordinate?.Value;
  }
  
  private static bool CmpFirstYCoordinate(DXO10D.ForegroundMark openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.FirstYCoordinate?.Value == value) return true;
    diffs?.Add(objName, "FirstYCoordinate", openXmlElement?.FirstYCoordinate?.Value, value);
    return false;
  }
  
  private static void SetFirstYCoordinate(DXO10D.ForegroundMark openXmlElement, Int32? value)
  {
    openXmlElement.FirstYCoordinate = value;
  }
  
  /// <summary>
  /// x2, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetSecondXCoordinate(DXO10D.ForegroundMark openXmlElement)
  {
    return openXmlElement?.SecondXCoordinate?.Value;
  }
  
  private static bool CmpSecondXCoordinate(DXO10D.ForegroundMark openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.SecondXCoordinate?.Value == value) return true;
    diffs?.Add(objName, "SecondXCoordinate", openXmlElement?.SecondXCoordinate?.Value, value);
    return false;
  }
  
  private static void SetSecondXCoordinate(DXO10D.ForegroundMark openXmlElement, Int32? value)
  {
    openXmlElement.SecondXCoordinate = value;
  }
  
  /// <summary>
  /// y2, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetSecondYCoordinate(DXO10D.ForegroundMark openXmlElement)
  {
    return openXmlElement?.SecondYCoordinate?.Value;
  }
  
  private static bool CmpSecondYCoordinate(DXO10D.ForegroundMark openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.SecondYCoordinate?.Value == value) return true;
    diffs?.Add(objName, "SecondYCoordinate", openXmlElement?.SecondYCoordinate?.Value, value);
    return false;
  }
  
  private static void SetSecondYCoordinate(DXO10D.ForegroundMark openXmlElement, Int32? value)
  {
    openXmlElement.SecondYCoordinate = value;
  }
  
  public static DocumentModel.Drawings.ForegroundMark? CreateModelElement(DXO10D.ForegroundMark? openXmlElement)
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
  
  public static bool CompareModelElement(DXO10D.ForegroundMark? openXmlElement, DMD.ForegroundMark? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpFirstXCoordinate(openXmlElement, value.FirstXCoordinate, diffs, objName))
        ok = false;
      if (!CmpFirstYCoordinate(openXmlElement, value.FirstYCoordinate, diffs, objName))
        ok = false;
      if (!CmpSecondXCoordinate(openXmlElement, value.SecondXCoordinate, diffs, objName))
        ok = false;
      if (!CmpSecondYCoordinate(openXmlElement, value.SecondYCoordinate, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.ForegroundMark value)
    where OpenXmlElementType: DXO10D.ForegroundMark, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10D.ForegroundMark openXmlElement, DMD.ForegroundMark value)
  {
    SetFirstXCoordinate(openXmlElement, value?.FirstXCoordinate);
    SetFirstYCoordinate(openXmlElement, value?.FirstYCoordinate);
    SetSecondXCoordinate(openXmlElement, value?.SecondXCoordinate);
    SetSecondYCoordinate(openXmlElement, value?.SecondYCoordinate);
  }
}
