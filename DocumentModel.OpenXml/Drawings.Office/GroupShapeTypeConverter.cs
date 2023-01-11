namespace DocumentModel.OpenXml.Drawings.Office;

/// <summary>
/// Defines the GroupShapeType Class.
/// </summary>
public static class GroupShapeTypeConverter
{
  /// <summary>
  /// GroupShapeNonVisualProperties.
  /// </summary>
  public static DocumentModel.Drawings.Office.GroupShapeNonVisualProperties? GetGroupShapeNonVisualProperties(DocumentFormat.OpenXml.Office.Drawing.GroupShapeType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.GroupShapeNonVisualProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Office.GroupShapeNonVisualPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetGroupShapeNonVisualProperties(DocumentFormat.OpenXml.Office.Drawing.GroupShapeType? openXmlElement, DocumentModel.Drawings.Office.GroupShapeNonVisualProperties? value)
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
  
  /// <summary>
  /// GroupShapeProperties.
  /// </summary>
  public static DocumentModel.Drawings.Office.GroupShapeProperties? GetGroupShapeProperties(DocumentFormat.OpenXml.Office.Drawing.GroupShapeType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.GroupShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Office.GroupShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetGroupShapeProperties(DocumentFormat.OpenXml.Office.Drawing.GroupShapeType? openXmlElement, DocumentModel.Drawings.Office.GroupShapeProperties? value)
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
  
  public static DocumentModel.Drawings.Office.GroupShapeType? CreateModelElement(DocumentFormat.OpenXml.Office.Drawing.GroupShapeType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Office.GroupShapeType();
      value.GroupShapeNonVisualProperties = GetGroupShapeNonVisualProperties(openXmlElement);
      value.GroupShapeProperties = GetGroupShapeProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Office.GroupShapeType? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office.Drawing.GroupShapeType, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
