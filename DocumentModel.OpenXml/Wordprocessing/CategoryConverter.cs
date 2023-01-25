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
    return openXmlElement.GetFirstChild<DXW.Name>()?.Val?.Value;
  }
  
  private static bool CmpName(DXW.Category openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Name>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "Name", itemElement?.Val?.Value, value);
    return false;
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
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.DocPartGalleryValues, DMW.DocPartGalleryKind>(openXmlElement.GetFirstChild<DXW.Gallery>()?.Val?.Value);
  }
  
  private static bool CmpGallery(DXW.Category openXmlElement, DMW.DocPartGalleryKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.DocPartGalleryValues, DMW.DocPartGalleryKind>(openXmlElement.GetFirstChild<DXW.Gallery>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static bool CompareModelElement(DXW.Category? openXmlElement, DMW.Category? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpName(openXmlElement, value.Name, diffs, objName))
        ok = false;
      if (!CmpGallery(openXmlElement, value.Gallery, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
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
