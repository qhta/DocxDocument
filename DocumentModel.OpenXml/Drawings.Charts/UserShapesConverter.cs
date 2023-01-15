using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentModel.Drawings.ChartDrawing;
using DocumentModel.OpenXml.Drawings.ChartDrawing;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   User Shapes.
/// </summary>
public static class UserShapesConverter
{
  public static RelativeAnchorSize? GetRelativeAnchorSize(UserShapes? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.RelativeAnchorSize>();
    if (itemElement != null)
      return RelativeAnchorSizeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRelativeAnchorSize(UserShapes? openXmlElement, RelativeAnchorSize? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.RelativeAnchorSize>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RelativeAnchorSizeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.RelativeAnchorSize>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static AbsoluteAnchorSize? GetAbsoluteAnchorSize(UserShapes? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.AbsoluteAnchorSize>();
    if (itemElement != null)
      return AbsoluteAnchorSizeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetAbsoluteAnchorSize(UserShapes? openXmlElement, AbsoluteAnchorSize? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.AbsoluteAnchorSize>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AbsoluteAnchorSizeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.AbsoluteAnchorSize>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.UserShapes? CreateModelElement(UserShapes? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.UserShapes();
      value.RelativeAnchorSize = GetRelativeAnchorSize(openXmlElement);
      value.AbsoluteAnchorSize = GetAbsoluteAnchorSize(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.UserShapes? value)
    where OpenXmlElementType : UserShapes, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRelativeAnchorSize(openXmlElement, value?.RelativeAnchorSize);
      SetAbsoluteAnchorSize(openXmlElement, value?.AbsoluteAnchorSize);
      return openXmlElement;
    }
    return default;
  }
}