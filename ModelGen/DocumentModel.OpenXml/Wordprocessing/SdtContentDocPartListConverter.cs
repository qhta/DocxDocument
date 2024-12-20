namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the SdtContentDocPartList Class.
/// </summary>
public static class SdtContentDocPartListConverter
{
  private static String? GetDocPartGallery(DXW.SdtContentDocPartList openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.DocPartGallery>()?.Val?.Value;
  }
  
  private static bool CmpDocPartGallery(DXW.SdtContentDocPartList openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DocPartGallery>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DocPartGallery", itemElement?.Val?.Value, value);
    return false;
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
    return openXmlElement.GetFirstChild<DXW.DocPartCategory>()?.Val?.Value;
  }
  
  private static bool CmpDocPartCategory(DXW.SdtContentDocPartList openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DocPartCategory>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DocPartCategory", itemElement?.Val?.Value, value);
    return false;
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
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.DocPartUnique>());
  }
  
  private static bool CmpDocPartUnique(DXW.SdtContentDocPartList openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.DocPartUnique>(), value, diffs, objName);
  }
  
  private static void SetDocPartUnique(DXW.SdtContentDocPartList openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.DocPartUnique>(openXmlElement, value);
  }
  
  public static DocumentModel.Wordprocessing.SdtContentDocPartList? CreateModelElement(DXW.SdtContentDocPartList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.SdtContentDocPartList();
      value.DocPartGallery = GetDocPartGallery(openXmlElement);
      value.DocPartCategory = GetDocPartCategory(openXmlElement);
      value.DocPartUnique = GetDocPartUnique(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.SdtContentDocPartList? openXmlElement, DMW.SdtContentDocPartList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDocPartGallery(openXmlElement, value.DocPartGallery, diffs, objName))
        ok = false;
      if (!CmpDocPartCategory(openXmlElement, value.DocPartCategory, diffs, objName))
        ok = false;
      if (!CmpDocPartUnique(openXmlElement, value.DocPartUnique, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.SdtContentDocPartList value)
    where OpenXmlElementType: DXW.SdtContentDocPartList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.SdtContentDocPartList openXmlElement, DMW.SdtContentDocPartList value)
  {
    SetDocPartGallery(openXmlElement, value?.DocPartGallery);
    SetDocPartCategory(openXmlElement, value?.DocPartCategory);
    SetDocPartUnique(openXmlElement, value?.DocPartUnique);
  }
}
