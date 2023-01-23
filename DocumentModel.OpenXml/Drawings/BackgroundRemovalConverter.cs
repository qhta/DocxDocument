namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the BackgroundRemoval Class.
/// </summary>
public static class BackgroundRemovalConverter
{
  /// <summary>
  /// t, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetMarqueeTop(DXO2010Draw.BackgroundRemoval openXmlElement)
  {
    return openXmlElement.MarqueeTop?.Value;
  }
  
  private static bool CmpMarqueeTop(DXO2010Draw.BackgroundRemoval openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.MarqueeTop?.Value == value;
  }
  
  private static void SetMarqueeTop(DXO2010Draw.BackgroundRemoval openXmlElement, Int32? value)
  {
    openXmlElement.MarqueeTop = value;
  }
  
  /// <summary>
  /// b, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetMarqueeBottom(DXO2010Draw.BackgroundRemoval openXmlElement)
  {
    return openXmlElement.MarqueeBottom?.Value;
  }
  
  private static bool CmpMarqueeBottom(DXO2010Draw.BackgroundRemoval openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.MarqueeBottom?.Value == value;
  }
  
  private static void SetMarqueeBottom(DXO2010Draw.BackgroundRemoval openXmlElement, Int32? value)
  {
    openXmlElement.MarqueeBottom = value;
  }
  
  /// <summary>
  /// l, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetMarqueeLeft(DXO2010Draw.BackgroundRemoval openXmlElement)
  {
    return openXmlElement.MarqueeLeft?.Value;
  }
  
  private static bool CmpMarqueeLeft(DXO2010Draw.BackgroundRemoval openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.MarqueeLeft?.Value == value;
  }
  
  private static void SetMarqueeLeft(DXO2010Draw.BackgroundRemoval openXmlElement, Int32? value)
  {
    openXmlElement.MarqueeLeft = value;
  }
  
  /// <summary>
  /// r, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetMarqueeRight(DXO2010Draw.BackgroundRemoval openXmlElement)
  {
    return openXmlElement.MarqueeRight?.Value;
  }
  
  private static bool CmpMarqueeRight(DXO2010Draw.BackgroundRemoval openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.MarqueeRight?.Value == value;
  }
  
  private static void SetMarqueeRight(DXO2010Draw.BackgroundRemoval openXmlElement, Int32? value)
  {
    openXmlElement.MarqueeRight = value;
  }
  
  private static Collection<DMDraws.ForegroundMark> GetForegroundMarks(DXO2010Draw.BackgroundRemoval openXmlElement)
  {
    var collection = new Collection<DMDraws.ForegroundMark>();
    foreach (var item in openXmlElement.Elements<DXO2010Draw.ForegroundMark>())
    {
      var newItem = DMXDraws.ForegroundMarkConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpForegroundMarks(DXO2010Draw.BackgroundRemoval openXmlElement, Collection<DMDraws.ForegroundMark>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXO2010Draw.ForegroundMark>();
      var origElementsCount = origElements.Count();
      var modelElementsCount = value.Count();
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().ToString()+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXDraws.ForegroundMarkConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  private static void SetForegroundMarks(DXO2010Draw.BackgroundRemoval openXmlElement, Collection<DMDraws.ForegroundMark>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2010Draw.ForegroundMark>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDraws.ForegroundMarkConverter.CreateOpenXmlElement<DXO2010Draw.ForegroundMark>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static Collection<DMDraws.BackgroundMark> GetBackgroundMarks(DXO2010Draw.BackgroundRemoval openXmlElement)
  {
    var collection = new Collection<DMDraws.BackgroundMark>();
    foreach (var item in openXmlElement.Elements<DXO2010Draw.BackgroundMark>())
    {
      var newItem = DMXDraws.BackgroundMarkConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpBackgroundMarks(DXO2010Draw.BackgroundRemoval openXmlElement, Collection<DMDraws.BackgroundMark>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXO2010Draw.BackgroundMark>();
      var origElementsCount = origElements.Count();
      var modelElementsCount = value.Count();
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().ToString()+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXDraws.BackgroundMarkConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  private static void SetBackgroundMarks(DXO2010Draw.BackgroundRemoval openXmlElement, Collection<DMDraws.BackgroundMark>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2010Draw.BackgroundMark>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDraws.BackgroundMarkConverter.CreateOpenXmlElement<DXO2010Draw.BackgroundMark>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDraws.BackgroundRemoval? CreateModelElement(DXO2010Draw.BackgroundRemoval? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.BackgroundRemoval();
      value.MarqueeTop = GetMarqueeTop(openXmlElement);
      value.MarqueeBottom = GetMarqueeBottom(openXmlElement);
      value.MarqueeLeft = GetMarqueeLeft(openXmlElement);
      value.MarqueeRight = GetMarqueeRight(openXmlElement);
      value.ForegroundMarks = GetForegroundMarks(openXmlElement);
      value.BackgroundMarks = GetBackgroundMarks(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010Draw.BackgroundRemoval? openXmlElement, DMDraws.BackgroundRemoval? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpMarqueeTop(openXmlElement, value.MarqueeTop, diffs, objName))
        ok = false;
      if (!CmpMarqueeBottom(openXmlElement, value.MarqueeBottom, diffs, objName))
        ok = false;
      if (!CmpMarqueeLeft(openXmlElement, value.MarqueeLeft, diffs, objName))
        ok = false;
      if (!CmpMarqueeRight(openXmlElement, value.MarqueeRight, diffs, objName))
        ok = false;
      if (!CmpForegroundMarks(openXmlElement, value.ForegroundMarks, diffs, objName))
        ok = false;
      if (!CmpBackgroundMarks(openXmlElement, value.BackgroundMarks, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.BackgroundRemoval? value)
    where OpenXmlElementType: DXO2010Draw.BackgroundRemoval, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetMarqueeTop(openXmlElement, value?.MarqueeTop);
      SetMarqueeBottom(openXmlElement, value?.MarqueeBottom);
      SetMarqueeLeft(openXmlElement, value?.MarqueeLeft);
      SetMarqueeRight(openXmlElement, value?.MarqueeRight);
      SetForegroundMarks(openXmlElement, value?.ForegroundMarks);
      SetBackgroundMarks(openXmlElement, value?.BackgroundMarks);
      return openXmlElement;
    }
    return default;
  }
}
