using DocumentFormat.OpenXml.Drawing;
using RelativeRectangleType = DocumentModel.Drawings.RelativeRectangleType;
using Stretch = DocumentFormat.OpenXml.Drawing.Stretch;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Stretch.
/// </summary>
public static class StretchConverter
{
  /// <summary>
  ///   Fill Rectangle.
  /// </summary>
  public static RelativeRectangleType? GetFillRectangle(Stretch? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<FillRectangle>();
    if (itemElement != null)
      return RelativeRectangleTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFillRectangle(Stretch? openXmlElement, RelativeRectangleType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<FillRectangle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RelativeRectangleTypeConverter.CreateOpenXmlElement<FillRectangle>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Stretch? CreateModelElement(Stretch? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Stretch();
      value.FillRectangle = GetFillRectangle(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Stretch? value)
    where OpenXmlElementType : Stretch, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFillRectangle(openXmlElement, value?.FillRectangle);
      return openXmlElement;
    }
    return default;
  }
}