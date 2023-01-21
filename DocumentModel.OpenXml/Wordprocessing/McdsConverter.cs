namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Mcds Class.
/// </summary>
public static class McdsConverter
{
  private static Collection<DMW.Mcd> GetItems(DXOW.Mcds openXmlElement)
  {
    var collection = new Collection<DMW.Mcd>();
    foreach (var item in openXmlElement.Elements<DXOW.Mcd>())
    {
      var newItem = DMXW.McdConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetItems(DXOW.Mcds openXmlElement, Collection<DMW.Mcd>? value)
  {
    openXmlElement.RemoveAllChildren<DXOW.Mcd>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.McdConverter.CreateOpenXmlElement<DXOW.Mcd>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMW.Mcds? CreateModelElement(DXOW.Mcds? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Mcds();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Mcds? value)
    where OpenXmlElementType: DXOW.Mcds, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetItems(openXmlElement, value?.Items);
      return openXmlElement;
    }
    return default;
  }
}
