namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the SdtContentDocPartList Class.
/// </summary>
public static class SdtContentDocPartListConverter
{
  private static String? GetDocPartGallery(DXW.SdtContentDocPartList openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DocPartGallery>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetDocPartGallery(DXW.SdtContentDocPartList openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DocPartGallery>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.DocPartGallery { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static String? GetDocPartCategory(DXW.SdtContentDocPartList openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DocPartCategory>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetDocPartCategory(DXW.SdtContentDocPartList openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DocPartCategory>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.DocPartCategory { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetDocPartUnique(DXW.SdtContentDocPartList openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DocPartUnique>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetDocPartUnique(DXW.SdtContentDocPartList openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.DocPartUnique>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.DocPartUnique();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.SdtContentDocPartList? CreateModelElement(DXW.SdtContentDocPartList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.SdtContentDocPartList();
      value.DocPartGallery = GetDocPartGallery(openXmlElement);
      value.DocPartCategory = GetDocPartCategory(openXmlElement);
      value.DocPartUnique = GetDocPartUnique(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.SdtContentDocPartList? value)
    where OpenXmlElementType: DXW.SdtContentDocPartList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDocPartGallery(openXmlElement, value?.DocPartGallery);
      SetDocPartCategory(openXmlElement, value?.DocPartCategory);
      SetDocPartUnique(openXmlElement, value?.DocPartUnique);
      return openXmlElement;
    }
    return default;
  }
}
