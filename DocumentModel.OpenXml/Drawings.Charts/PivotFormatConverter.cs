namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Pivot Format.
/// </summary>
public static class PivotFormatConverter
{
  /// <summary>
  /// Index.
  /// </summary>
  public static UInt32? GetIndex(DocumentFormat.OpenXml.Drawing.Charts.PivotFormat? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.Index");
  }
  
  public static void SetIndex(DocumentFormat.OpenXml.Drawing.Charts.PivotFormat? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.Index");
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public static DocumentModel.Drawings.Charts.ShapeProperties? GetShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.PivotFormat? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.PivotFormat? openXmlElement, DocumentModel.Drawings.Charts.ShapeProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.ShapePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ShapeProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Marker.
  /// </summary>
  public static DocumentModel.Drawings.Charts.Marker? GetMarker(DocumentFormat.OpenXml.Drawing.Charts.PivotFormat? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Marker>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.MarkerConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMarker(DocumentFormat.OpenXml.Drawing.Charts.PivotFormat? openXmlElement, DocumentModel.Drawings.Charts.Marker? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Marker>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.MarkerConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Marker>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Data Label.
  /// </summary>
  public static DocumentModel.Drawings.Charts.DataLabel? GetDataLabel(DocumentFormat.OpenXml.Drawing.Charts.PivotFormat? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabel>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.DataLabelConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDataLabel(DocumentFormat.OpenXml.Drawing.Charts.PivotFormat? openXmlElement, DocumentModel.Drawings.Charts.DataLabel? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabel>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.DataLabelConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.DataLabel>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public static DocumentModel.Drawings.Charts.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.PivotFormat? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.PivotFormat? openXmlElement, DocumentModel.Drawings.Charts.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.PivotFormat? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.PivotFormat? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.PivotFormat();
      value.Index = GetIndex(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.Marker = GetMarker(openXmlElement);
      value.DataLabel = GetDataLabel(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.PivotFormat? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.PivotFormat, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
