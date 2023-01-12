namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Draw Quadratic Bezier Curve To.
/// </summary>
public static class QuadraticBezierCurveToConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.AdjustPoint2DType>? GetPoints(DocumentFormat.OpenXml.Drawing.QuadraticBezierCurveTo? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.AdjustPoint2DType>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Point>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.AdjustPoint2DTypeConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetPoints(DocumentFormat.OpenXml.Drawing.QuadraticBezierCurveTo? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.AdjustPoint2DType>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Point>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.AdjustPoint2DTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Point>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.QuadraticBezierCurveTo? CreateModelElement(DocumentFormat.OpenXml.Drawing.QuadraticBezierCurveTo? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.QuadraticBezierCurveTo, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
