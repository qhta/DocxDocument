namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the StrDataExtension Class.
/// </summary>
public static class StrDataExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDC.StrDataExtension openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXDC.StrDataExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXDC.StrDataExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static Boolean? GetAutoGeneneratedCategories(DXDC.StrDataExtension openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO13DC.AutoGeneneratedCategories>() != null;
  }
  
  private static bool CmpAutoGeneneratedCategories(DXDC.StrDataExtension openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXO13DC.AutoGeneneratedCategories>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO13DC.AutoGeneneratedCategories", val, value);
    return false;
  }
  
  private static void SetAutoGeneneratedCategories(DXDC.StrDataExtension openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO13DC.AutoGeneneratedCategories>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO13DC.AutoGeneneratedCategories();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.StrDataExtension? CreateModelElement(DXDC.StrDataExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.StrDataExtension();
      value.Uri = GetUri(openXmlElement);
      value.AutoGeneneratedCategories = GetAutoGeneneratedCategories(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.StrDataExtension? openXmlElement, DMDC.StrDataExtension? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName))
        ok = false;
      if (!CmpAutoGeneneratedCategories(openXmlElement, value.AutoGeneneratedCategories, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.StrDataExtension value)
    where OpenXmlElementType: DXDC.StrDataExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.StrDataExtension openXmlElement, DMDC.StrDataExtension value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetAutoGeneneratedCategories(openXmlElement, value?.AutoGeneneratedCategories);
  }
}
