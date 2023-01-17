namespace DocumentModel.OpenXml.Drawings.Office;

/// <summary>
/// Defines the Transform2D Class.
/// </summary>
public static class Transform2DConverter
{
  /// <summary>
  /// Rotation
  /// </summary>
  private static Int32? GetRotation(DocumentFormat.OpenXml.Office.Drawing.Transform2D openXmlElement)
  {
    return openXmlElement.Rotation?.Value;
  }
  
  private static void SetRotation(DocumentFormat.OpenXml.Office.Drawing.Transform2D openXmlElement, Int32? value)
  {
    openXmlElement.Rotation = value;
  }
  
  /// <summary>
  /// Horizontal Flip
  /// </summary>
  private static Boolean? GetHorizontalFlip(DocumentFormat.OpenXml.Office.Drawing.Transform2D openXmlElement)
  {
    return openXmlElement?.HorizontalFlip?.Value;
  }
  
  private static void SetHorizontalFlip(DocumentFormat.OpenXml.Office.Drawing.Transform2D openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.HorizontalFlip = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.HorizontalFlip = null;
  }
  
  /// <summary>
  /// Vertical Flip
  /// </summary>
  private static Boolean? GetVerticalFlip(DocumentFormat.OpenXml.Office.Drawing.Transform2D openXmlElement)
  {
    return openXmlElement?.VerticalFlip?.Value;
  }
  
  private static void SetVerticalFlip(DocumentFormat.OpenXml.Office.Drawing.Transform2D openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.VerticalFlip = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.VerticalFlip = null;
  }
  
  /// <summary>
  /// Offset.
  /// </summary>
  private static DocumentModel.Drawings.Point2DType? GetOffset(DocumentFormat.OpenXml.Office.Drawing.Transform2D openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Offset>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Point2DTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetOffset(DocumentFormat.OpenXml.Office.Drawing.Transform2D openXmlElement, DocumentModel.Drawings.Point2DType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Offset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Point2DTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Offset>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Extents.
  /// </summary>
  private static DocumentModel.Drawings.PositiveSize2DType? GetExtents(DocumentFormat.OpenXml.Office.Drawing.Transform2D openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Extents>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.PositiveSize2DTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtents(DocumentFormat.OpenXml.Office.Drawing.Transform2D openXmlElement, DocumentModel.Drawings.PositiveSize2DType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Extents>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.PositiveSize2DTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Extents>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Office.Transform2D? CreateModelElement(DocumentFormat.OpenXml.Office.Drawing.Transform2D? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Office.Transform2D();
      value.Rotation = GetRotation(openXmlElement);
      value.HorizontalFlip = GetHorizontalFlip(openXmlElement);
      value.VerticalFlip = GetVerticalFlip(openXmlElement);
      value.Offset = GetOffset(openXmlElement);
      value.Extents = GetExtents(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Office.Transform2D? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office.Drawing.Transform2D, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRotation(openXmlElement, value?.Rotation);
      SetHorizontalFlip(openXmlElement, value?.HorizontalFlip);
      SetVerticalFlip(openXmlElement, value?.VerticalFlip);
      SetOffset(openXmlElement, value?.Offset);
      SetExtents(openXmlElement, value?.Extents);
      return openXmlElement;
    }
    return default;
  }
}
