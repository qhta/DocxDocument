namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Data About Single Data Source Record.
/// </summary>
public static class RecipientDataConverter
{
  /// <summary>
  /// Record Is Included in Mail Merge.
  /// </summary>
  private static Boolean? GetActive(DXW.RecipientData openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.Active>());
  }
  
  private static bool CmpActive(DXW.RecipientData openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.Active>(), value, diffs, objName);
  }
  
  private static void SetActive(DXW.RecipientData openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.Active>(openXmlElement, value);
  }
  
  /// <summary>
  /// Index of Column Containing Unique Values for Record.
  /// </summary>
  private static UInt32? GetColumnIndex(DXW.RecipientData openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.ColumnIndex>()?.Val);
  }
  
  private static bool CmpColumnIndex(DXW.RecipientData openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.ColumnIndex>()?.Val, value, diffs, objName, "ColumnIndex");
  }
  
  private static void SetColumnIndex(DXW.RecipientData openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXW.ColumnIndex,System.UInt32>(openXmlElement, value);
  }
  
  /// <summary>
  /// Unique Value for Record.
  /// </summary>
  private static DM.Base64Binary? GetUniqueTag(DXW.RecipientData openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.UniqueTag>()?.Val);
  }
  
  private static bool CmpUniqueTag(DXW.RecipientData openXmlElement, DM.Base64Binary? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.UniqueTag>()?.Val, value, diffs, objName, "UniqueTag");
  }
  
  private static void SetUniqueTag(DXW.RecipientData openXmlElement, DM.Base64Binary? value)
  {
    SimpleValueConverter.SetValue<DXW.UniqueTag,DocumentModel.Base64Binary>(openXmlElement, value);
  }
  
  public static DocumentModel.Wordprocessing.RecipientData? CreateModelElement(DXW.RecipientData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.RecipientData();
      value.Active = GetActive(openXmlElement);
      value.ColumnIndex = GetColumnIndex(openXmlElement);
      value.UniqueTag = GetUniqueTag(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.RecipientData? openXmlElement, DMW.RecipientData? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpActive(openXmlElement, value.Active, diffs, objName))
        ok = false;
      if (!CmpColumnIndex(openXmlElement, value.ColumnIndex, diffs, objName))
        ok = false;
      if (!CmpUniqueTag(openXmlElement, value.UniqueTag, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.RecipientData value)
    where OpenXmlElementType: DXW.RecipientData, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.RecipientData openXmlElement, DMW.RecipientData value)
  {
    SetActive(openXmlElement, value?.Active);
    SetColumnIndex(openXmlElement, value?.ColumnIndex);
    SetUniqueTag(openXmlElement, value?.UniqueTag);
  }
}
