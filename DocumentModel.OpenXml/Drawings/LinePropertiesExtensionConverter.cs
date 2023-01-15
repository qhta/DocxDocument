using DocumentModel.Drawings;
using LinePropertiesExtension = DocumentFormat.OpenXml.Drawing.LinePropertiesExtension;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the LinePropertiesExtension Class.
/// </summary>
public static class LinePropertiesExtensionConverter
{
  /// <summary>
  ///   URI
  /// </summary>
  public static String? GetUri(LinePropertiesExtension? openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }

  public static void SetUri(LinePropertiesExtension? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Uri = new StringValue { Value = value };
      else
        openXmlElement.Uri = null;
  }

  public static LineSketchStyleProperties? GetLineSketchStyleProperties(LinePropertiesExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchStyleProperties>();
    if (itemElement != null)
      return LineSketchStylePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLineSketchStyleProperties(LinePropertiesExtension? openXmlElement, LineSketchStyleProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchStyleProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LineSketchStylePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchStyleProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.LinePropertiesExtension? CreateModelElement(LinePropertiesExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.LinePropertiesExtension();
      value.Uri = GetUri(openXmlElement);
      value.LineSketchStyleProperties = GetLineSketchStyleProperties(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.LinePropertiesExtension? value)
    where OpenXmlElementType : LinePropertiesExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetLineSketchStyleProperties(openXmlElement, value?.LineSketchStyleProperties);
      return openXmlElement;
    }
    return default;
  }
}