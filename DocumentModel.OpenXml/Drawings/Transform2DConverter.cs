using DocumentFormat.OpenXml.Drawing;
using Point2DType = DocumentModel.Drawings.Point2DType;
using PositiveSize2DType = DocumentModel.Drawings.PositiveSize2DType;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the Transform2D Class.
/// </summary>
public static class Transform2DConverter
{
  /// <summary>
  ///   Rotation
  /// </summary>
  public static Int32? GetRotation(Transform2D? openXmlElement)
  {
    return openXmlElement?.Rotation?.Value;
  }

  public static void SetRotation(Transform2D? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Rotation = value;
  }

  /// <summary>
  ///   Horizontal Flip
  /// </summary>
  public static Boolean? GetHorizontalFlip(Transform2D? openXmlElement)
  {
    return openXmlElement?.HorizontalFlip?.Value;
  }

  public static void SetHorizontalFlip(Transform2D? openXmlElement, Boolean? value)
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
  public static Boolean? GetVerticalFlip(Transform2D? openXmlElement)
  {
    return openXmlElement?.VerticalFlip?.Value;
  }

  public static void SetVerticalFlip(Transform2D? openXmlElement, Boolean? value)
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
  public static Point2DType? GetOffset(Transform2D? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Offset>();
    if (itemElement != null)
      return Point2DTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetOffset(Transform2D? openXmlElement, Point2DType? value)
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
  public static PositiveSize2DType? GetExtents(Transform2D? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Extents>();
    if (itemElement != null)
      return PositiveSize2DTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtents(Transform2D? openXmlElement, PositiveSize2DType? value)
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

  public static DocumentModel.Drawings.Transform2D? CreateModelElement(Transform2D? openXmlElement)
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
    where OpenXmlElementType : Transform2D, new()
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