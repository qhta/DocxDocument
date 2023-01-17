namespace DocumentModel.OpenXml.Drawings.Office;

/// <summary>
/// Defines the NonVisualDrawingShapeProperties Class.
/// </summary>
public static class NonVisualDrawingShapePropertiesConverter
{
  /// <summary>
  /// Text Box
  /// </summary>
  private static Boolean? GetTextBox(DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingShapeProperties openXmlElement)
  {
    return openXmlElement?.TextBox?.Value;
  }
  
  private static void SetTextBox(DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingShapeProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.TextBox = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.TextBox = null;
  }
  
  /// <summary>
  /// Shape Locks.
  /// </summary>
  private static DocumentModel.Drawings.ShapeLocks? GetShapeLocks(DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingShapeProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ShapeLocks>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ShapeLocksConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShapeLocks(DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingShapeProperties openXmlElement, DocumentModel.Drawings.ShapeLocks? value)
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
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DocumentModel.Drawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingShapeProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingShapeProperties openXmlElement, DocumentModel.Drawings.ExtensionList? value)
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
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTextBox(openXmlElement, value?.TextBox);
      SetShapeLocks(openXmlElement, value?.ShapeLocks);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
