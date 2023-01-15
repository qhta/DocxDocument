using DocumentFormat.OpenXml.Drawing;
using AdjustPoint2DType = DocumentModel.Drawings.AdjustPoint2DType;
using LineTo = DocumentFormat.OpenXml.Drawing.LineTo;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Draw Line To.
/// </summary>
public static class LineToConverter
{
  /// <summary>
  ///   Line end point.
  /// </summary>
  public static AdjustPoint2DType? GetPoint(LineTo? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Point>();
    if (itemElement != null)
      return AdjustPoint2DTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPoint(LineTo? openXmlElement, AdjustPoint2DType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Point>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AdjustPoint2DTypeConverter.CreateOpenXmlElement<Point>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.LineTo? CreateModelElement(LineTo? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.LineTo();
      value.Point = GetPoint(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.LineTo? value)
    where OpenXmlElementType : LineTo, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPoint(openXmlElement, value?.Point);
      return openXmlElement;
    }
    return default;
  }
}