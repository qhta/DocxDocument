namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the ExtensionList Class.
/// </summary>
public static class ExtensionListConverter
{
  private static Collection<DMW.Extension> GetExtensions(DXO2021WComtExt.ExtensionList openXmlElement)
  {
    var collection = new Collection<DMW.Extension>();
    foreach (var item in openXmlElement.Elements<DXO2021WExtList.Extension>())
    {
      var newItem = DMXW.ExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetExtensions(DXO2021WComtExt.ExtensionList openXmlElement, Collection<DMW.Extension>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2021WExtList.Extension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.ExtensionConverter.CreateOpenXmlElement<DXO2021WExtList.Extension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMW.ExtensionList? CreateModelElement(DXO2021WComtExt.ExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.ExtensionList();
      value.Extensions = GetExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.ExtensionList? value)
    where OpenXmlElementType: DXO2021WComtExt.ExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetExtensions(openXmlElement, value?.Extensions);
      return openXmlElement;
    }
    return default;
  }
}
