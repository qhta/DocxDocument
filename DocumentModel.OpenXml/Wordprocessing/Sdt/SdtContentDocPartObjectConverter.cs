namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the SdtContentDocPartObject Class.
/// </summary>
public static class SdtContentDocPartObjectConverter
{
  private static String? GetDocPartGallery(DXW.SdtContentDocPartObject openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.DocPartGallery>()?.Val?.Value;
  }
  
  private static bool CmpDocPartGallery(DXW.SdtContentDocPartObject openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DocPartGallery>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DocPartGallery", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetDocPartGallery(DXW.SdtContentDocPartObject openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DocPartGallery>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.DocPartGallery { Val = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static String? GetDocPartCategory(DXW.SdtContentDocPartObject openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.DocPartCategory>()?.Val?.Value;
  }
  
  private static bool CmpDocPartCategory(DXW.SdtContentDocPartObject openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DocPartCategory>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DocPartCategory", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetDocPartCategory(DXW.SdtContentDocPartObject openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DocPartCategory>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.DocPartCategory { Val = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetDocPartUnique(DXW.SdtContentDocPartObject openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.DocPartUnique>());
  }
  
  private static bool CmpDocPartUnique(DXW.SdtContentDocPartObject openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.DocPartUnique>(), value, diffs, objName, propName);
  }
  
  private static void SetDocPartUnique(DXW.SdtContentDocPartObject openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.DocPartUnique>(openXmlElement, value, "0", null);
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
  
  public static bool CompareModelElement(DXW.SdtContentDocPartObject? openXmlElement, DMW.SdtContentDocPartObject? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDocPartGallery(openXmlElement, value.DocPartGallery, diffs, objName, propName))
        ok = false;
      if (!CmpDocPartCategory(openXmlElement, value.DocPartCategory, diffs, objName, propName))
        ok = false;
      if (!CmpDocPartUnique(openXmlElement, value.DocPartUnique, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.SdtContentDocPartObject value)
    where OpenXmlElementType: DXW.SdtContentDocPartObject, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.SdtContentDocPartObject openXmlElement, DMW.SdtContentDocPartObject value)
  {
    SetDocPartGallery(openXmlElement, value?.DocPartGallery);
    SetDocPartCategory(openXmlElement, value?.DocPartCategory);
    SetDocPartUnique(openXmlElement, value?.DocPartUnique);
  }
}
