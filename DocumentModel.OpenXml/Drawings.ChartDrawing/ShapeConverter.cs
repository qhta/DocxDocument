using DocumentFormat.OpenXml.Drawing.ChartDrawing;
using NonVisualShapeProperties = DocumentModel.Drawings.ChartDrawing.NonVisualShapeProperties;
using ShapeProperties = DocumentModel.Drawings.ChartDrawing.ShapeProperties;
using Style = DocumentModel.Drawings.ChartDrawing.Style;
using TextBody = DocumentModel.Drawings.ChartDrawing.TextBody;

namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
///   Shape Definition.
/// </summary>
public static class ShapeConverter
{
  /// <summary>
  ///   Reference to Custom Function
  /// </summary>
  public static String? GetMacro(Shape? openXmlElement)
  {
    return openXmlElement?.Macro?.Value;
  }

  public static void SetMacro(Shape? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Macro = new StringValue { Value = value };
      else
        openXmlElement.Macro = null;
  }

  /// <summary>
  ///   Text Link
  /// </summary>
  public static String? GetTextLink(Shape? openXmlElement)
  {
    return openXmlElement?.TextLink?.Value;
  }

  public static void SetTextLink(Shape? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.TextLink = new StringValue { Value = value };
      else
        openXmlElement.TextLink = null;
  }

  /// <summary>
  ///   Lock Text
  /// </summary>
  public static Boolean? GetLockText(Shape? openXmlElement)
  {
    return openXmlElement?.LockText?.Value;
  }

  public static void SetLockText(Shape? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.LockText = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.LockText = null;
  }

  /// <summary>
  ///   Publish to Server
  /// </summary>
  public static Boolean? GetPublished(Shape? openXmlElement)
  {
    return openXmlElement?.Published?.Value;
  }

  public static void SetPublished(Shape? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Published = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Published = null;
  }

  /// <summary>
  ///   Non-Visual Shape Properties.
  /// </summary>
  public static NonVisualShapeProperties? GetNonVisualShapeProperties(Shape? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualShapeProperties>();
    if (itemElement != null)
      return NonVisualShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNonVisualShapeProperties(Shape? openXmlElement, NonVisualShapeProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NonVisualShapePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualShapeProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Shape Properties.
  /// </summary>
  public static ShapeProperties? GetShapeProperties(Shape? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.ShapeProperties>();
    if (itemElement != null)
      return ShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShapeProperties(Shape? openXmlElement, ShapeProperties? value)
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
  ///   Shape Style.
  /// </summary>
  public static Style? GetStyle(Shape? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.Style>();
    if (itemElement != null)
      return StyleConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetStyle(Shape? openXmlElement, Style? value)
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

  /// <summary>
  ///   Shape Text Body.
  /// </summary>
  public static TextBody? GetTextBody(Shape? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.TextBody>();
    if (itemElement != null)
      return TextBodyConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTextBody(Shape? openXmlElement, TextBody? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.TextBody>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextBodyConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.TextBody>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ChartDrawing.Shape? CreateModelElement(Shape? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawing.Shape();
      value.Macro = GetMacro(openXmlElement);
      value.TextLink = GetTextLink(openXmlElement);
      value.LockText = GetLockText(openXmlElement);
      value.Published = GetPublished(openXmlElement);
      value.NonVisualShapeProperties = GetNonVisualShapeProperties(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.Style = GetStyle(openXmlElement);
      value.TextBody = GetTextBody(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawing.Shape? value)
    where OpenXmlElementType : Shape, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetMacro(openXmlElement, value?.Macro);
      SetTextLink(openXmlElement, value?.TextLink);
      SetLockText(openXmlElement, value?.LockText);
      SetPublished(openXmlElement, value?.Published);
      SetNonVisualShapeProperties(openXmlElement, value?.NonVisualShapeProperties);
      SetShapeProperties(openXmlElement, value?.ShapeProperties);
      SetStyle(openXmlElement, value?.Style);
      SetTextBody(openXmlElement, value?.TextBody);
      return openXmlElement;
    }
    return default;
  }
}