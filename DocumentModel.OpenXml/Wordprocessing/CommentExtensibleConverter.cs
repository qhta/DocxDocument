namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the CommentExtensible Class.
/// </summary>
public static class CommentExtensibleConverter
{
  /// <summary>
  /// durableId, this property is only available in Office 2021 and later.
  /// </summary>
  private static DM.HexInt? GetDurableId(DXO2021WComtExt.CommentExtensible openXmlElement)
  {
    if (openXmlElement?.DurableId?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.DurableId.Value);
    return null;
  }
  
  private static bool CmpDurableId(DXO2021WComtExt.CommentExtensible openXmlElement, DM.HexInt? value, DiffList? diffs, string? objName)
  {
    return HexIntConverter.CmpValue(openXmlElement?.DurableId?.Value, value, diffs, objName, "DurableId");
  }
  
  private static void SetDurableId(DXO2021WComtExt.CommentExtensible openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.DurableId = value.ToString();
    else
      openXmlElement.DurableId = null;
  }
  
  /// <summary>
  /// dateUtc, this property is only available in Office 2021 and later.
  /// </summary>
  private static DateTime? GetDateUtc(DXO2021WComtExt.CommentExtensible openXmlElement)
  {
    return openXmlElement?.DateUtc?.Value;
  }
  
  private static bool CmpDateUtc(DXO2021WComtExt.CommentExtensible openXmlElement, DateTime? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.DateUtc?.Value == value) return true;
    diffs?.Add(objName, "DateUtc", openXmlElement?.DateUtc?.Value, value);
    return false;
  }
  
  private static void SetDateUtc(DXO2021WComtExt.CommentExtensible openXmlElement, DateTime? value)
  {
    openXmlElement.DateUtc = value;
  }
  
  /// <summary>
  /// intelligentPlaceholder, this property is only available in Office 2021 and later.
  /// </summary>
  private static Boolean? GetIntelligentPlaceholder(DXO2021WComtExt.CommentExtensible openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.IntelligentPlaceholder);
  }
  
  private static bool CmpIntelligentPlaceholder(DXO2021WComtExt.CommentExtensible openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.IntelligentPlaceholder, value, diffs, objName, "IntelligentPlaceholder");
  }
  
  private static void SetIntelligentPlaceholder(DXO2021WComtExt.CommentExtensible openXmlElement, Boolean? value)
  {
    openXmlElement.IntelligentPlaceholder = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMW.ExtensionList? GetExtensionList(DXO2021WComtExt.CommentExtensible openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2021WComtExt.ExtensionList>();
    if (element != null)
      return DMXW.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXO2021WComtExt.CommentExtensible openXmlElement, DMW.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXW.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2021WComtExt.ExtensionList>(), value, diffs, objName);
  }
  
  private static void SetExtensionList(DXO2021WComtExt.CommentExtensible openXmlElement, DMW.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2021WComtExt.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ExtensionListConverter.CreateOpenXmlElement<DXO2021WComtExt.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.CommentExtensible? CreateModelElement(DXO2021WComtExt.CommentExtensible? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.CommentExtensible();
      value.DurableId = GetDurableId(openXmlElement);
      value.DateUtc = GetDateUtc(openXmlElement);
      value.IntelligentPlaceholder = GetIntelligentPlaceholder(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2021WComtExt.CommentExtensible? openXmlElement, DMW.CommentExtensible? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDurableId(openXmlElement, value.DurableId, diffs, objName))
        ok = false;
      if (!CmpDateUtc(openXmlElement, value.DateUtc, diffs, objName))
        ok = false;
      if (!CmpIntelligentPlaceholder(openXmlElement, value.IntelligentPlaceholder, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.CommentExtensible value)
    where OpenXmlElementType: DXO2021WComtExt.CommentExtensible, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2021WComtExt.CommentExtensible openXmlElement, DMW.CommentExtensible value)
  {
    SetDurableId(openXmlElement, value?.DurableId);
    SetDateUtc(openXmlElement, value?.DateUtc);
    SetIntelligentPlaceholder(openXmlElement, value?.IntelligentPlaceholder);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
