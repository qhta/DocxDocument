namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the DataPoint Class.
/// </summary>
public static class DataPointConverter
{
  /// <summary>
  /// Index.
  /// </summary>
  public static UInt32? GetIndex(DocumentFormat.OpenXml.Drawing.Charts.DataPoint? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.Index");
  }
  
  public static void SetIndex(DocumentFormat.OpenXml.Drawing.Charts.DataPoint? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.Index");
  }
  
  /// <summary>
  /// Invert if Negative.
  /// </summary>
  public static Boolean? GetInvertIfNegative(DocumentFormat.OpenXml.Drawing.Charts.DataPoint? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.InvertIfNegative>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetInvertIfNegative(DocumentFormat.OpenXml.Drawing.Charts.DataPoint? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.InvertIfNegative>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Drawing.Charts.InvertIfNegative();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Marker.
  /// </summary>
  public static DocumentModel.Drawings.Charts.Marker? GetMarker(DocumentFormat.OpenXml.Drawing.Charts.DataPoint? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Marker>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.MarkerConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMarker(DocumentFormat.OpenXml.Drawing.Charts.DataPoint? openXmlElement, DocumentModel.Drawings.Charts.Marker? value)
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
  /// 3D Bubble.
  /// </summary>
  public static Boolean? GetBubble3D(DocumentFormat.OpenXml.Drawing.Charts.DataPoint? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Bubble3D>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetBubble3D(DocumentFormat.OpenXml.Drawing.Charts.DataPoint? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Bubble3D>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Drawing.Charts.Bubble3D();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Explosion.
  /// </summary>
  public static UInt32? GetExplosion(DocumentFormat.OpenXml.Drawing.Charts.DataPoint? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.Explosion");
  }
  
  public static void SetExplosion(DocumentFormat.OpenXml.Drawing.Charts.DataPoint? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.Explosion");
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public static DocumentModel.Drawings.Charts.ChartShapeProperties? GetChartShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.DataPoint? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ChartShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetChartShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.DataPoint? openXmlElement, DocumentModel.Drawings.Charts.ChartShapeProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.ChartShapePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// PictureOptions.
  /// </summary>
  public static DocumentModel.Drawings.Charts.PictureOptions? GetPictureOptions(DocumentFormat.OpenXml.Drawing.Charts.DataPoint? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.PictureOptionsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPictureOptions(DocumentFormat.OpenXml.Drawing.Charts.DataPoint? openXmlElement, DocumentModel.Drawings.Charts.PictureOptions? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.PictureOptionsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public static DocumentModel.Drawings.Charts.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.DataPoint? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.DataPoint? openXmlElement, DocumentModel.Drawings.Charts.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.Charts.DataPoint? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.DataPoint? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.DataPoint();
      value.Index = GetIndex(openXmlElement);
      value.InvertIfNegative = GetInvertIfNegative(openXmlElement);
      value.Marker = GetMarker(openXmlElement);
      value.Bubble3D = GetBubble3D(openXmlElement);
      value.Explosion = GetExplosion(openXmlElement);
      value.ChartShapeProperties = GetChartShapeProperties(openXmlElement);
      value.PictureOptions = GetPictureOptions(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.DataPoint? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.DataPoint, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
