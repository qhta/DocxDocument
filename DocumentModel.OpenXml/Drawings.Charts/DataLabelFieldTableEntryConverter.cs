namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the DataLabelFieldTableEntry Class.
/// </summary>
public static class DataLabelFieldTableEntryConverter
{
  /// <summary>
  /// TextFieldGuid.
  /// </summary>
  private static String? GetTextFieldGuid(DXO13DC.DataLabelFieldTableEntry openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXO13DC.TextFieldGuid>()?.Text;
  }
  
  private static bool CmpTextFieldGuid(DXO13DC.DataLabelFieldTableEntry openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXO13DC.TextFieldGuid>()?.Text == value;
  }
  
  private static void SetTextFieldGuid(DXO13DC.DataLabelFieldTableEntry openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DC.TextFieldGuid>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO13DC.TextFieldGuid { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Formula.
  /// </summary>
  private static String? GetFormula(DXO13DC.DataLabelFieldTableEntry openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXO13DC.Formula>()?.Text;
  }
  
  private static bool CmpFormula(DXO13DC.DataLabelFieldTableEntry openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXO13DC.Formula>()?.Text == value;
  }
  
  private static void SetFormula(DXO13DC.DataLabelFieldTableEntry openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DC.Formula>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO13DC.Formula { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DataLabelFieldTableCache.
  /// </summary>
  private static DMDC.DataLabelFieldTableCache? GetDataLabelFieldTableCache(DXO13DC.DataLabelFieldTableEntry openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.DataLabelFieldTableCache>();
    if (element != null)
      return DMXDC.DataLabelFieldTableCacheConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataLabelFieldTableCache(DXO13DC.DataLabelFieldTableEntry openXmlElement, DMDC.DataLabelFieldTableCache? value, DiffList? diffs, string? objName)
  {
    return DMXDC.DataLabelFieldTableCacheConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.DataLabelFieldTableCache>(), value, diffs, objName);
  }
  
  private static void SetDataLabelFieldTableCache(DXO13DC.DataLabelFieldTableEntry openXmlElement, DMDC.DataLabelFieldTableCache? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DC.DataLabelFieldTableCache>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.DataLabelFieldTableCacheConverter.CreateOpenXmlElement<DXO13DC.DataLabelFieldTableCache>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.DataLabelFieldTableEntry? CreateModelElement(DXO13DC.DataLabelFieldTableEntry? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.DataLabelFieldTableEntry();
      value.TextFieldGuid = GetTextFieldGuid(openXmlElement);
      value.Formula = GetFormula(openXmlElement);
      value.DataLabelFieldTableCache = GetDataLabelFieldTableCache(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO13DC.DataLabelFieldTableEntry? openXmlElement, DMDC.DataLabelFieldTableEntry? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTextFieldGuid(openXmlElement, value.TextFieldGuid, diffs, objName))
        ok = false;
      if (!CmpFormula(openXmlElement, value.Formula, diffs, objName))
        ok = false;
      if (!CmpDataLabelFieldTableCache(openXmlElement, value.DataLabelFieldTableCache, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.DataLabelFieldTableEntry value)
    where OpenXmlElementType: DXO13DC.DataLabelFieldTableEntry, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO13DC.DataLabelFieldTableEntry openXmlElement, DMDC.DataLabelFieldTableEntry value)
  {
    SetTextFieldGuid(openXmlElement, value?.TextFieldGuid);
    SetFormula(openXmlElement, value?.Formula);
    SetDataLabelFieldTableCache(openXmlElement, value?.DataLabelFieldTableCache);
  }
}
