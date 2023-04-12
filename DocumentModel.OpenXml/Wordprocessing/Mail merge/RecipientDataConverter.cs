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
    var element = openXmlElement.GetFirstChild<DXW.Active>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpActive(DXW.RecipientData openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetActive(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.Active", val, value);
    return false;
  }
  
  private static void SetActive(DXW.RecipientData openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.Active>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.Active();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Index of Column Containing Unique Values for Record.
  /// </summary>
  private static UInt32? GetColumnIndex(DXW.RecipientData openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXW.ColumnIndex>()?.Val?.Value;
  }
  
  private static bool CmpColumnIndex(DXW.RecipientData openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.ColumnIndex>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXW.ColumnIndex", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetColumnIndex(DXW.RecipientData openXmlElement, UInt32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ColumnIndex>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.ColumnIndex{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Unique Value for Record.
  /// </summary>
  private static HexBinary? GetUniqueTag(DXW.RecipientData openXmlElement)
  {
    return DMX.HexBinaryConverter.GetValue(openXmlElement?.GetFirstChild<DXW.UniqueTag>());
  }
  
  private static bool CmpUniqueTag(DXW.RecipientData openXmlElement, HexBinary? value, DiffList? diffs, string? objName)
  {
    return DMX.HexBinaryConverter.CmpValue(openXmlElement.GetFirstChild<DXW.UniqueTag>(), value, diffs, objName);
  }
  
  private static void SetUniqueTag(DXW.RecipientData openXmlElement, HexBinary? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.UniqueTag>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.HexBinaryConverter.CreateOpenXmlElement<DXW.UniqueTag>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.RecipientData? CreateModelElement(DXW.RecipientData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.RecipientData();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.RecipientData? value)
    where OpenXmlElementType: DXW.RecipientData, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetActive(openXmlElement, value?.Active);
      SetColumnIndex(openXmlElement, value?.ColumnIndex);
      SetUniqueTag(openXmlElement, value?.UniqueTag);
      return openXmlElement;
    }
    return default;
  }
}
