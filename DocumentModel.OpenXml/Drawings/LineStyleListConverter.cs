using DocumentModel.Drawings;
using LineStyleList = DocumentFormat.OpenXml.Drawing.LineStyleList;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Line Style List.
/// </summary>
public static class LineStyleListConverter
{
  public static Outline? GetOutline(LineStyleList? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Outline>();
    if (itemElement != null)
      return OutlineConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetOutline(LineStyleList? openXmlElement, Outline? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Outline>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OutlineConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Outline>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.LineStyleList? CreateModelElement(LineStyleList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.LineStyleList();
      value.Outline = GetOutline(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.LineStyleList? value)
    where OpenXmlElementType : LineStyleList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetOutline(openXmlElement, value?.Outline);
      return openXmlElement;
    }
    return default;
  }
}