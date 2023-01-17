namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the CategoryFilterException Class.
/// </summary>
public static class CategoryFilterExceptionConverter
{
  /// <summary>
  /// SequenceOfReferences.
  /// </summary>
  private static String? GetSequenceOfReferences(DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterException openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.SequenceOfReferences>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetSequenceOfReferences(DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterException openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.SequenceOfReferences>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Office2013.Drawing.Chart.SequenceOfReferences { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  private static DocumentModel.Drawings.Charts.ShapeProperties3? GetShapeProperties(DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterException openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ShapeProperties3Converter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShapeProperties(DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterException openXmlElement, DocumentModel.Drawings.Charts.ShapeProperties3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.ShapeProperties3Converter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Explosion.
  /// </summary>
  private static UInt32? GetExplosion(DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterException openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.Explosion>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetExplosion(DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterException openXmlElement, UInt32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.Explosion>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Office2013.Drawing.Chart.Explosion{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// InvertIfNegativeBoolean.
  /// </summary>
  private static Boolean? GetInvertIfNegativeBoolean(DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterException openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.InvertIfNegativeBoolean>();
    return itemElement != null;
  }
  
  private static void SetInvertIfNegativeBoolean(DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterException openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.InvertIfNegativeBoolean>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Office2013.Drawing.Chart.InvertIfNegativeBoolean();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Bubble3D.
  /// </summary>
  private static Boolean? GetBubble3D(DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterException openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.Bubble3D>();
    return itemElement != null;
  }
  
  private static void SetBubble3D(DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterException openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.Bubble3D>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Office2013.Drawing.Chart.Bubble3D();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Marker.
  /// </summary>
  private static DocumentModel.Drawings.Charts.Marker3? GetMarker(DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterException openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.Marker>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.Marker3Converter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetMarker(DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterException openXmlElement, DocumentModel.Drawings.Charts.Marker3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.Marker>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.Marker3Converter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.Marker>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DataLabel.
  /// </summary>
  private static DocumentModel.Drawings.Charts.DataLabel3? GetDataLabel(DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterException openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.DataLabel3Converter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDataLabel(DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterException openXmlElement, DocumentModel.Drawings.Charts.DataLabel3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.DataLabel3Converter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.CategoryFilterException? CreateModelElement(DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterException? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.CategoryFilterException();
      value.SequenceOfReferences = GetSequenceOfReferences(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.Explosion = GetExplosion(openXmlElement);
      value.InvertIfNegativeBoolean = GetInvertIfNegativeBoolean(openXmlElement);
      value.Bubble3D = GetBubble3D(openXmlElement);
      value.Marker = GetMarker(openXmlElement);
      value.DataLabel = GetDataLabel(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.CategoryFilterException? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterException, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSequenceOfReferences(openXmlElement, value?.SequenceOfReferences);
      SetShapeProperties(openXmlElement, value?.ShapeProperties);
      SetExplosion(openXmlElement, value?.Explosion);
      SetInvertIfNegativeBoolean(openXmlElement, value?.InvertIfNegativeBoolean);
      SetBubble3D(openXmlElement, value?.Bubble3D);
      SetMarker(openXmlElement, value?.Marker);
      SetDataLabel(openXmlElement, value?.DataLabel);
      return openXmlElement;
    }
    return default;
  }
}
