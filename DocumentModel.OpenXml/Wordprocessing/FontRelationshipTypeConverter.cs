namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the FontRelationshipType Class converter from/to OpenXml.
///</summary>
public static class FontRelationshipTypeConverter
{
  /// <summary>
  /// fontKey
  /// </summary>
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
  
  /// <summary>
  /// subsetted
  /// </summary>
  private static Boolean? GetSubsetted(DXW.FontRelationshipType openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.Subsetted);
  }
  
  private static bool CmpSubsetted(DXW.FontRelationshipType openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.Subsetted, value, diffs, objName, "Subsetted");
  }
  
  private static void SetSubsetted(DXW.FontRelationshipType openXmlElement, Boolean? value)
  {
    openXmlElement.Subsetted = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// Relationship to Part
  /// </summary>
  private static String? GetId(DXW.FontRelationshipType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXW.FontRelationshipType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "Id");
  }
  
  private static void SetId(DXW.FontRelationshipType openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  public static DMW.FontRelationshipType? CreateModelElement(DXW.FontRelationshipType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.FontRelationshipType();
      value.FontKey = GetFontKey(openXmlElement);
      value.Subsetted = GetSubsetted(openXmlElement);
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.FontRelationshipType? openXmlElement, DMW.FontRelationshipType? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.FontRelationshipType value)
    where OpenXmlElementType: DXW.FontRelationshipType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.FontRelationshipType openXmlElement, DMW.FontRelationshipType value)
  {
    SetFontKey(openXmlElement, value?.FontKey);
    SetSubsetted(openXmlElement, value?.Subsetted);
    SetId(openXmlElement, value?.Id);
  }
}
