namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ExtraColorSchemeList Class.
/// </summary>
public static class ExtraColorSchemeListConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ExtraColorScheme>? GetExtraColorSchemes(DocumentFormat.OpenXml.Drawing.ExtraColorSchemeList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ExtraColorScheme>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.ExtraColorScheme>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.ExtraColorSchemeConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetExtraColorSchemes(DocumentFormat.OpenXml.Drawing.ExtraColorSchemeList? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ExtraColorScheme>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.ExtraColorScheme>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.ExtraColorSchemeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ExtraColorScheme>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.ExtraColorSchemeList? CreateModelElement(DocumentFormat.OpenXml.Drawing.ExtraColorSchemeList? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.ExtraColorSchemeList, new()
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
