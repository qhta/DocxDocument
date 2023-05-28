namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the BackgroundMark Class.
/// </summary>
public static class BackgroundMarkConverter
{
  /// <summary>
  /// x1, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetFirstXCoordinate(DXO10D.BackgroundMark openXmlElement)
  {
    return openXmlElement?.FirstXCoordinate?.Value;
  }
  
  private static bool CmpFirstXCoordinate(DXO10D.BackgroundMark openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.FirstXCoordinate?.Value == value) return true;
    diffs?.Add(objName, "FirstXCoordinate", openXmlElement?.FirstXCoordinate?.Value, value);
    return false;
  }
  
  private static void SetFirstXCoordinate(DXO10D.BackgroundMark openXmlElement, Int32? value)
  {
    openXmlElement.FirstXCoordinate = value;
  }
  
  /// <summary>
  /// y1, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetFirstYCoordinate(DXO10D.BackgroundMark openXmlElement)
  {
    return openXmlElement?.FirstYCoordinate?.Value;
  }
  
  private static bool CmpFirstYCoordinate(DXO10D.BackgroundMark openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.FirstYCoordinate?.Value == value) return true;
    diffs?.Add(objName, "FirstYCoordinate", openXmlElement?.FirstYCoordinate?.Value, value);
    return false;
  }
  
  private static void SetFirstYCoordinate(DXO10D.BackgroundMark openXmlElement, Int32? value)
  {
    openXmlElement.FirstYCoordinate = value;
  }
  
  /// <summary>
  /// x2, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetSecondXCoordinate(DXO10D.BackgroundMark openXmlElement)
  {
    return openXmlElement?.SecondXCoordinate?.Value;
  }
  
  private static bool CmpSecondXCoordinate(DXO10D.BackgroundMark openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.SecondXCoordinate?.Value == value) return true;
    diffs?.Add(objName, "SecondXCoordinate", openXmlElement?.SecondXCoordinate?.Value, value);
    return false;
  }
  
  private static void SetSecondXCoordinate(DXO10D.BackgroundMark openXmlElement, Int32? value)
  {
    openXmlElement.SecondXCoordinate = value;
  }
  
  /// <summary>
  /// y2, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetSecondYCoordinate(DXO10D.BackgroundMark openXmlElement)
  {
    return openXmlElement?.SecondYCoordinate?.Value;
  }
  
  private static bool CmpSecondYCoordinate(DXO10D.BackgroundMark openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.SecondYCoordinate?.Value == value) return true;
    diffs?.Add(objName, "SecondYCoordinate", openXmlElement?.SecondYCoordinate?.Value, value);
    return false;
  }
  
  private static void SetSecondYCoordinate(DXO10D.BackgroundMark openXmlElement, Int32? value)
  {
    openXmlElement.SecondYCoordinate = value;
  }
  
  public static DMD.BackgroundMark? CreateModelElement(DXO10D.BackgroundMark? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.BackgroundMark();
      value.FirstXCoordinate = GetFirstXCoordinate(openXmlElement);
      value.FirstYCoordinate = GetFirstYCoordinate(openXmlElement);
      value.SecondXCoordinate = GetSecondXCoordinate(openXmlElement);
      value.SecondYCoordinate = GetSecondYCoordinate(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO10D.BackgroundMark? openXmlElement, DMD.BackgroundMark? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpFirstXCoordinate(openXmlElement, value.FirstXCoordinate, diffs, objName, propName))
        ok = false;
      if (!CmpFirstYCoordinate(openXmlElement, value.FirstYCoordinate, diffs, objName, propName))
        ok = false;
      if (!CmpSecondXCoordinate(openXmlElement, value.SecondXCoordinate, diffs, objName, propName))
        ok = false;
      if (!CmpSecondYCoordinate(openXmlElement, value.SecondYCoordinate, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.BackgroundMark value)
    where OpenXmlElementType: DXO10D.BackgroundMark, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10D.BackgroundMark openXmlElement, DMD.BackgroundMark value)
  {
    SetFirstXCoordinate(openXmlElement, value?.FirstXCoordinate);
    SetFirstYCoordinate(openXmlElement, value?.FirstYCoordinate);
    SetSecondXCoordinate(openXmlElement, value?.SecondXCoordinate);
    SetSecondYCoordinate(openXmlElement, value?.SecondYCoordinate);
  }
}
