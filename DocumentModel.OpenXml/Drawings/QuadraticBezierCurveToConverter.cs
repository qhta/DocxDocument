using DocumentFormat.OpenXml.Drawing;
using AdjustPoint2DType = DocumentModel.Drawings.AdjustPoint2DType;
using QuadraticBezierCurveTo = DocumentFormat.OpenXml.Drawing.QuadraticBezierCurveTo;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Draw Quadratic Bezier Curve To.
/// </summary>
public static class QuadraticBezierCurveToConverter
{
  public static Collection<AdjustPoint2DType>? GetPoints(QuadraticBezierCurveTo? openXmlElement)
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

  public static void SetPoints(QuadraticBezierCurveTo? openXmlElement, Collection<AdjustPoint2DType>? value)
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

  public static DocumentModel.Drawings.QuadraticBezierCurveTo? CreateModelElement(QuadraticBezierCurveTo? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.QuadraticBezierCurveTo();
      value.Points = GetPoints(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.QuadraticBezierCurveTo? value)
    where OpenXmlElementType : QuadraticBezierCurveTo, new()
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