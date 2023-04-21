namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the BackgroundRemoval Class.
/// </summary>
public static class BackgroundRemovalConverter
{
  /// <summary>
  /// t, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetMarqueeTop(DXO10D.BackgroundRemoval openXmlElement)
  {
    return openXmlElement?.MarqueeTop?.Value;
  }
  
  private static bool CmpMarqueeTop(DXO10D.BackgroundRemoval openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.MarqueeTop?.Value == value) return true;
    diffs?.Add(objName, "MarqueeTop", openXmlElement?.MarqueeTop?.Value, value);
    return false;
  }
  
  private static void SetMarqueeTop(DXO10D.BackgroundRemoval openXmlElement, Int32? value)
  {
    openXmlElement.MarqueeTop = value;
  }
  
  /// <summary>
  /// b, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetMarqueeBottom(DXO10D.BackgroundRemoval openXmlElement)
  {
    return openXmlElement?.MarqueeBottom?.Value;
  }
  
  private static bool CmpMarqueeBottom(DXO10D.BackgroundRemoval openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.MarqueeBottom?.Value == value) return true;
    diffs?.Add(objName, "MarqueeBottom", openXmlElement?.MarqueeBottom?.Value, value);
    return false;
  }
  
  private static void SetMarqueeBottom(DXO10D.BackgroundRemoval openXmlElement, Int32? value)
  {
    openXmlElement.MarqueeBottom = value;
  }
  
  /// <summary>
  /// l, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetMarqueeLeft(DXO10D.BackgroundRemoval openXmlElement)
  {
    return openXmlElement?.MarqueeLeft?.Value;
  }
  
  private static bool CmpMarqueeLeft(DXO10D.BackgroundRemoval openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.MarqueeLeft?.Value == value) return true;
    diffs?.Add(objName, "MarqueeLeft", openXmlElement?.MarqueeLeft?.Value, value);
    return false;
  }
  
  private static void SetMarqueeLeft(DXO10D.BackgroundRemoval openXmlElement, Int32? value)
  {
    openXmlElement.MarqueeLeft = value;
  }
  
  /// <summary>
  /// r, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetMarqueeRight(DXO10D.BackgroundRemoval openXmlElement)
  {
    return openXmlElement?.MarqueeRight?.Value;
  }
  
  private static bool CmpMarqueeRight(DXO10D.BackgroundRemoval openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.MarqueeRight?.Value == value) return true;
    diffs?.Add(objName, "MarqueeRight", openXmlElement?.MarqueeRight?.Value, value);
    return false;
  }
  
  private static void SetMarqueeRight(DXO10D.BackgroundRemoval openXmlElement, Int32? value)
  {
    openXmlElement.MarqueeRight = value;
  }
  
  private static Collection<DMD.ForegroundMark>? GetForegroundMarks(DXO10D.BackgroundRemoval openXmlElement)
  {
    var collection = new Collection<DMD.ForegroundMark>();
    foreach (var item in openXmlElement.Elements<DXO10D.ForegroundMark>())
    {
      var newItem = DMXD.ForegroundMarkConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpForegroundMarks(DXO10D.BackgroundRemoval openXmlElement, Collection<DMD.ForegroundMark>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXO10D.ForegroundMark>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXD.ForegroundMarkConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetForegroundMarks(DXO10D.BackgroundRemoval openXmlElement, Collection<DMD.ForegroundMark>? value)
  {
    openXmlElement.RemoveAllChildren<DXO10D.ForegroundMark>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXD.ForegroundMarkConverter.CreateOpenXmlElement<DXO10D.ForegroundMark>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static Collection<DMD.BackgroundMark>? GetBackgroundMarks(DXO10D.BackgroundRemoval openXmlElement)
  {
    var collection = new Collection<DMD.BackgroundMark>();
    foreach (var item in openXmlElement.Elements<DXO10D.BackgroundMark>())
    {
      var newItem = DMXD.BackgroundMarkConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpBackgroundMarks(DXO10D.BackgroundRemoval openXmlElement, Collection<DMD.BackgroundMark>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXO10D.BackgroundMark>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXD.BackgroundMarkConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetBackgroundMarks(DXO10D.BackgroundRemoval openXmlElement, Collection<DMD.BackgroundMark>? value)
  {
    openXmlElement.RemoveAllChildren<DXO10D.BackgroundMark>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXD.BackgroundMarkConverter.CreateOpenXmlElement<DXO10D.BackgroundMark>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.BackgroundRemoval? CreateModelElement(DXO10D.BackgroundRemoval? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.BackgroundRemoval();
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
  
  public static bool CompareModelElement(DXO10D.BackgroundRemoval? openXmlElement, DMD.BackgroundRemoval? value, DiffList? diffs, string? objName)
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
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.BackgroundRemoval value)
    where OpenXmlElementType: DXO10D.BackgroundRemoval, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10D.BackgroundRemoval openXmlElement, DMD.BackgroundRemoval value)
  {
    SetMarqueeTop(openXmlElement, value?.MarqueeTop);
    SetMarqueeBottom(openXmlElement, value?.MarqueeBottom);
    SetMarqueeLeft(openXmlElement, value?.MarqueeLeft);
    SetMarqueeRight(openXmlElement, value?.MarqueeRight);
    SetForegroundMarks(openXmlElement, value?.ForegroundMarks);
    SetBackgroundMarks(openXmlElement, value?.BackgroundMarks);
  }
}
