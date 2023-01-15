using DocumentModel.Drawings.Charts;
using InvertSolidFillFormat = DocumentFormat.OpenXml.Office2010.Drawing.Charts.InvertSolidFillFormat;
using ShapeProperties = DocumentFormat.OpenXml.Office2010.Drawing.Charts.ShapeProperties;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the InvertSolidFillFormat Class.
/// </summary>
public static class InvertSolidFillFormatConverter
{
  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  public static ShapeProperties2? GetShapeProperties(InvertSolidFillFormat? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<ShapeProperties>();
    if (itemElement != null)
      return ShapeProperties2Converter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShapeProperties(InvertSolidFillFormat? openXmlElement, ShapeProperties2? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapeProperties2Converter.CreateOpenXmlElement<ShapeProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.InvertSolidFillFormat? CreateModelElement(InvertSolidFillFormat? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.InvertSolidFillFormat();
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.InvertSolidFillFormat? value)
    where OpenXmlElementType : InvertSolidFillFormat, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetShapeProperties(openXmlElement, value?.ShapeProperties);
      return openXmlElement;
    }
    return default;
  }
}