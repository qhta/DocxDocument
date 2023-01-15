using DocumentFormat.OpenXml.Drawing;
using Point2DType = DocumentModel.Drawings.Point2DType;
using PositiveSize2DType = DocumentModel.Drawings.PositiveSize2DType;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   2D Transform for Grouped Objects.
/// </summary>
public static class TransformGroupConverter
{
  /// <summary>
  ///   Rotation
  /// </summary>
  public static Int32? GetRotation(TransformGroup? openXmlElement)
  {
    return openXmlElement?.Rotation?.Value;
  }

  public static void SetRotation(TransformGroup? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Rotation = value;
  }

  /// <summary>
  ///   Horizontal Flip
  /// </summary>
  public static Boolean? GetHorizontalFlip(TransformGroup? openXmlElement)
  {
    return openXmlElement?.HorizontalFlip?.Value;
  }

  public static void SetHorizontalFlip(TransformGroup? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.HorizontalFlip = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.HorizontalFlip = null;
  }

  /// <summary>
  ///   Vertical Flip
  /// </summary>
  public static Boolean? GetVerticalFlip(TransformGroup? openXmlElement)
  {
    return openXmlElement?.VerticalFlip?.Value;
  }

  public static void SetVerticalFlip(TransformGroup? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.VerticalFlip = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.VerticalFlip = null;
  }

  /// <summary>
  ///   Offset.
  /// </summary>
  public static Point2DType? GetOffset(TransformGroup? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Offset>();
    if (itemElement != null)
      return Point2DTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetOffset(TransformGroup? openXmlElement, Point2DType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Offset>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Point2DTypeConverter.CreateOpenXmlElement<Offset>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Extents.
  /// </summary>
  public static PositiveSize2DType? GetExtents(TransformGroup? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Extents>();
    if (itemElement != null)
      return PositiveSize2DTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtents(TransformGroup? openXmlElement, PositiveSize2DType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Extents>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PositiveSize2DTypeConverter.CreateOpenXmlElement<Extents>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Child Offset.
  /// </summary>
  public static Point2DType? GetChildOffset(TransformGroup? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<ChildOffset>();
    if (itemElement != null)
      return Point2DTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetChildOffset(TransformGroup? openXmlElement, Point2DType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ChildOffset>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Point2DTypeConverter.CreateOpenXmlElement<ChildOffset>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Child Extents.
  /// </summary>
  public static PositiveSize2DType? GetChildExtents(TransformGroup? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<ChildExtents>();
    if (itemElement != null)
      return PositiveSize2DTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetChildExtents(TransformGroup? openXmlElement, PositiveSize2DType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ChildExtents>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PositiveSize2DTypeConverter.CreateOpenXmlElement<ChildExtents>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.TransformGroup? CreateModelElement(TransformGroup? openXmlElement)
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
    where OpenXmlElementType : TransformGroup, new()
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