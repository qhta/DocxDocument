namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the Transform2D Class.
/// </summary>
public static class Transform2DConverter
{
  /// <summary>
  /// Rotation
  /// </summary>
  public static Int32? GetRotation(DocumentFormat.OpenXml.Drawing.Transform2D? openXmlElement)
  {
    return openXmlElement?.Rotation?.Value;
  }
  
  public static void SetRotation(DocumentFormat.OpenXml.Drawing.Transform2D? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Rotation = value;
  }
  
  /// <summary>
  /// Horizontal Flip
  /// </summary>
  public static Boolean? GetHorizontalFlip(DocumentFormat.OpenXml.Drawing.Transform2D? openXmlElement)
  {
    return openXmlElement?.HorizontalFlip?.Value;
  }
  
  public static void SetHorizontalFlip(DocumentFormat.OpenXml.Drawing.Transform2D? openXmlElement, Boolean? value)
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
  public static Boolean? GetVerticalFlip(DocumentFormat.OpenXml.Drawing.Transform2D? openXmlElement)
  {
    return openXmlElement?.VerticalFlip?.Value;
  }
  
  public static void SetVerticalFlip(DocumentFormat.OpenXml.Drawing.Transform2D? openXmlElement, Boolean? value)
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
  public static DocumentModel.Drawings.Point2DType? GetOffset(DocumentFormat.OpenXml.Drawing.Transform2D? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Offset>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Point2DTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetOffset(DocumentFormat.OpenXml.Drawing.Transform2D? openXmlElement, DocumentModel.Drawings.Point2DType? value)
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
  public static DocumentModel.Drawings.PositiveSize2DType? GetExtents(DocumentFormat.OpenXml.Drawing.Transform2D? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Extents>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.PositiveSize2DTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtents(DocumentFormat.OpenXml.Drawing.Transform2D? openXmlElement, DocumentModel.Drawings.PositiveSize2DType? value)
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
  
  public static DocumentModel.Drawings.Transform2D? CreateModelElement(DocumentFormat.OpenXml.Drawing.Transform2D? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Transform2D();
      value.Rotation = GetRotation(openXmlElement);
      value.HorizontalFlip = GetHorizontalFlip(openXmlElement);
      value.VerticalFlip = GetVerticalFlip(openXmlElement);
      value.Offset = GetOffset(openXmlElement);
      value.Extents = GetExtents(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Transform2D? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Transform2D, new()
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
