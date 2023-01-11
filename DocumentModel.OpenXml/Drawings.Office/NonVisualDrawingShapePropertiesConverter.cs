namespace DocumentModel.OpenXml.Drawings.Office;

/// <summary>
/// Defines the NonVisualDrawingShapeProperties Class.
/// </summary>
public static class NonVisualDrawingShapePropertiesConverter
{
  /// <summary>
  /// Text Box
  /// </summary>
  public static Boolean? GetTextBox(DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingShapeProperties? openXmlElement)
  {
    return openXmlElement?.TextBox?.Value;
  }
  
  public static void SetTextBox(DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingShapeProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.TextBox = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.TextBox = null;
  }
  
  /// <summary>
  /// Shape Locks.
  /// </summary>
  public static DocumentModel.Drawings.ShapeLocks? GetShapeLocks(DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingShapeProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ShapeLocks>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ShapeLocksConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetShapeLocks(DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingShapeProperties? openXmlElement, DocumentModel.Drawings.ShapeLocks? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ShapeLocks>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ShapeLocksConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ShapeLocks>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingShapeProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingShapeProperties? openXmlElement, DocumentModel.Drawings.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.Office.NonVisualDrawingShapeProperties? CreateModelElement(DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingShapeProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Office.NonVisualDrawingShapeProperties();
      value.TextBox = GetTextBox(openXmlElement);
      value.ShapeLocks = GetShapeLocks(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Office.NonVisualDrawingShapeProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingShapeProperties, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
