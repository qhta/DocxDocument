namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the DefaultShapeDefinitionType Class.
/// </summary>
public static class DefaultShapeDefinitionTypeConverter
{
  /// <summary>
  /// Visual Properties.
  /// </summary>
  private static DocumentModel.Drawings.ShapeProperties? GetShapeProperties(DocumentFormat.OpenXml.Drawing.DefaultShapeDefinitionType openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShapeProperties(DocumentFormat.OpenXml.Drawing.DefaultShapeDefinitionType openXmlElement, DocumentModel.Drawings.ShapeProperties? value)
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
  
  /// <summary>
  /// BodyProperties.
  /// </summary>
  private static DocumentModel.Drawings.BodyProperties? GetBodyProperties(DocumentFormat.OpenXml.Drawing.DefaultShapeDefinitionType openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.BodyProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.BodyPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBodyProperties(DocumentFormat.OpenXml.Drawing.DefaultShapeDefinitionType openXmlElement, DocumentModel.Drawings.BodyProperties? value)
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
  
  /// <summary>
  /// ListStyle.
  /// </summary>
  private static DocumentModel.Drawings.ListStyle? GetListStyle(DocumentFormat.OpenXml.Drawing.DefaultShapeDefinitionType openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ListStyle>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ListStyleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetListStyle(DocumentFormat.OpenXml.Drawing.DefaultShapeDefinitionType openXmlElement, DocumentModel.Drawings.ListStyle? value)
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
  
  /// <summary>
  /// ShapeStyle.
  /// </summary>
  private static DocumentModel.Drawings.ShapeStyle? GetShapeStyle(DocumentFormat.OpenXml.Drawing.DefaultShapeDefinitionType openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ShapeStyle>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ShapeStyleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShapeStyle(DocumentFormat.OpenXml.Drawing.DefaultShapeDefinitionType openXmlElement, DocumentModel.Drawings.ShapeStyle? value)
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
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DocumentModel.Drawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.DefaultShapeDefinitionType openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DocumentFormat.OpenXml.Drawing.DefaultShapeDefinitionType openXmlElement, DocumentModel.Drawings.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.DefaultShapeDefinitionType? CreateModelElement(DocumentFormat.OpenXml.Drawing.DefaultShapeDefinitionType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.DefaultShapeDefinitionType();
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.BodyProperties = GetBodyProperties(openXmlElement);
      value.ListStyle = GetListStyle(openXmlElement);
      value.ShapeStyle = GetShapeStyle(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.DefaultShapeDefinitionType? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.DefaultShapeDefinitionType, new()
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
