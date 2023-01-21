namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the SdtContentDocPartObject Class.
/// </summary>
public static class SdtContentDocPartObjectConverter
{
  private static String? GetDocPartGallery(DXW.SdtContentDocPartObject openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DocPartGallery>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetDocPartGallery(DXW.SdtContentDocPartObject openXmlElement, String? value)
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
  
  private static String? GetDocPartCategory(DXW.SdtContentDocPartObject openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DocPartCategory>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetDocPartCategory(DXW.SdtContentDocPartObject openXmlElement, String? value)
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
  
  private static Boolean? GetDocPartUnique(DXW.SdtContentDocPartObject openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DocPartUnique>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetDocPartUnique(DXW.SdtContentDocPartObject openXmlElement, Boolean? value)
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
  
  public static DMW.SdtContentDocPartObject? CreateModelElement(DXW.SdtContentDocPartObject? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.SdtContentDocPartObject();
      value.DocPartGallery = GetDocPartGallery(openXmlElement);
      value.DocPartCategory = GetDocPartCategory(openXmlElement);
      value.DocPartUnique = GetDocPartUnique(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.SdtContentDocPartObject? value)
    where OpenXmlElementType: DXW.SdtContentDocPartObject, new()
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
