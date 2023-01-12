namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// 2D Transform for Grouped Objects.
/// </summary>
public static class TransformGroupConverter
{
  /// <summary>
  /// Rotation
  /// </summary>
  public static Int32? GetRotation(DocumentFormat.OpenXml.Drawing.TransformGroup? openXmlElement)
  {
    return openXmlElement?.Rotation?.Value;
  }
  
  public static void SetRotation(DocumentFormat.OpenXml.Drawing.TransformGroup? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Rotation = value;
  }
  
  /// <summary>
  /// Horizontal Flip
  /// </summary>
  public static Boolean? GetHorizontalFlip(DocumentFormat.OpenXml.Drawing.TransformGroup? openXmlElement)
  {
    return openXmlElement?.HorizontalFlip?.Value;
  }
  
  public static void SetHorizontalFlip(DocumentFormat.OpenXml.Drawing.TransformGroup? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.HorizontalFlip = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.HorizontalFlip = null;
  }
  
  /// <summary>
  /// Vertical Flip
  /// </summary>
  public static Boolean? GetVerticalFlip(DocumentFormat.OpenXml.Drawing.TransformGroup? openXmlElement)
  {
    return openXmlElement?.VerticalFlip?.Value;
  }
  
  public static void SetVerticalFlip(DocumentFormat.OpenXml.Drawing.TransformGroup? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.VerticalFlip = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.VerticalFlip = null;
  }
  
  /// <summary>
  /// Offset.
  /// </summary>
  public static DocumentModel.Drawings.Point2DType? GetOffset(DocumentFormat.OpenXml.Drawing.TransformGroup? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Offset>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Point2DTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetOffset(DocumentFormat.OpenXml.Drawing.TransformGroup? openXmlElement, DocumentModel.Drawings.Point2DType? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Extents.
  /// </summary>
  public static DocumentModel.Drawings.PositiveSize2DType? GetExtents(DocumentFormat.OpenXml.Drawing.TransformGroup? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Extents>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.PositiveSize2DTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtents(DocumentFormat.OpenXml.Drawing.TransformGroup? openXmlElement, DocumentModel.Drawings.PositiveSize2DType? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Child Offset.
  /// </summary>
  public static DocumentModel.Drawings.Point2DType? GetChildOffset(DocumentFormat.OpenXml.Drawing.TransformGroup? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChildOffset>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Point2DTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetChildOffset(DocumentFormat.OpenXml.Drawing.TransformGroup? openXmlElement, DocumentModel.Drawings.Point2DType? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Child Extents.
  /// </summary>
  public static DocumentModel.Drawings.PositiveSize2DType? GetChildExtents(DocumentFormat.OpenXml.Drawing.TransformGroup? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChildExtents>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.PositiveSize2DTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetChildExtents(DocumentFormat.OpenXml.Drawing.TransformGroup? openXmlElement, DocumentModel.Drawings.PositiveSize2DType? value)
  {
    if (openXmlElement != null)
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
