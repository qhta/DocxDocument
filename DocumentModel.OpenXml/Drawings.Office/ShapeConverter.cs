namespace DocumentModel.OpenXml.Drawings.Office;

/// <summary>
/// Defines the Shape Class.
/// </summary>
public static class ShapeConverter
{
  /// <summary>
  /// modelId, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetModelId(DocumentFormat.OpenXml.Office.Drawing.Shape? openXmlElement)
  {
    return openXmlElement?.ModelId?.Value;
  }
  
  public static void SetModelId(DocumentFormat.OpenXml.Office.Drawing.Shape? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ModelId = new StringValue { Value = value };
      else
        openXmlElement.ModelId = null;
  }
  
  /// <summary>
  /// ShapeNonVisualProperties.
  /// </summary>
  public static DocumentModel.Drawings.Office.ShapeNonVisualProperties? GetShapeNonVisualProperties(DocumentFormat.OpenXml.Office.Drawing.Shape? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.ShapeNonVisualProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Office.ShapeNonVisualPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetShapeNonVisualProperties(DocumentFormat.OpenXml.Office.Drawing.Shape? openXmlElement, DocumentModel.Drawings.Office.ShapeNonVisualProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.ShapeNonVisualProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Office.ShapeNonVisualPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Drawing.ShapeNonVisualProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public static DocumentModel.Drawings.Office.ShapeProperties? GetShapeProperties(DocumentFormat.OpenXml.Office.Drawing.Shape? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.ShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Office.ShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetShapeProperties(DocumentFormat.OpenXml.Office.Drawing.Shape? openXmlElement, DocumentModel.Drawings.Office.ShapeProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.ShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Office.ShapePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Drawing.ShapeProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// ShapeStyle.
  /// </summary>
  public static DocumentModel.Drawings.Office.ShapeStyle? GetShapeStyle(DocumentFormat.OpenXml.Office.Drawing.Shape? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.ShapeStyle>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Office.ShapeStyleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetShapeStyle(DocumentFormat.OpenXml.Office.Drawing.Shape? openXmlElement, DocumentModel.Drawings.Office.ShapeStyle? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.ShapeStyle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Office.ShapeStyleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Drawing.ShapeStyle>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// TextBody.
  /// </summary>
  public static DocumentModel.Drawings.Office.TextBody? GetTextBody(DocumentFormat.OpenXml.Office.Drawing.Shape? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.TextBody>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Office.TextBodyConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTextBody(DocumentFormat.OpenXml.Office.Drawing.Shape? openXmlElement, DocumentModel.Drawings.Office.TextBody? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.TextBody>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Office.TextBodyConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Drawing.TextBody>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Transform2D.
  /// </summary>
  public static DocumentModel.Drawings.Office.Transform2D? GetTransform2D(DocumentFormat.OpenXml.Office.Drawing.Shape? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.Transform2D>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Office.Transform2DConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTransform2D(DocumentFormat.OpenXml.Office.Drawing.Shape? openXmlElement, DocumentModel.Drawings.Office.Transform2D? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.Transform2D>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Office.Transform2DConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Drawing.Transform2D>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.Office.OfficeArtExtensionList? GetOfficeArtExtensionList(DocumentFormat.OpenXml.Office.Drawing.Shape? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.OfficeArtExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Office.OfficeArtExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetOfficeArtExtensionList(DocumentFormat.OpenXml.Office.Drawing.Shape? openXmlElement, DocumentModel.Drawings.Office.OfficeArtExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.OfficeArtExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Office.OfficeArtExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Drawing.OfficeArtExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Office.Shape? CreateModelElement(DocumentFormat.OpenXml.Office.Drawing.Shape? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Office.Drawing.Shape, new()
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
