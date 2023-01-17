namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Point.
/// </summary>
public static class PointConverter
{
  /// <summary>
  /// Model Identifier
  /// </summary>
  private static String? GetModelId(DocumentFormat.OpenXml.Drawing.Diagrams.Point openXmlElement)
  {
    return openXmlElement?.ModelId?.Value;
  }
  
  private static void SetModelId(DocumentFormat.OpenXml.Drawing.Diagrams.Point openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ModelId = new StringValue { Value = value };
    else
      openXmlElement.ModelId = null;
  }
  
  /// <summary>
  /// Point Type
  /// </summary>
  private static DocumentModel.Drawings.Diagrams.PointKind? GetType(DocumentFormat.OpenXml.Drawing.Diagrams.Point openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.PointValues, DocumentModel.Drawings.Diagrams.PointKind>(openXmlElement?.Type?.Value);
  }
  
  private static void SetType(DocumentFormat.OpenXml.Drawing.Diagrams.Point openXmlElement, DocumentModel.Drawings.Diagrams.PointKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.PointValues, DocumentModel.Drawings.Diagrams.PointKind>(value);
  }
  
  /// <summary>
  /// Connection Identifier
  /// </summary>
  private static String? GetConnectionId(DocumentFormat.OpenXml.Drawing.Diagrams.Point openXmlElement)
  {
    return openXmlElement?.ConnectionId?.Value;
  }
  
  private static void SetConnectionId(DocumentFormat.OpenXml.Drawing.Diagrams.Point openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ConnectionId = new StringValue { Value = value };
    else
      openXmlElement.ConnectionId = null;
  }
  
  /// <summary>
  /// Property Set.
  /// </summary>
  private static DocumentModel.Drawings.Diagrams.PropertySet? GetPropertySet(DocumentFormat.OpenXml.Drawing.Diagrams.Point openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.PropertySetConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPropertySet(DocumentFormat.OpenXml.Drawing.Diagrams.Point openXmlElement, DocumentModel.Drawings.Diagrams.PropertySet? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Diagrams.PropertySetConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Shape Properties.
  /// </summary>
  private static DocumentModel.Drawings.Diagrams.ShapeProperties? GetShapeProperties(DocumentFormat.OpenXml.Drawing.Diagrams.Point openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.ShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShapeProperties(DocumentFormat.OpenXml.Drawing.Diagrams.Point openXmlElement, DocumentModel.Drawings.Diagrams.ShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Diagrams.ShapePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.ShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Text Body.
  /// </summary>
  private static DocumentModel.Drawings.Diagrams.TextBody? GetTextBody(DocumentFormat.OpenXml.Drawing.Diagrams.Point openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.TextBody>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.TextBodyConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTextBody(DocumentFormat.OpenXml.Drawing.Diagrams.Point openXmlElement, DocumentModel.Drawings.Diagrams.TextBody? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.TextBody>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Diagrams.TextBodyConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.TextBody>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// PtExtensionList.
  /// </summary>
  private static DocumentModel.Drawings.Diagrams.PtExtensionList? GetPtExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.Point openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.PtExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.PtExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPtExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.Point openXmlElement, DocumentModel.Drawings.Diagrams.PtExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.PtExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Diagrams.PtExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.PtExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.Point? CreateModelElement(DocumentFormat.OpenXml.Drawing.Diagrams.Point? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.Point();
      value.ModelId = GetModelId(openXmlElement);
      value.Type = GetType(openXmlElement);
      value.ConnectionId = GetConnectionId(openXmlElement);
      value.PropertySet = GetPropertySet(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.TextBody = GetTextBody(openXmlElement);
      value.PtExtensionList = GetPtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.Point? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Diagrams.Point, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetModelId(openXmlElement, value?.ModelId);
      SetType(openXmlElement, value?.Type);
      SetConnectionId(openXmlElement, value?.ConnectionId);
      SetPropertySet(openXmlElement, value?.PropertySet);
      SetShapeProperties(openXmlElement, value?.ShapeProperties);
      SetTextBody(openXmlElement, value?.TextBody);
      SetPtExtensionList(openXmlElement, value?.PtExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
