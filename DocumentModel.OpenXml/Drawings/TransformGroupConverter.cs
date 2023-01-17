namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// 2D Transform for Grouped Objects.
/// </summary>
public static class TransformGroupConverter
{
  /// <summary>
  /// Rotation
  /// </summary>
  private static Int32? GetRotation(DocumentFormat.OpenXml.Drawing.TransformGroup openXmlElement)
  {
    return openXmlElement.Rotation?.Value;
  }
  
  private static void SetRotation(DocumentFormat.OpenXml.Drawing.TransformGroup openXmlElement, Int32? value)
  {
    openXmlElement.Rotation = value;
  }
  
  /// <summary>
  /// Horizontal Flip
  /// </summary>
  private static Boolean? GetHorizontalFlip(DocumentFormat.OpenXml.Drawing.TransformGroup openXmlElement)
  {
    return openXmlElement?.HorizontalFlip?.Value;
  }
  
  private static void SetHorizontalFlip(DocumentFormat.OpenXml.Drawing.TransformGroup openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.HorizontalFlip = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.HorizontalFlip = null;
  }
  
  /// <summary>
  /// Vertical Flip
  /// </summary>
  private static Boolean? GetVerticalFlip(DocumentFormat.OpenXml.Drawing.TransformGroup openXmlElement)
  {
    return openXmlElement?.VerticalFlip?.Value;
  }
  
  private static void SetVerticalFlip(DocumentFormat.OpenXml.Drawing.TransformGroup openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.VerticalFlip = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.VerticalFlip = null;
  }
  
  /// <summary>
  /// Offset.
  /// </summary>
  private static DocumentModel.Drawings.Point2DType? GetOffset(DocumentFormat.OpenXml.Drawing.TransformGroup openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Offset>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Point2DTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetOffset(DocumentFormat.OpenXml.Drawing.TransformGroup openXmlElement, DocumentModel.Drawings.Point2DType? value)
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
  private static DocumentModel.Drawings.PositiveSize2DType? GetExtents(DocumentFormat.OpenXml.Drawing.TransformGroup openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Extents>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.PositiveSize2DTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtents(DocumentFormat.OpenXml.Drawing.TransformGroup openXmlElement, DocumentModel.Drawings.PositiveSize2DType? value)
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
  
  /// <summary>
  /// Child Offset.
  /// </summary>
  private static DocumentModel.Drawings.Point2DType? GetChildOffset(DocumentFormat.OpenXml.Drawing.TransformGroup openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChildOffset>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Point2DTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetChildOffset(DocumentFormat.OpenXml.Drawing.TransformGroup openXmlElement, DocumentModel.Drawings.Point2DType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChildOffset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Point2DTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ChildOffset>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Child Extents.
  /// </summary>
  private static DocumentModel.Drawings.PositiveSize2DType? GetChildExtents(DocumentFormat.OpenXml.Drawing.TransformGroup openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChildExtents>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.PositiveSize2DTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetChildExtents(DocumentFormat.OpenXml.Drawing.TransformGroup openXmlElement, DocumentModel.Drawings.PositiveSize2DType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChildExtents>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.PositiveSize2DTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ChildExtents>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.TransformGroup? CreateModelElement(DocumentFormat.OpenXml.Drawing.TransformGroup? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.TransformGroup();
      value.Rotation = GetRotation(openXmlElement);
      value.HorizontalFlip = GetHorizontalFlip(openXmlElement);
      value.VerticalFlip = GetVerticalFlip(openXmlElement);
      value.Offset = GetOffset(openXmlElement);
      value.Extents = GetExtents(openXmlElement);
      value.ChildOffset = GetChildOffset(openXmlElement);
      value.ChildExtents = GetChildExtents(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.TransformGroup? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.TransformGroup, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRotation(openXmlElement, value?.Rotation);
      SetHorizontalFlip(openXmlElement, value?.HorizontalFlip);
      SetVerticalFlip(openXmlElement, value?.VerticalFlip);
      SetOffset(openXmlElement, value?.Offset);
      SetExtents(openXmlElement, value?.Extents);
      SetChildOffset(openXmlElement, value?.ChildOffset);
      SetChildExtents(openXmlElement, value?.ChildExtents);
      return openXmlElement;
    }
    return default;
  }
}
