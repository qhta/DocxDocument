using DocumentFormat.OpenXml.Drawing;
using AdjustPoint2DType = DocumentModel.Drawings.AdjustPoint2DType;
using MoveTo = DocumentFormat.OpenXml.Drawing.MoveTo;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Move Path To.
/// </summary>
public static class MoveToConverter
{
  /// <summary>
  ///   Move end point.
  /// </summary>
  public static AdjustPoint2DType? GetPoint(MoveTo? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Point>();
    if (itemElement != null)
      return AdjustPoint2DTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPoint(MoveTo? openXmlElement, AdjustPoint2DType? value)
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

  public static DocumentModel.Drawings.MoveTo? CreateModelElement(MoveTo? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.MoveTo();
      value.Point = GetPoint(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.MoveTo? value)
    where OpenXmlElementType : MoveTo, new()
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