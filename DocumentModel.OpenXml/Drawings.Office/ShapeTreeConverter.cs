namespace DocumentModel.OpenXml.Drawings.Office;

/// <summary>
/// Defines the ShapeTree Class.
/// </summary>
public static class ShapeTreeConverter
{
  public static DocumentModel.Drawings.Office.GroupShapeNonVisualProperties? GetGroupShapeNonVisualProperties(DocumentFormat.OpenXml.Office.Drawing.ShapeTree? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.GroupShapeNonVisualProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Office.GroupShapeNonVisualPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetGroupShapeNonVisualProperties(DocumentFormat.OpenXml.Office.Drawing.ShapeTree? openXmlElement, DocumentModel.Drawings.Office.GroupShapeNonVisualProperties? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.Office.GroupShapeProperties? GetGroupShapeProperties(DocumentFormat.OpenXml.Office.Drawing.ShapeTree? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.GroupShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Office.GroupShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetGroupShapeProperties(DocumentFormat.OpenXml.Office.Drawing.ShapeTree? openXmlElement, DocumentModel.Drawings.Office.GroupShapeProperties? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.Office.Shape? GetShape(DocumentFormat.OpenXml.Office.Drawing.ShapeTree? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.Shape>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Office.ShapeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetShape(DocumentFormat.OpenXml.Office.Drawing.ShapeTree? openXmlElement, DocumentModel.Drawings.Office.Shape? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.Office.GroupShape? GetGroupShape(DocumentFormat.OpenXml.Office.Drawing.ShapeTree? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.GroupShape>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Office.GroupShapeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetGroupShape(DocumentFormat.OpenXml.Office.Drawing.ShapeTree? openXmlElement, DocumentModel.Drawings.Office.GroupShape? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.Office.OfficeArtExtensionList? GetOfficeArtExtensionList(DocumentFormat.OpenXml.Office.Drawing.ShapeTree? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.OfficeArtExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Office.OfficeArtExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetOfficeArtExtensionList(DocumentFormat.OpenXml.Office.Drawing.ShapeTree? openXmlElement, DocumentModel.Drawings.Office.OfficeArtExtensionList? value)
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
  
  public static DocumentModel.Drawings.Office.ShapeTree? CreateModelElement(DocumentFormat.OpenXml.Office.Drawing.ShapeTree? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Office.ShapeTree();
      value.GroupShapeNonVisualProperties = GetGroupShapeNonVisualProperties(openXmlElement);
      value.GroupShapeProperties = GetGroupShapeProperties(openXmlElement);
      value.Shape = GetShape(openXmlElement);
      value.GroupShape = GetGroupShape(openXmlElement);
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Office.ShapeTree? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office.Drawing.ShapeTree, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGroupShapeNonVisualProperties(openXmlElement, value?.GroupShapeNonVisualProperties);
      SetGroupShapeProperties(openXmlElement, value?.GroupShapeProperties);
      SetShape(openXmlElement, value?.Shape);
      SetGroupShape(openXmlElement, value?.GroupShape);
      SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
