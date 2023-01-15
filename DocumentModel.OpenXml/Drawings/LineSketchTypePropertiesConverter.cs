using DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the LineSketchTypeProperties Class.
/// </summary>
public static class LineSketchTypePropertiesConverter
{
  /// <summary>
  ///   LineSketchNoneEmpty.
  /// </summary>
  public static Boolean? GetLineSketchNoneEmpty(LineSketchTypeProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LineSketchNoneEmpty>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetLineSketchNoneEmpty(LineSketchTypeProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<LineSketchNoneEmpty>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new LineSketchNoneEmpty();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   LineSketchCurvedEmpty.
  /// </summary>
  public static Boolean? GetLineSketchCurvedEmpty(LineSketchTypeProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LineSketchCurvedEmpty>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetLineSketchCurvedEmpty(LineSketchTypeProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<LineSketchCurvedEmpty>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new LineSketchCurvedEmpty();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   LineSketchFreehandEmpty.
  /// </summary>
  public static Boolean? GetLineSketchFreehandEmpty(LineSketchTypeProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LineSketchFreehandEmpty>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetLineSketchFreehandEmpty(LineSketchTypeProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<LineSketchFreehandEmpty>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new LineSketchFreehandEmpty();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   LineSketchScribbleEmpty.
  /// </summary>
  public static Boolean? GetLineSketchScribbleEmpty(LineSketchTypeProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LineSketchScribbleEmpty>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetLineSketchScribbleEmpty(LineSketchTypeProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<LineSketchScribbleEmpty>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new LineSketchScribbleEmpty();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.LineSketchTypeProperties? CreateModelElement(LineSketchTypeProperties? openXmlElement)
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
    where OpenXmlElementType : LineSketchTypeProperties, new()
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