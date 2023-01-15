using DocumentModel.Drawings;
using GradientStopList = DocumentFormat.OpenXml.Drawing.GradientStopList;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Gradient Stop List.
/// </summary>
public static class GradientStopListConverter
{
  public static GradientStop? GetGradientStop(GradientStopList? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.GradientStop>();
    if (itemElement != null)
      return GradientStopConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetGradientStop(GradientStopList? openXmlElement, GradientStop? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.GradientStop>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GradientStopConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.GradientStop>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.GradientStopList? CreateModelElement(GradientStopList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.GradientStopList();
      value.GradientStop = GetGradientStop(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.GradientStopList? value)
    where OpenXmlElementType : GradientStopList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGradientStop(openXmlElement, value?.GradientStop);
      return openXmlElement;
    }
    return default;
  }
}