using DocumentModel.Drawings.Office;
using GroupShapeNonVisualProperties = DocumentFormat.OpenXml.Office.Drawing.GroupShapeNonVisualProperties;

namespace DocumentModel.OpenXml.Drawings.Office;

/// <summary>
///   Defines the GroupShapeNonVisualProperties Class.
/// </summary>
public static class GroupShapeNonVisualPropertiesConverter
{
  /// <summary>
  ///   NonVisualDrawingProperties.
  /// </summary>
  public static NonVisualDrawingProperties? GetNonVisualDrawingProperties(GroupShapeNonVisualProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingProperties>();
    if (itemElement != null)
      return NonVisualDrawingPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNonVisualDrawingProperties(GroupShapeNonVisualProperties? openXmlElement, NonVisualDrawingProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NonVisualDrawingPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   NonVisualGroupDrawingShapeProperties.
  /// </summary>
  public static NonVisualGroupDrawingShapeProperties? GetNonVisualGroupDrawingShapeProperties(GroupShapeNonVisualProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.NonVisualGroupDrawingShapeProperties>();
    if (itemElement != null)
      return NonVisualGroupDrawingShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNonVisualGroupDrawingShapeProperties(GroupShapeNonVisualProperties? openXmlElement, NonVisualGroupDrawingShapeProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.NonVisualGroupDrawingShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NonVisualGroupDrawingShapePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Drawing.NonVisualGroupDrawingShapeProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Office.GroupShapeNonVisualProperties? CreateModelElement(GroupShapeNonVisualProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Office.GroupShapeNonVisualProperties();
      value.NonVisualDrawingProperties = GetNonVisualDrawingProperties(openXmlElement);
      value.NonVisualGroupDrawingShapeProperties = GetNonVisualGroupDrawingShapeProperties(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Office.GroupShapeNonVisualProperties? value)
    where OpenXmlElementType : GroupShapeNonVisualProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNonVisualDrawingProperties(openXmlElement, value?.NonVisualDrawingProperties);
      SetNonVisualGroupDrawingShapeProperties(openXmlElement, value?.NonVisualGroupDrawingShapeProperties);
      return openXmlElement;
    }
    return default;
  }
}