namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the LineSketchTypeProperties Class.
/// </summary>
public static class LineSketchTypePropertiesConverter
{
  /// <summary>
  /// LineSketchNoneEmpty.
  /// </summary>
  private static Boolean? GetLineSketchNoneEmpty(DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchTypeProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchNoneEmpty>();
    return itemElement != null;
  }
  
  private static void SetLineSketchNoneEmpty(DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchTypeProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchNoneEmpty>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchNoneEmpty();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// LineSketchCurvedEmpty.
  /// </summary>
  private static Boolean? GetLineSketchCurvedEmpty(DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchTypeProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchCurvedEmpty>();
    return itemElement != null;
  }
  
  private static void SetLineSketchCurvedEmpty(DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchTypeProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchCurvedEmpty>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchCurvedEmpty();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// LineSketchFreehandEmpty.
  /// </summary>
  private static Boolean? GetLineSketchFreehandEmpty(DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchTypeProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchFreehandEmpty>();
    return itemElement != null;
  }
  
  private static void SetLineSketchFreehandEmpty(DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchTypeProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchFreehandEmpty>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchFreehandEmpty();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// LineSketchScribbleEmpty.
  /// </summary>
  private static Boolean? GetLineSketchScribbleEmpty(DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchTypeProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchScribbleEmpty>();
    return itemElement != null;
  }
  
  private static void SetLineSketchScribbleEmpty(DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchTypeProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchScribbleEmpty>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchScribbleEmpty();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.LineSketchTypeProperties? CreateModelElement(DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchTypeProperties? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.LineSketchTypeProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchTypeProperties, new()
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
