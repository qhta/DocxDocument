namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// FontRelationshipType from/
/// </summary>
public static class FontRelationshipTypeConverter
{

  #region FontKey conversion
  private static String? GetFontKey(DXW.FontRelationshipType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.FontKey);
  }
  
  private static bool CmpFontKey(DXW.FontRelationshipType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.FontKey, value, diffs, objName, "FontKey");
  }
  
  private static void SetFontKey(DXW.FontRelationshipType openXmlElement, String? value)
  {
    openXmlElement.FontKey = StringValueConverter.CreateStringValue(value);
  }
  #endregion

  #region Subsetted conversion
  private static Boolean? GetSubsetted(DXW.FontRelationshipType openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.Subsetted)/* ?? true*/;
  }
  
  private static bool CmpSubsetted(DXW.FontRelationshipType openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.Subsetted, value, diffs, objName, "Subsetted");
  }
  
  private static void SetSubsetted(DXW.FontRelationshipType openXmlElement, Boolean? value)
  {
    openXmlElement.Subsetted = BooleanValueConverter.CreateOnOffValue(value);
  }
  #endregion

  #region Id conversion
  private static String? GetId(DXW.FontRelationshipType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXW.FontRelationshipType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXW.FontRelationshipType openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  #endregion

  #region FontRelationshipType conversion
  public static DMW.EmbeddedFont? CreateModelElement(DXW.FontRelationshipType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.EmbeddedFont();
      value.FontKey = GetFontKey(openXmlElement);
      value.Subsetted = GetSubsetted(openXmlElement);
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.FontRelationshipType? openXmlElement, DMW.EmbeddedFont? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpFontKey(openXmlElement, value.FontKey, diffs, objName))
        ok = false;
      if (!CmpSubsetted(openXmlElement, value.Subsetted, diffs, objName))
        ok = false;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.EmbeddedFont value)
    where OpenXmlElementType: DXW.FontRelationshipType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.FontRelationshipType openXmlElement, DMW.EmbeddedFont value)
  {
    SetFontKey(openXmlElement, value?.FontKey);
    SetSubsetted(openXmlElement, value?.Subsetted);
    SetId(openXmlElement, value?.Id);
  }
  #endregion
}