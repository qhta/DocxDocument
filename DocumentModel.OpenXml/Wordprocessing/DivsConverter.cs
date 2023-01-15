using DocumentModel.Wordprocessing;
using Divs = DocumentFormat.OpenXml.Wordprocessing.Divs;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the Divs Class.
/// </summary>
public static class DivsConverter
{
  public static Div? GetDiv(Divs? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Div>();
    if (itemElement != null)
      return DivConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDiv(Divs? openXmlElement, Div? value)
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

  public static DocumentModel.Wordprocessing.Divs? CreateModelElement(Divs? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Divs();
      value.Div = GetDiv(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Divs? value)
    where OpenXmlElementType : Divs, new()
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