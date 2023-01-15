using DocumentFormat.OpenXml.Drawing.Charts;
using PictureOptions = DocumentModel.Drawings.Charts.PictureOptions;
using ShapeProperties = DocumentModel.Drawings.Charts.ShapeProperties;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   3D back wall formatting.
/// </summary>
public static class BackWallConverter
{
  public static Byte? GetThickness(BackWall? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Thickness>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetThickness(BackWall? openXmlElement, Byte? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Thickness>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new Thickness { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ShapeProperties? GetShapeProperties(BackWall? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ShapeProperties>();
    if (itemElement != null)
      return ShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShapeProperties(BackWall? openXmlElement, ShapeProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ShapeProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static PictureOptions? GetPictureOptions(BackWall? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>();
    if (itemElement != null)
      return PictureOptionsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPictureOptions(BackWall? openXmlElement, PictureOptions? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PictureOptionsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.ExtensionList? GetExtensionList(BackWall? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(BackWall? openXmlElement, DocumentModel.Drawings.Charts.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.BackWall? CreateModelElement(BackWall? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.BackWall();
      value.Thickness = GetThickness(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.PictureOptions = GetPictureOptions(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.BackWall? value)
    where OpenXmlElementType : BackWall, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetThickness(openXmlElement, value?.Thickness);
      SetShapeProperties(openXmlElement, value?.ShapeProperties);
      SetPictureOptions(openXmlElement, value?.PictureOptions);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}