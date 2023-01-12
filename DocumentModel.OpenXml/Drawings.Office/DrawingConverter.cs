namespace DocumentModel.OpenXml.Drawings.Office;

/// <summary>
/// Defines the Drawing Class.
/// </summary>
public static class DrawingConverter
{
  /// <summary>
  /// ShapeTree.
  /// </summary>
  public static DocumentModel.Drawings.Office.ShapeTree? GetShapeTree(DocumentFormat.OpenXml.Office.Drawing.Drawing? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.ShapeTree>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Office.ShapeTreeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetShapeTree(DocumentFormat.OpenXml.Office.Drawing.Drawing? openXmlElement, DocumentModel.Drawings.Office.ShapeTree? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.ShapeTree>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Office.ShapeTreeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Drawing.ShapeTree>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Office.Drawing? CreateModelElement(DocumentFormat.OpenXml.Office.Drawing.Drawing? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Office.Drawing();
      value.ShapeTree = GetShapeTree(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Office.Drawing? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office.Drawing.Drawing, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetShapeTree(openXmlElement, value?.ShapeTree);
      return openXmlElement;
    }
    return default;
  }
}
