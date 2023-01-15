using DocumentModel.Drawings;
using LineDefault = DocumentFormat.OpenXml.Drawing.LineDefault;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Line Default.
/// </summary>
public static class LineDefaultConverter
{
  public static ShapeProperties? GetShapeProperties(LineDefault? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ShapeProperties>();
    if (itemElement != null)
      return ShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShapeProperties(LineDefault? openXmlElement, ShapeProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ShapeProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static BodyProperties? GetBodyProperties(LineDefault? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.BodyProperties>();
    if (itemElement != null)
      return BodyPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBodyProperties(LineDefault? openXmlElement, BodyProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.BodyProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BodyPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.BodyProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ListStyle? GetListStyle(LineDefault? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ListStyle>();
    if (itemElement != null)
      return ListStyleConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetListStyle(LineDefault? openXmlElement, ListStyle? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ListStyle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ListStyleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ListStyle>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ShapeStyle? GetShapeStyle(LineDefault? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ShapeStyle>();
    if (itemElement != null)
      return ShapeStyleConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShapeStyle(LineDefault? openXmlElement, ShapeStyle? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ShapeStyle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapeStyleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ShapeStyle>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ExtensionList? GetExtensionList(LineDefault? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(LineDefault? openXmlElement, DocumentModel.Drawings.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.LineDefault? CreateModelElement(LineDefault? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.LineDefault();
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.BodyProperties = GetBodyProperties(openXmlElement);
      value.ListStyle = GetListStyle(openXmlElement);
      value.ShapeStyle = GetShapeStyle(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.LineDefault? value)
    where OpenXmlElementType : LineDefault, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetShapeProperties(openXmlElement, value?.ShapeProperties);
      SetBodyProperties(openXmlElement, value?.BodyProperties);
      SetListStyle(openXmlElement, value?.ListStyle);
      SetShapeStyle(openXmlElement, value?.ShapeStyle);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}