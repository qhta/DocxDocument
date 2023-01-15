using DocumentModel.Drawings;
using ExtraColorSchemeList = DocumentFormat.OpenXml.Drawing.ExtraColorSchemeList;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the ExtraColorSchemeList Class.
/// </summary>
public static class ExtraColorSchemeListConverter
{
  public static Collection<ExtraColorScheme>? GetExtraColorSchemes(ExtraColorSchemeList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<ExtraColorScheme>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.ExtraColorScheme>())
      {
        var newItem = ExtraColorSchemeConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetExtraColorSchemes(ExtraColorSchemeList? openXmlElement, Collection<ExtraColorScheme>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.ExtraColorScheme>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = ExtraColorSchemeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ExtraColorScheme>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.ExtraColorSchemeList? CreateModelElement(ExtraColorSchemeList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ExtraColorSchemeList();
      value.ExtraColorSchemes = GetExtraColorSchemes(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ExtraColorSchemeList? value)
    where OpenXmlElementType : ExtraColorSchemeList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetExtraColorSchemes(openXmlElement, value?.ExtraColorSchemes);
      return openXmlElement;
    }
    return default;
  }
}