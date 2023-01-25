namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the LineSketchTypeProperties Class.
/// </summary>
public static class LineSketchTypePropertiesConverter
{
  /// <summary>
  /// LineSketchNoneEmpty.
  /// </summary>
  private static Boolean? GetLineSketchNoneEmpty(DXO2021DrawSketchyShps.LineSketchTypeProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO2021DrawSketchyShps.LineSketchNoneEmpty>() != null;
  }
  
  private static bool CmpLineSketchNoneEmpty(DXO2021DrawSketchyShps.LineSketchTypeProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXO2021DrawSketchyShps.LineSketchNoneEmpty>() != null == value;
  }
  
  private static void SetLineSketchNoneEmpty(DXO2021DrawSketchyShps.LineSketchTypeProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO2021DrawSketchyShps.LineSketchNoneEmpty>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO2021DrawSketchyShps.LineSketchNoneEmpty();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// LineSketchCurvedEmpty.
  /// </summary>
  private static Boolean? GetLineSketchCurvedEmpty(DXO2021DrawSketchyShps.LineSketchTypeProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO2021DrawSketchyShps.LineSketchCurvedEmpty>() != null;
  }
  
  private static bool CmpLineSketchCurvedEmpty(DXO2021DrawSketchyShps.LineSketchTypeProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXO2021DrawSketchyShps.LineSketchCurvedEmpty>() != null == value;
  }
  
  private static void SetLineSketchCurvedEmpty(DXO2021DrawSketchyShps.LineSketchTypeProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO2021DrawSketchyShps.LineSketchCurvedEmpty>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO2021DrawSketchyShps.LineSketchCurvedEmpty();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// LineSketchFreehandEmpty.
  /// </summary>
  private static Boolean? GetLineSketchFreehandEmpty(DXO2021DrawSketchyShps.LineSketchTypeProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO2021DrawSketchyShps.LineSketchFreehandEmpty>() != null;
  }
  
  private static bool CmpLineSketchFreehandEmpty(DXO2021DrawSketchyShps.LineSketchTypeProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXO2021DrawSketchyShps.LineSketchFreehandEmpty>() != null == value;
  }
  
  private static void SetLineSketchFreehandEmpty(DXO2021DrawSketchyShps.LineSketchTypeProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO2021DrawSketchyShps.LineSketchFreehandEmpty>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO2021DrawSketchyShps.LineSketchFreehandEmpty();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// LineSketchScribbleEmpty.
  /// </summary>
  private static Boolean? GetLineSketchScribbleEmpty(DXO2021DrawSketchyShps.LineSketchTypeProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO2021DrawSketchyShps.LineSketchScribbleEmpty>() != null;
  }
  
  private static bool CmpLineSketchScribbleEmpty(DXO2021DrawSketchyShps.LineSketchTypeProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXO2021DrawSketchyShps.LineSketchScribbleEmpty>() != null == value;
  }
  
  private static void SetLineSketchScribbleEmpty(DXO2021DrawSketchyShps.LineSketchTypeProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO2021DrawSketchyShps.LineSketchScribbleEmpty>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO2021DrawSketchyShps.LineSketchScribbleEmpty();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.LineSketchTypeProperties? CreateModelElement(DXO2021DrawSketchyShps.LineSketchTypeProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.LineSketchTypeProperties();
      value.LineSketchNoneEmpty = GetLineSketchNoneEmpty(openXmlElement);
      value.LineSketchCurvedEmpty = GetLineSketchCurvedEmpty(openXmlElement);
      value.LineSketchFreehandEmpty = GetLineSketchFreehandEmpty(openXmlElement);
      value.LineSketchScribbleEmpty = GetLineSketchScribbleEmpty(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2021DrawSketchyShps.LineSketchTypeProperties? openXmlElement, DMDraws.LineSketchTypeProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLineSketchNoneEmpty(openXmlElement, value.LineSketchNoneEmpty, diffs, objName))
        ok = false;
      if (!CmpLineSketchCurvedEmpty(openXmlElement, value.LineSketchCurvedEmpty, diffs, objName))
        ok = false;
      if (!CmpLineSketchFreehandEmpty(openXmlElement, value.LineSketchFreehandEmpty, diffs, objName))
        ok = false;
      if (!CmpLineSketchScribbleEmpty(openXmlElement, value.LineSketchScribbleEmpty, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.LineSketchTypeProperties? value)
    where OpenXmlElementType: DXO2021DrawSketchyShps.LineSketchTypeProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLineSketchNoneEmpty(openXmlElement, value?.LineSketchNoneEmpty);
      SetLineSketchCurvedEmpty(openXmlElement, value?.LineSketchCurvedEmpty);
      SetLineSketchFreehandEmpty(openXmlElement, value?.LineSketchFreehandEmpty);
      SetLineSketchScribbleEmpty(openXmlElement, value?.LineSketchScribbleEmpty);
      return openXmlElement;
    }
    return default;
  }
}
