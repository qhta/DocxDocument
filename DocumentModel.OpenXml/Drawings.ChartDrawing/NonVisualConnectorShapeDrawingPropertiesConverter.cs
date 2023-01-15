using DocumentModel.Drawings.ChartDrawing;
using NonVisualConnectorShapeDrawingProperties = DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualConnectorShapeDrawingProperties;

namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
///   Connector Non Visual Properties.
/// </summary>
public static class NonVisualConnectorShapeDrawingPropertiesConverter
{
  /// <summary>
  ///   Chart Non Visual Properties.
  /// </summary>
  public static NonVisualDrawingProperties? GetNonVisualDrawingProperties(NonVisualConnectorShapeDrawingProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties>();
    if (itemElement != null)
      return NonVisualDrawingPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNonVisualDrawingProperties(NonVisualConnectorShapeDrawingProperties? openXmlElement, NonVisualDrawingProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NonVisualDrawingPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Non-Visual Connection Shape Drawing Properties.
  /// </summary>
  public static NonVisualConnectionShapeProperties? GetNonVisualConnectionShapeProperties(NonVisualConnectorShapeDrawingProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualConnectionShapeProperties>();
    if (itemElement != null)
      return NonVisualConnectionShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNonVisualConnectionShapeProperties(NonVisualConnectorShapeDrawingProperties? openXmlElement, NonVisualConnectionShapeProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualConnectionShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NonVisualConnectionShapePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualConnectionShapeProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ChartDrawing.NonVisualConnectorShapeDrawingProperties? CreateModelElement(NonVisualConnectorShapeDrawingProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawing.NonVisualConnectorShapeDrawingProperties();
      value.NonVisualDrawingProperties = GetNonVisualDrawingProperties(openXmlElement);
      value.NonVisualConnectionShapeProperties = GetNonVisualConnectionShapeProperties(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawing.NonVisualConnectorShapeDrawingProperties? value)
    where OpenXmlElementType : NonVisualConnectorShapeDrawingProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNonVisualDrawingProperties(openXmlElement, value?.NonVisualDrawingProperties);
      SetNonVisualConnectionShapeProperties(openXmlElement, value?.NonVisualConnectionShapeProperties);
      return openXmlElement;
    }
    return default;
  }
}