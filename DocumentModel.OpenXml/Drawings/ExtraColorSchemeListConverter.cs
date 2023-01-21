namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ExtraColorSchemeList Class.
/// </summary>
public static class ExtraColorSchemeListConverter
{
  private static Collection<DMDraws.ExtraColorScheme> GetExtraColorSchemes(DXDraw.ExtraColorSchemeList openXmlElement)
  {
    var collection = new Collection<DMDraws.ExtraColorScheme>();
    foreach (var item in openXmlElement.Elements<DXDraw.ExtraColorScheme>())
    {
      var newItem = DMXDraws.ExtraColorSchemeConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetExtraColorSchemes(DXDraw.ExtraColorSchemeList openXmlElement, Collection<DMDraws.ExtraColorScheme>? value)
  {
    openXmlElement.RemoveAllChildren<DXDraw.ExtraColorScheme>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDraws.ExtraColorSchemeConverter.CreateOpenXmlElement<DXDraw.ExtraColorScheme>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDraws.ExtraColorSchemeList? CreateModelElement(DXDraw.ExtraColorSchemeList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.ExtraColorSchemeList();
      value.ExtraColorSchemes = GetExtraColorSchemes(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ExtraColorSchemeList? value)
    where OpenXmlElementType: DXDraw.ExtraColorSchemeList, new()
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
