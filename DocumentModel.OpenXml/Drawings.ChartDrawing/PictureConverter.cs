using DocumentFormat.OpenXml.Drawing.ChartDrawing;
using BlipFill = DocumentModel.Drawings.ChartDrawing.BlipFill;
using NonVisualPictureProperties = DocumentModel.Drawings.ChartDrawing.NonVisualPictureProperties;
using ShapeProperties = DocumentModel.Drawings.ChartDrawing.ShapeProperties;
using Style = DocumentModel.Drawings.ChartDrawing.Style;

namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
///   Defines the Picture Class.
/// </summary>
public static class PictureConverter
{
  /// <summary>
  ///   Reference to Custom Function
  /// </summary>
  public static String? GetMacro(Picture? openXmlElement)
  {
    return openXmlElement?.Macro?.Value;
  }

  public static void SetMacro(Picture? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Macro = new StringValue { Value = value };
      else
        openXmlElement.Macro = null;
  }

  /// <summary>
  ///   Publish to Server
  /// </summary>
  public static Boolean? GetPublished(Picture? openXmlElement)
  {
    return openXmlElement?.Published?.Value;
  }

  public static void SetPublished(Picture? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Published = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Published = null;
  }

  /// <summary>
  ///   Non-Visual Picture Properties.
  /// </summary>
  public static NonVisualPictureProperties? GetNonVisualPictureProperties(Picture? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualPictureProperties>();
    if (itemElement != null)
      return NonVisualPicturePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNonVisualPictureProperties(Picture? openXmlElement, NonVisualPictureProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualPictureProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NonVisualPicturePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualPictureProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Picture Fill.
  /// </summary>
  public static BlipFill? GetBlipFill(Picture? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.BlipFill>();
    if (itemElement != null)
      return BlipFillConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBlipFill(Picture? openXmlElement, BlipFill? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.BlipFill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BlipFillConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.BlipFill>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  public static ShapeProperties? GetShapeProperties(Picture? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.ShapeProperties>();
    if (itemElement != null)
      return ShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShapeProperties(Picture? openXmlElement, ShapeProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.ShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.ShapeProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Style.
  /// </summary>
  public static Style? GetStyle(Picture? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.Style>();
    if (itemElement != null)
      return StyleConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetStyle(Picture? openXmlElement, Style? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.Style>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StyleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.Style>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ChartDrawing.Picture? CreateModelElement(Picture? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawing.Picture();
      value.Macro = GetMacro(openXmlElement);
      value.Published = GetPublished(openXmlElement);
      value.NonVisualPictureProperties = GetNonVisualPictureProperties(openXmlElement);
      value.BlipFill = GetBlipFill(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.Style = GetStyle(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawing.Picture? value)
    where OpenXmlElementType : Picture, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetMacro(openXmlElement, value?.Macro);
      SetPublished(openXmlElement, value?.Published);
      SetNonVisualPictureProperties(openXmlElement, value?.NonVisualPictureProperties);
      SetBlipFill(openXmlElement, value?.BlipFill);
      SetShapeProperties(openXmlElement, value?.ShapeProperties);
      SetStyle(openXmlElement, value?.Style);
      return openXmlElement;
    }
    return default;
  }
}