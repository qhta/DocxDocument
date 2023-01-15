using DocumentFormat.OpenXml.Drawing.ChartDrawing;
using NonVisualConnectorShapeDrawingProperties = DocumentModel.Drawings.ChartDrawing.NonVisualConnectorShapeDrawingProperties;
using ShapeProperties = DocumentModel.Drawings.ChartDrawing.ShapeProperties;
using Style = DocumentModel.Drawings.ChartDrawing.Style;

namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
///   Connection Shape.
/// </summary>
public static class ConnectionShapeConverter
{
  /// <summary>
  ///   Reference to Custom Function
  /// </summary>
  public static String? GetMacro(ConnectionShape? openXmlElement)
  {
    return openXmlElement?.Macro?.Value;
  }

  public static void SetMacro(ConnectionShape? openXmlElement, String? value)
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
  public static Boolean? GetPublished(ConnectionShape? openXmlElement)
  {
    return openXmlElement?.Published?.Value;
  }

  public static void SetPublished(ConnectionShape? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Published = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Published = null;
  }

  /// <summary>
  ///   Connector Non Visual Properties.
  /// </summary>
  public static NonVisualConnectorShapeDrawingProperties? GetNonVisualConnectorShapeDrawingProperties(ConnectionShape? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualConnectorShapeDrawingProperties>();
    if (itemElement != null)
      return NonVisualConnectorShapeDrawingPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNonVisualConnectorShapeDrawingProperties(ConnectionShape? openXmlElement, NonVisualConnectorShapeDrawingProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualConnectorShapeDrawingProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NonVisualConnectorShapeDrawingPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualConnectorShapeDrawingProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Shape Properties.
  /// </summary>
  public static ShapeProperties? GetShapeProperties(ConnectionShape? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.ShapeProperties>();
    if (itemElement != null)
      return ShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShapeProperties(ConnectionShape? openXmlElement, ShapeProperties? value)
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
  ///   Connection Shape Style.
  /// </summary>
  public static Style? GetStyle(ConnectionShape? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.Style>();
    if (itemElement != null)
      return StyleConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetStyle(ConnectionShape? openXmlElement, Style? value)
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

  public static DocumentModel.Drawings.ChartDrawing.ConnectionShape? CreateModelElement(ConnectionShape? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawing.ConnectionShape();
      value.Macro = GetMacro(openXmlElement);
      value.Published = GetPublished(openXmlElement);
      value.NonVisualConnectorShapeDrawingProperties = GetNonVisualConnectorShapeDrawingProperties(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.Style = GetStyle(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawing.ConnectionShape? value)
    where OpenXmlElementType : ConnectionShape, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetMacro(openXmlElement, value?.Macro);
      SetPublished(openXmlElement, value?.Published);
      SetNonVisualConnectorShapeDrawingProperties(openXmlElement, value?.NonVisualConnectorShapeDrawingProperties);
      SetShapeProperties(openXmlElement, value?.ShapeProperties);
      SetStyle(openXmlElement, value?.Style);
      return openXmlElement;
    }
    return default;
  }
}