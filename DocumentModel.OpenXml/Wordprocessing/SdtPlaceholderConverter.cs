namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the SdtPlaceholder Class.
/// </summary>
public static class SdtPlaceholderConverter
{
  /// <summary>
  /// Document Part Reference.
  /// </summary>
  private static String? GetDocPartReference(DXW.SdtPlaceholder openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.DocPartReference>()?.Val?.Value;
  }
  
  private static bool CmpDocPartReference(DXW.SdtPlaceholder openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DocPartReference>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DocPartReference", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetDocPartReference(DXW.SdtPlaceholder openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DocPartReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.DocPartReference { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.SdtPlaceholder? CreateModelElement(DXW.SdtPlaceholder? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.SdtPlaceholder();
      value.DocPartReference = GetDocPartReference(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.SdtPlaceholder? openXmlElement, DMW.SdtPlaceholder? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDocPartReference(openXmlElement, value.DocPartReference, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.SdtPlaceholder value)
    where OpenXmlElementType: DXW.SdtPlaceholder, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.SdtPlaceholder openXmlElement, DMW.SdtPlaceholder value)
  {
    SetDocPartReference(openXmlElement, value?.DocPartReference);
  }
}
