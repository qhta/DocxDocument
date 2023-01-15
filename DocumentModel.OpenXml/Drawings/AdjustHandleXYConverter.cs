using DocumentFormat.OpenXml.Drawing;
using AdjustPoint2DType = DocumentModel.Drawings.AdjustPoint2DType;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   XY Adjust Handle.
/// </summary>
public static class AdjustHandleXYConverter
{
  /// <summary>
  ///   Horizontal Adjustment Guide
  /// </summary>
  public static String? GetXAdjustmentGuide(AdjustHandleXY? openXmlElement)
  {
    return openXmlElement?.XAdjustmentGuide?.Value;
  }

  public static void SetXAdjustmentGuide(AdjustHandleXY? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.XAdjustmentGuide = new StringValue { Value = value };
      else
        openXmlElement.XAdjustmentGuide = null;
  }

  /// <summary>
  ///   Minimum Horizontal Adjustment
  /// </summary>
  public static String? GetMinX(AdjustHandleXY? openXmlElement)
  {
    return openXmlElement?.MinX?.Value;
  }

  public static void SetMinX(AdjustHandleXY? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.MinX = new StringValue { Value = value };
      else
        openXmlElement.MinX = null;
  }

  /// <summary>
  ///   Maximum Horizontal Adjustment
  /// </summary>
  public static String? GetMaxX(AdjustHandleXY? openXmlElement)
  {
    return openXmlElement?.MaxX?.Value;
  }

  public static void SetMaxX(AdjustHandleXY? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.MaxX = new StringValue { Value = value };
      else
        openXmlElement.MaxX = null;
  }

  /// <summary>
  ///   Vertical Adjustment Guide
  /// </summary>
  public static String? GetYAdjustmentGuide(AdjustHandleXY? openXmlElement)
  {
    return openXmlElement?.YAdjustmentGuide?.Value;
  }

  public static void SetYAdjustmentGuide(AdjustHandleXY? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.YAdjustmentGuide = new StringValue { Value = value };
      else
        openXmlElement.YAdjustmentGuide = null;
  }

  /// <summary>
  ///   Minimum Vertical Adjustment
  /// </summary>
  public static String? GetMinY(AdjustHandleXY? openXmlElement)
  {
    return openXmlElement?.MinY?.Value;
  }

  public static void SetMinY(AdjustHandleXY? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.MinY = new StringValue { Value = value };
      else
        openXmlElement.MinY = null;
  }

  /// <summary>
  ///   Maximum Vertical Adjustment
  /// </summary>
  public static String? GetMaxY(AdjustHandleXY? openXmlElement)
  {
    return openXmlElement?.MaxY?.Value;
  }

  public static void SetMaxY(AdjustHandleXY? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.MaxY = new StringValue { Value = value };
      else
        openXmlElement.MaxY = null;
  }

  /// <summary>
  ///   Position.
  /// </summary>
  public static AdjustPoint2DType? GetPosition(AdjustHandleXY? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Position>();
    if (itemElement != null)
      return AdjustPoint2DTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPosition(AdjustHandleXY? openXmlElement, AdjustPoint2DType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Position>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AdjustPoint2DTypeConverter.CreateOpenXmlElement<Position>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.AdjustHandleXY? CreateModelElement(AdjustHandleXY? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.AdjustHandleXY();
      value.XAdjustmentGuide = GetXAdjustmentGuide(openXmlElement);
      value.MinX = GetMinX(openXmlElement);
      value.MaxX = GetMaxX(openXmlElement);
      value.YAdjustmentGuide = GetYAdjustmentGuide(openXmlElement);
      value.MinY = GetMinY(openXmlElement);
      value.MaxY = GetMaxY(openXmlElement);
      value.Position = GetPosition(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.AdjustHandleXY? value)
    where OpenXmlElementType : AdjustHandleXY, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetXAdjustmentGuide(openXmlElement, value?.XAdjustmentGuide);
      SetMinX(openXmlElement, value?.MinX);
      SetMaxX(openXmlElement, value?.MaxX);
      SetYAdjustmentGuide(openXmlElement, value?.YAdjustmentGuide);
      SetMinY(openXmlElement, value?.MinY);
      SetMaxY(openXmlElement, value?.MaxY);
      SetPosition(openXmlElement, value?.Position);
      return openXmlElement;
    }
    return default;
  }
}