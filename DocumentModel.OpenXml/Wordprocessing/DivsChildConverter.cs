using DocumentModel.Wordprocessing;
using DivsChild = DocumentFormat.OpenXml.Wordprocessing.DivsChild;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Child div Elements Contained within Current div.
/// </summary>
public static class DivsChildConverter
{
  public static Div? GetDiv(DivsChild? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Div>();
    if (itemElement != null)
      return DivConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDiv(DivsChild? openXmlElement, Div? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Div>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DivConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Div>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.DivsChild? CreateModelElement(DivsChild? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.DivsChild();
      value.Div = GetDiv(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.DivsChild? value)
    where OpenXmlElementType : DivsChild, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDiv(openXmlElement, value?.Div);
      return openXmlElement;
    }
    return default;
  }
}