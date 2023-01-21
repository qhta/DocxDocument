namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the CustomColorList Class.
/// </summary>
public static class CustomColorListConverter
{
  private static Collection<DMDraws.CustomColor> GetCustomColors(DXDraw.CustomColorList openXmlElement)
  {
    var collection = new Collection<DMDraws.CustomColor>();
    foreach (var item in openXmlElement.Elements<DXDraw.CustomColor>())
    {
      var newItem = DMXDraws.CustomColorConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetCustomColors(DXDraw.CustomColorList openXmlElement, Collection<DMDraws.CustomColor>? value)
  {
    openXmlElement.RemoveAllChildren<DXDraw.CustomColor>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDraws.CustomColorConverter.CreateOpenXmlElement<DXDraw.CustomColor>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDraws.CustomColorList? CreateModelElement(DXDraw.CustomColorList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.CustomColorList();
      value.CustomColors = GetCustomColors(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.CustomColorList? value)
    where OpenXmlElementType: DXDraw.CustomColorList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetCustomColors(openXmlElement, value?.CustomColors);
      return openXmlElement;
    }
    return default;
  }
}
