namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the LineSketchTypeProperties Class.
/// </summary>
public static class LineSketchTypePropertiesConverter
{
  /// <summary>
  /// LineSketchNoneEmpty.
  /// </summary>
  private static Boolean? GetLineSketchNoneEmpty(DXO21DSS.LineSketchTypeProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO21DSS.LineSketchNoneEmpty>() != null;
  }
  
  private static bool CmpLineSketchNoneEmpty(DXO21DSS.LineSketchTypeProperties openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXO21DSS.LineSketchNoneEmpty>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO21DSS.LineSketchNoneEmpty", val, value);
    return false;
  }
  
  private static void SetLineSketchNoneEmpty(DXO21DSS.LineSketchTypeProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO21DSS.LineSketchNoneEmpty>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO21DSS.LineSketchNoneEmpty();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// LineSketchCurvedEmpty.
  /// </summary>
  private static Boolean? GetLineSketchCurvedEmpty(DXO21DSS.LineSketchTypeProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO21DSS.LineSketchCurvedEmpty>() != null;
  }
  
  private static bool CmpLineSketchCurvedEmpty(DXO21DSS.LineSketchTypeProperties openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXO21DSS.LineSketchCurvedEmpty>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO21DSS.LineSketchCurvedEmpty", val, value);
    return false;
  }
  
  private static void SetLineSketchCurvedEmpty(DXO21DSS.LineSketchTypeProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO21DSS.LineSketchCurvedEmpty>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO21DSS.LineSketchCurvedEmpty();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// LineSketchFreehandEmpty.
  /// </summary>
  private static Boolean? GetLineSketchFreehandEmpty(DXO21DSS.LineSketchTypeProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO21DSS.LineSketchFreehandEmpty>() != null;
  }
  
  private static bool CmpLineSketchFreehandEmpty(DXO21DSS.LineSketchTypeProperties openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXO21DSS.LineSketchFreehandEmpty>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO21DSS.LineSketchFreehandEmpty", val, value);
    return false;
  }
  
  private static void SetLineSketchFreehandEmpty(DXO21DSS.LineSketchTypeProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO21DSS.LineSketchFreehandEmpty>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO21DSS.LineSketchFreehandEmpty();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// LineSketchScribbleEmpty.
  /// </summary>
  private static Boolean? GetLineSketchScribbleEmpty(DXO21DSS.LineSketchTypeProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO21DSS.LineSketchScribbleEmpty>() != null;
  }
  
  private static bool CmpLineSketchScribbleEmpty(DXO21DSS.LineSketchTypeProperties openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXO21DSS.LineSketchScribbleEmpty>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO21DSS.LineSketchScribbleEmpty", val, value);
    return false;
  }
  
  private static void SetLineSketchScribbleEmpty(DXO21DSS.LineSketchTypeProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO21DSS.LineSketchScribbleEmpty>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO21DSS.LineSketchScribbleEmpty();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.LineSketchTypeProperties? CreateModelElement(DXO21DSS.LineSketchTypeProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.LineSketchTypeProperties();
      value.LineSketchNoneEmpty = GetLineSketchNoneEmpty(openXmlElement);
      value.LineSketchCurvedEmpty = GetLineSketchCurvedEmpty(openXmlElement);
      value.LineSketchFreehandEmpty = GetLineSketchFreehandEmpty(openXmlElement);
      value.LineSketchScribbleEmpty = GetLineSketchScribbleEmpty(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO21DSS.LineSketchTypeProperties? openXmlElement, DMD.LineSketchTypeProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLineSketchNoneEmpty(openXmlElement, value.LineSketchNoneEmpty, diffs, objName, propName))
        ok = false;
      if (!CmpLineSketchCurvedEmpty(openXmlElement, value.LineSketchCurvedEmpty, diffs, objName, propName))
        ok = false;
      if (!CmpLineSketchFreehandEmpty(openXmlElement, value.LineSketchFreehandEmpty, diffs, objName, propName))
        ok = false;
      if (!CmpLineSketchScribbleEmpty(openXmlElement, value.LineSketchScribbleEmpty, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.LineSketchTypeProperties value)
    where OpenXmlElementType: DXO21DSS.LineSketchTypeProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO21DSS.LineSketchTypeProperties openXmlElement, DMD.LineSketchTypeProperties value)
  {
    SetLineSketchNoneEmpty(openXmlElement, value?.LineSketchNoneEmpty);
    SetLineSketchCurvedEmpty(openXmlElement, value?.LineSketchCurvedEmpty);
    SetLineSketchFreehandEmpty(openXmlElement, value?.LineSketchFreehandEmpty);
    SetLineSketchScribbleEmpty(openXmlElement, value?.LineSketchScribbleEmpty);
  }
}
