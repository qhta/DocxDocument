namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the DefaultShapeDefinitionType Class.
/// </summary>
public static class DefaultShapeDefinitionTypeConverter
{
  /// <summary>
  /// Visual Properties.
  /// </summary>
  public static DocumentModel.Drawings.ShapeProperties? GetShapeProperties(DocumentFormat.OpenXml.Drawing.DefaultShapeDefinitionType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetShapeProperties(DocumentFormat.OpenXml.Drawing.DefaultShapeDefinitionType? openXmlElement, DocumentModel.Drawings.ShapeProperties? value)
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
  
  /// <summary>
  /// BodyProperties.
  /// </summary>
  public static DocumentModel.Drawings.BodyProperties? GetBodyProperties(DocumentFormat.OpenXml.Drawing.DefaultShapeDefinitionType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.BodyProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.BodyPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBodyProperties(DocumentFormat.OpenXml.Drawing.DefaultShapeDefinitionType? openXmlElement, DocumentModel.Drawings.BodyProperties? value)
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
  
  /// <summary>
  /// ListStyle.
  /// </summary>
  public static DocumentModel.Drawings.ListStyle? GetListStyle(DocumentFormat.OpenXml.Drawing.DefaultShapeDefinitionType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ListStyle>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ListStyleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetListStyle(DocumentFormat.OpenXml.Drawing.DefaultShapeDefinitionType? openXmlElement, DocumentModel.Drawings.ListStyle? value)
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
  
  /// <summary>
  /// ShapeStyle.
  /// </summary>
  public static DocumentModel.Drawings.ShapeStyle? GetShapeStyle(DocumentFormat.OpenXml.Drawing.DefaultShapeDefinitionType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ShapeStyle>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ShapeStyleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetShapeStyle(DocumentFormat.OpenXml.Drawing.DefaultShapeDefinitionType? openXmlElement, DocumentModel.Drawings.ShapeStyle? value)
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
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.DefaultShapeDefinitionType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Drawing.DefaultShapeDefinitionType? openXmlElement, DocumentModel.Drawings.ExtensionList? value)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
