using DocumentFormat.OpenXml.Office.Drawing;
using ShapeNonVisualProperties = DocumentModel.Drawings.Office.ShapeNonVisualProperties;
using ShapeProperties = DocumentModel.Drawings.Office.ShapeProperties;
using ShapeStyle = DocumentModel.Drawings.Office.ShapeStyle;
using TextBody = DocumentModel.Drawings.Office.TextBody;
using Transform2D = DocumentModel.Drawings.Office.Transform2D;

namespace DocumentModel.OpenXml.Drawings.Office;

/// <summary>
///   Defines the Shape Class.
/// </summary>
public static class ShapeConverter
{
  /// <summary>
  ///   modelId, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetModelId(Shape? openXmlElement)
  {
    return openXmlElement?.ModelId?.Value;
  }

  public static void SetModelId(Shape? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ModelId = new StringValue { Value = value };
      else
        openXmlElement.ModelId = null;
  }

  /// <summary>
  ///   ShapeNonVisualProperties.
  /// </summary>
  public static ShapeNonVisualProperties? GetShapeNonVisualProperties(Shape? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.ShapeNonVisualProperties>();
    if (itemElement != null)
      return ShapeNonVisualPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShapeNonVisualProperties(Shape? openXmlElement, ShapeNonVisualProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.ShapeNonVisualProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapeNonVisualPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Drawing.ShapeNonVisualProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  public static ShapeProperties? GetShapeProperties(Shape? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.ShapeProperties>();
    if (itemElement != null)
      return ShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShapeProperties(Shape? openXmlElement, ShapeProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.ShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Drawing.ShapeProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ShapeStyle.
  /// </summary>
  public static ShapeStyle? GetShapeStyle(Shape? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.ShapeStyle>();
    if (itemElement != null)
      return ShapeStyleConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShapeStyle(Shape? openXmlElement, ShapeStyle? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.ShapeStyle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapeStyleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Drawing.ShapeStyle>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   TextBody.
  /// </summary>
  public static TextBody? GetTextBody(Shape? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.TextBody>();
    if (itemElement != null)
      return TextBodyConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTextBody(Shape? openXmlElement, TextBody? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.TextBody>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextBodyConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Drawing.TextBody>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Transform2D.
  /// </summary>
  public static Transform2D? GetTransform2D(Shape? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.Transform2D>();
    if (itemElement != null)
      return Transform2DConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTransform2D(Shape? openXmlElement, Transform2D? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.Transform2D>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Transform2DConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Drawing.Transform2D>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.Office.OfficeArtExtensionList? GetOfficeArtExtensionList(Shape? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.OfficeArtExtensionList>();
    if (itemElement != null)
      return OfficeArtExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetOfficeArtExtensionList(Shape? openXmlElement, DocumentModel.Drawings.Office.OfficeArtExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.OfficeArtExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OfficeArtExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Drawing.OfficeArtExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Office.Shape? CreateModelElement(Shape? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Office.Shape();
      value.ModelId = GetModelId(openXmlElement);
      value.ShapeNonVisualProperties = GetShapeNonVisualProperties(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.ShapeStyle = GetShapeStyle(openXmlElement);
      value.TextBody = GetTextBody(openXmlElement);
      value.Transform2D = GetTransform2D(openXmlElement);
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Office.Shape? value)
    where OpenXmlElementType : Shape, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetModelId(openXmlElement, value?.ModelId);
      SetShapeNonVisualProperties(openXmlElement, value?.ShapeNonVisualProperties);
      SetShapeProperties(openXmlElement, value?.ShapeProperties);
      SetShapeStyle(openXmlElement, value?.ShapeStyle);
      SetTextBody(openXmlElement, value?.TextBody);
      SetTransform2D(openXmlElement, value?.Transform2D);
      SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
      return openXmlElement;
    }
    return default;
  }
}