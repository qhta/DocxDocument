using DocumentModel.Drawings;
using EffectStyleList = DocumentFormat.OpenXml.Drawing.EffectStyleList;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Effect Style List.
/// </summary>
public static class EffectStyleListConverter
{
  public static EffectStyle? GetEffectStyle(EffectStyleList? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectStyle>();
    if (itemElement != null)
      return EffectStyleConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetEffectStyle(EffectStyleList? openXmlElement, EffectStyle? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectStyle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EffectStyleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.EffectStyle>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.EffectStyleList? CreateModelElement(EffectStyleList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.EffectStyleList();
      value.EffectStyle = GetEffectStyle(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.EffectStyleList? value)
    where OpenXmlElementType : EffectStyleList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetEffectStyle(openXmlElement, value?.EffectStyle);
      return openXmlElement;
    }
    return default;
  }
}