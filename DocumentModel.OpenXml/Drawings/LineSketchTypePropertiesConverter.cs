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
    var itemElement = openXmlElement.GetFirstChild<DXO2021DrawSketchyShps.LineSketchNoneEmpty>();
    return itemElement != null;
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
    var itemElement = openXmlElement.GetFirstChild<DXO2021DrawSketchyShps.LineSketchCurvedEmpty>();
    return itemElement != null;
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
    var itemElement = openXmlElement.GetFirstChild<DXO2021DrawSketchyShps.LineSketchFreehandEmpty>();
    return itemElement != null;
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
    var itemElement = openXmlElement.GetFirstChild<DXO2021DrawSketchyShps.LineSketchScribbleEmpty>();
    return itemElement != null;
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
