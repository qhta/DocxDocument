namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the StrRefExtension Class.
/// </summary>
public static class StrRefExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDC.StrRefExtension openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXDC.StrRefExtension openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXDC.StrRefExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMDC.FullReference? GetFullReference(DXDC.StrRefExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.FullReference>();
    if (element != null)
      return DMXDC.FullReferenceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFullReference(DXDC.StrRefExtension openXmlElement, DMDC.FullReference? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.FullReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.FullReference>(), value, diffs, objName, propName);
  }
  
  private static void SetFullReference(DXDC.StrRefExtension openXmlElement, DMDC.FullReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DC.FullReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.FullReferenceConverter.CreateOpenXmlElement<DXO13DC.FullReference>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.LevelReference? GetLevelReference(DXDC.StrRefExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.LevelReference>();
    if (element != null)
      return DMXDC.LevelReferenceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLevelReference(DXDC.StrRefExtension openXmlElement, DMDC.LevelReference? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.LevelReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.LevelReference>(), value, diffs, objName, propName);
  }
  
  private static void SetLevelReference(DXDC.StrRefExtension openXmlElement, DMDC.LevelReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DC.LevelReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.LevelReferenceConverter.CreateOpenXmlElement<DXO13DC.LevelReference>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.FormulaReference? GetFormulaReference(DXDC.StrRefExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.FormulaReference>();
    if (element != null)
      return DMXDC.FormulaReferenceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFormulaReference(DXDC.StrRefExtension openXmlElement, DMDC.FormulaReference? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.FormulaReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.FormulaReference>(), value, diffs, objName, propName);
  }
  
  private static void SetFormulaReference(DXDC.StrRefExtension openXmlElement, DMDC.FormulaReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DC.FormulaReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.FormulaReferenceConverter.CreateOpenXmlElement<DXO13DC.FormulaReference>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.Charts.StrRefExtension? CreateModelElement(DXDC.StrRefExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.StrRefExtension();
      value.Uri = GetUri(openXmlElement);
      value.FullReference = GetFullReference(openXmlElement);
      value.LevelReference = GetLevelReference(openXmlElement);
      value.FormulaReference = GetFormulaReference(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.StrRefExtension? openXmlElement, DMDC.StrRefExtension? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName, propName))
        ok = false;
      if (!CmpFullReference(openXmlElement, value.FullReference, diffs, objName, propName))
        ok = false;
      if (!CmpLevelReference(openXmlElement, value.LevelReference, diffs, objName, propName))
        ok = false;
      if (!CmpFormulaReference(openXmlElement, value.FormulaReference, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.StrRefExtension value)
    where OpenXmlElementType: DXDC.StrRefExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.StrRefExtension openXmlElement, DMDC.StrRefExtension value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetFullReference(openXmlElement, value?.FullReference);
    SetLevelReference(openXmlElement, value?.LevelReference);
    SetFormulaReference(openXmlElement, value?.FormulaReference);
  }
}
