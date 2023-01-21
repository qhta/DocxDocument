namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Entry Categorization.
/// </summary>
public static class CategoryConverter
{
  /// <summary>
  /// Category Associated With Entry.
  /// </summary>
  private static String? GetName(DXW.Category openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Name>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetName(DXW.Category openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Name>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.Name { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Gallery Associated With Entry.
  /// </summary>
  private static DMW.DocPartGalleryKind? GetGallery(DXW.Category openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Gallery>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.DocPartGalleryValues, DMW.DocPartGalleryKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetGallery(DXW.Category openXmlElement, DMW.DocPartGalleryKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Gallery>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.Gallery, DocumentFormat.OpenXml.Wordprocessing.DocPartGalleryValues, DMW.DocPartGalleryKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.Category? CreateModelElement(DXW.Category? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Category();
      value.Name = GetName(openXmlElement);
      value.Gallery = GetGallery(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Category? value)
    where OpenXmlElementType: DXW.Category, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetName(openXmlElement, value?.Name);
      SetGallery(openXmlElement, value?.Gallery);
      return openXmlElement;
    }
    return default;
  }
}
