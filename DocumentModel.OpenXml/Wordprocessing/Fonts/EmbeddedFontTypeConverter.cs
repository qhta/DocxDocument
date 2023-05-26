namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.EmbeddedFont"/> class from/to OpenXml converter./// </summary>
public static class EmbeddedFontConverter
{
  #region FontKey conversion
  private static String? GetFontKey(DXW.FontRelationshipType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.FontKey);
  }
  
  private static bool CmpFontKey(DXW.FontRelationshipType openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
  
  private static bool CmpSubsetted(DXW.FontRelationshipType openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
  
  private static bool CmpId(DXW.FontRelationshipType openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXW.FontRelationshipType openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  #endregion

  #region EmbeddedFont model conversion
  public static DMW.EmbeddedFont? CreateModelElement(DXW.FontRelationshipType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.EmbeddedFont();
      model.FontKey = GetFontKey(openXmlElement);
      model.Subsetted = GetSubsetted(openXmlElement);
      model.Id = GetId(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.FontRelationshipType? openXmlElement, DMW.EmbeddedFont? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpFontKey(openXmlElement, model.FontKey, diffs, objName, propName))
        ok = false;
      if (!CmpSubsetted(openXmlElement, model.Subsetted, diffs, objName, propName))
        ok = false;
      if (!CmpId(openXmlElement, model.Id, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.EmbeddedFont model)
    where OpenXmlElementType: DXW.FontRelationshipType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.FontRelationshipType openXmlElement, DMW.EmbeddedFont model)
  {
    SetFontKey(openXmlElement, model?.FontKey);
    SetSubsetted(openXmlElement, model?.Subsetted);
    SetId(openXmlElement, model?.Id);
  }
  #endregion
}