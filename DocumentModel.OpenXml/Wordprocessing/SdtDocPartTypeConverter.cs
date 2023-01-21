namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the SdtDocPartType Class.
/// </summary>
public static class SdtDocPartTypeConverter
{
  /// <summary>
  /// Document Part Gallery Filter.
  /// </summary>
  private static String? GetDocPartGallery(DXW.SdtDocPartType openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DocPartGallery>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetDocPartGallery(DXW.SdtDocPartType openXmlElement, String? value)
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
  
  /// <summary>
  /// Document Part Category Filter.
  /// </summary>
  private static String? GetDocPartCategory(DXW.SdtDocPartType openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DocPartCategory>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetDocPartCategory(DXW.SdtDocPartType openXmlElement, String? value)
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
  
  /// <summary>
  /// Built-In Document Part.
  /// </summary>
  private static Boolean? GetDocPartUnique(DXW.SdtDocPartType openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DocPartUnique>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetDocPartUnique(DXW.SdtDocPartType openXmlElement, Boolean? value)
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
  
  public static DMW.SdtDocPartType? CreateModelElement(DXW.SdtDocPartType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.SdtDocPartType();
      value.DocPartGallery = GetDocPartGallery(openXmlElement);
      value.DocPartCategory = GetDocPartCategory(openXmlElement);
      value.DocPartUnique = GetDocPartUnique(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.SdtDocPartType? value)
    where OpenXmlElementType: DXW.SdtDocPartType, new()
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
