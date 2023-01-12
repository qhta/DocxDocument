namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Shape Default.
/// </summary>
public static class ShapeDefaultConverter
{
  public static DocumentModel.Drawings.ShapeProperties? GetShapeProperties(DocumentFormat.OpenXml.Drawing.ShapeDefault? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetShapeProperties(DocumentFormat.OpenXml.Drawing.ShapeDefault? openXmlElement, DocumentModel.Drawings.ShapeProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ShapePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ShapeProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.BodyProperties? GetBodyProperties(DocumentFormat.OpenXml.Drawing.ShapeDefault? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.BodyProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.BodyPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBodyProperties(DocumentFormat.OpenXml.Drawing.ShapeDefault? openXmlElement, DocumentModel.Drawings.BodyProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.BodyProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.BodyPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.BodyProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ListStyle? GetListStyle(DocumentFormat.OpenXml.Drawing.ShapeDefault? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ListStyle>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ListStyleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetListStyle(DocumentFormat.OpenXml.Drawing.ShapeDefault? openXmlElement, DocumentModel.Drawings.ListStyle? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ListStyle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ListStyleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ListStyle>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ShapeStyle? GetShapeStyle(DocumentFormat.OpenXml.Drawing.ShapeDefault? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ShapeStyle>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ShapeStyleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetShapeStyle(DocumentFormat.OpenXml.Drawing.ShapeDefault? openXmlElement, DocumentModel.Drawings.ShapeStyle? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ShapeStyle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ShapeStyleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ShapeStyle>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.ShapeDefault? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Drawing.ShapeDefault? openXmlElement, DocumentModel.Drawings.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ShapeDefault? CreateModelElement(DocumentFormat.OpenXml.Drawing.ShapeDefault? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ShapeDefault();
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.BodyProperties = GetBodyProperties(openXmlElement);
      value.ListStyle = GetListStyle(openXmlElement);
      value.ShapeStyle = GetShapeStyle(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ShapeDefault? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.ShapeDefault, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
