using DocumentFormat.OpenXml.Drawing;
using AdjustPoint2DType = DocumentModel.Drawings.AdjustPoint2DType;
using CubicBezierCurveTo = DocumentFormat.OpenXml.Drawing.CubicBezierCurveTo;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Draw Cubic Bezier Curve To.
/// </summary>
public static class CubicBezierCurveToConverter
{
  public static Collection<AdjustPoint2DType>? GetPoints(CubicBezierCurveTo? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<AdjustPoint2DType>();
      foreach (var item in openXmlElement.Elements<Point>())
      {
        var newItem = AdjustPoint2DTypeConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetPoints(CubicBezierCurveTo? openXmlElement, Collection<AdjustPoint2DType>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<Point>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = AdjustPoint2DTypeConverter.CreateOpenXmlElement<Point>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.CubicBezierCurveTo? CreateModelElement(CubicBezierCurveTo? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.CubicBezierCurveTo();
      value.Points = GetPoints(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.CubicBezierCurveTo? value)
    where OpenXmlElementType : CubicBezierCurveTo, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPoints(openXmlElement, value?.Points);
      return openXmlElement;
    }
    return default;
  }
}