using DocumentFormat.OpenXml.Drawing;
using DocumentModel.OpenXml.Drawings.Diagrams;
using NonVisualDrawingProperties = DocumentModel.Drawings.Diagrams.NonVisualDrawingProperties;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the PtExtension Class.
/// </summary>
public static class PtExtensionConverter
{
  /// <summary>
  ///   URI
  /// </summary>
  public static String? GetUri(PtExtension? openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }

  public static void SetUri(PtExtension? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Uri = new StringValue { Value = value };
      else
        openXmlElement.Uri = null;
  }

  public static NonVisualDrawingProperties? GetNonVisualDrawingProperties(PtExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Diagram.NonVisualDrawingProperties>();
    if (itemElement != null)
      return NonVisualDrawingPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNonVisualDrawingProperties(PtExtension? openXmlElement, NonVisualDrawingProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Diagram.NonVisualDrawingProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NonVisualDrawingPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.Diagram.NonVisualDrawingProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.PtExtension? CreateModelElement(PtExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.PtExtension();
      value.Uri = GetUri(openXmlElement);
      value.NonVisualDrawingProperties = GetNonVisualDrawingProperties(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.PtExtension? value)
    where OpenXmlElementType : PtExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetNonVisualDrawingProperties(openXmlElement, value?.NonVisualDrawingProperties);
      return openXmlElement;
    }
    return default;
  }
}