namespace DocumentModel.OpenXml.Drawings.Office;

/// <summary>
/// Defines the GroupShape Class.
/// </summary>
public static class GroupShapeConverter
{
  private static DocumentModel.Drawings.Office.GroupShapeNonVisualProperties? GetGroupShapeNonVisualProperties(DocumentFormat.OpenXml.Office.Drawing.GroupShape openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.GroupShapeNonVisualProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Office.GroupShapeNonVisualPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGroupShapeNonVisualProperties(DocumentFormat.OpenXml.Office.Drawing.GroupShape openXmlElement, DocumentModel.Drawings.Office.GroupShapeNonVisualProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.GroupShapeNonVisualProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Office.GroupShapeNonVisualPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Drawing.GroupShapeNonVisualProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Office.GroupShapeProperties? GetGroupShapeProperties(DocumentFormat.OpenXml.Office.Drawing.GroupShape openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.GroupShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Office.GroupShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGroupShapeProperties(DocumentFormat.OpenXml.Office.Drawing.GroupShape openXmlElement, DocumentModel.Drawings.Office.GroupShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.GroupShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Office.GroupShapePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Drawing.GroupShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Office.Shape? GetShape(DocumentFormat.OpenXml.Office.Drawing.GroupShape openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.Shape>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Office.ShapeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShape(DocumentFormat.OpenXml.Office.Drawing.GroupShape openXmlElement, DocumentModel.Drawings.Office.Shape? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.Shape>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Office.ShapeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Drawing.Shape>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Office.GroupShape? GetChildGroupShape(DocumentFormat.OpenXml.Office.Drawing.GroupShape openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.GroupShape>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Office.GroupShapeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetChildGroupShape(DocumentFormat.OpenXml.Office.Drawing.GroupShape openXmlElement, DocumentModel.Drawings.Office.GroupShape? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.GroupShape>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Office.GroupShapeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Drawing.GroupShape>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Office.OfficeArtExtensionList? GetOfficeArtExtensionList(DocumentFormat.OpenXml.Office.Drawing.GroupShape openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.OfficeArtExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Office.OfficeArtExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetOfficeArtExtensionList(DocumentFormat.OpenXml.Office.Drawing.GroupShape openXmlElement, DocumentModel.Drawings.Office.OfficeArtExtensionList? value)
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
  
  public static DocumentModel.Drawings.Office.GroupShape? CreateModelElement(DocumentFormat.OpenXml.Office.Drawing.GroupShape? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Office.GroupShape();
      value.GroupShapeNonVisualProperties = GetGroupShapeNonVisualProperties(openXmlElement);
      value.GroupShapeProperties = GetGroupShapeProperties(openXmlElement);
      value.Shape = GetShape(openXmlElement);
      value.ChildGroupShape = GetChildGroupShape(openXmlElement);
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Office.GroupShape? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office.Drawing.GroupShape, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGroupShapeNonVisualProperties(openXmlElement, value?.GroupShapeNonVisualProperties);
      SetGroupShapeProperties(openXmlElement, value?.GroupShapeProperties);
      SetShape(openXmlElement, value?.Shape);
      SetChildGroupShape(openXmlElement, value?.ChildGroupShape);
      SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
