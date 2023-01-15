using DocumentFormat.OpenXml.Drawing.ChartDrawing;
using DocumentModel.Drawings;
using NonVisualGraphicFrameProperties = DocumentModel.Drawings.ChartDrawing.NonVisualGraphicFrameProperties;
using Transform = DocumentModel.Drawings.ChartDrawing.Transform;

namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
///   Graphic Frame.
/// </summary>
public static class GraphicFrameConverter
{
  /// <summary>
  ///   Reference to Custom Function
  /// </summary>
  public static String? GetMacro(GraphicFrame? openXmlElement)
  {
    return openXmlElement?.Macro?.Value;
  }

  public static void SetMacro(GraphicFrame? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Macro = new StringValue { Value = value };
      else
        openXmlElement.Macro = null;
  }

  /// <summary>
  ///   Publish To Server
  /// </summary>
  public static Boolean? GetPublished(GraphicFrame? openXmlElement)
  {
    return openXmlElement?.Published?.Value;
  }

  public static void SetPublished(GraphicFrame? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Published = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Published = null;
  }

  /// <summary>
  ///   Non-Visual Graphic Frame Properties.
  /// </summary>
  public static NonVisualGraphicFrameProperties? GetNonVisualGraphicFrameProperties(GraphicFrame? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGraphicFrameProperties>();
    if (itemElement != null)
      return NonVisualGraphicFramePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNonVisualGraphicFrameProperties(GraphicFrame? openXmlElement, NonVisualGraphicFrameProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGraphicFrameProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NonVisualGraphicFramePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGraphicFrameProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Graphic Frame Transform.
  /// </summary>
  public static Transform? GetTransform(GraphicFrame? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.Transform>();
    if (itemElement != null)
      return TransformConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTransform(GraphicFrame? openXmlElement, Transform? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.Transform>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TransformConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.Transform>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Graphical Object.
  /// </summary>
  public static Graphic? GetGraphic(GraphicFrame? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Graphic>();
    if (itemElement != null)
      return GraphicConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetGraphic(GraphicFrame? openXmlElement, Graphic? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Graphic>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GraphicConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Graphic>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ChartDrawing.GraphicFrame? CreateModelElement(GraphicFrame? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawing.GraphicFrame();
      value.Macro = GetMacro(openXmlElement);
      value.Published = GetPublished(openXmlElement);
      value.NonVisualGraphicFrameProperties = GetNonVisualGraphicFrameProperties(openXmlElement);
      value.Transform = GetTransform(openXmlElement);
      value.Graphic = GetGraphic(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawing.GraphicFrame? value)
    where OpenXmlElementType : GraphicFrame, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetMacro(openXmlElement, value?.Macro);
      SetPublished(openXmlElement, value?.Published);
      SetNonVisualGraphicFrameProperties(openXmlElement, value?.NonVisualGraphicFrameProperties);
      SetTransform(openXmlElement, value?.Transform);
      SetGraphic(openXmlElement, value?.Graphic);
      return openXmlElement;
    }
    return default;
  }
}