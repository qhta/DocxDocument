namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Non-Visual Connection Shape Drawing Properties.
/// </summary>
public static class NonVisualConnectionShapePropertiesConverter
{
  /// <summary>
  /// Connection Shape Locks.
  /// </summary>
  private static DocumentModel.Drawings.ConnectionShapeLocks? GetConnectionShapeLocks(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualConnectionShapeProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ConnectionShapeLocks>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ConnectionShapeLocksConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetConnectionShapeLocks(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualConnectionShapeProperties openXmlElement, DocumentModel.Drawings.ConnectionShapeLocks? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ConnectionShapeLocks>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ConnectionShapeLocksConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ConnectionShapeLocks>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Connection Start.
  /// </summary>
  private static DocumentModel.Drawings.ConnectionType? GetStartConnection(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualConnectionShapeProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.StartConnection>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ConnectionTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetStartConnection(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualConnectionShapeProperties openXmlElement, DocumentModel.Drawings.ConnectionType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.StartConnection>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ConnectionTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.StartConnection>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Connection End.
  /// </summary>
  private static DocumentModel.Drawings.ConnectionType? GetEndConnection(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualConnectionShapeProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.EndConnection>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ConnectionTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetEndConnection(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualConnectionShapeProperties openXmlElement, DocumentModel.Drawings.ConnectionType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.EndConnection>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ConnectionTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.EndConnection>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DocumentModel.Drawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualConnectionShapeProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualConnectionShapeProperties openXmlElement, DocumentModel.Drawings.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.ChartDrawing.NonVisualConnectionShapeProperties? CreateModelElement(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualConnectionShapeProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawing.NonVisualConnectionShapeProperties();
      value.ConnectionShapeLocks = GetConnectionShapeLocks(openXmlElement);
      value.StartConnection = GetStartConnection(openXmlElement);
      value.EndConnection = GetEndConnection(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawing.NonVisualConnectionShapeProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualConnectionShapeProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetConnectionShapeLocks(openXmlElement, value?.ConnectionShapeLocks);
      SetStartConnection(openXmlElement, value?.StartConnection);
      SetEndConnection(openXmlElement, value?.EndConnection);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
