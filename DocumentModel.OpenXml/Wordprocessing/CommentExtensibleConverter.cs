namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the CommentExtensible Class.
/// </summary>
public static class CommentExtensibleConverter
{
  /// <summary>
  /// durableId, this property is only available in Office 2021 and later.
  /// </summary>
  private static UInt32? GetDurableId(DXO2021WComtExt.CommentExtensible openXmlElement)
  {
    if (openXmlElement.DurableId?.Value != null)
      return UInt32.Parse(openXmlElement.DurableId.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static bool CmpDurableId(DXO2021WComtExt.CommentExtensible openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement.DurableId?.Value != null)
      return UInt32.Parse(openXmlElement.DurableId.Value, NumberStyles.HexNumber) == value;
    return openXmlElement == null && value == null;
  }
  
  private static void SetDurableId(DXO2021WComtExt.CommentExtensible openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.DurableId = ((UInt32)value).ToString("X8");
      else
        openXmlElement.DurableId = null;
  }
  
  /// <summary>
  /// dateUtc, this property is only available in Office 2021 and later.
  /// </summary>
  private static DateTime? GetDateUtc(DXO2021WComtExt.CommentExtensible openXmlElement)
  {
    return openXmlElement.DateUtc?.Value;
  }
  
  private static bool CmpDateUtc(DXO2021WComtExt.CommentExtensible openXmlElement, DateTime? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.DateUtc?.Value == value;
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
    return openXmlElement?.IntelligentPlaceholder?.Value;
  }
  
  private static bool CmpIntelligentPlaceholder(DXO2021WComtExt.CommentExtensible openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.IntelligentPlaceholder?.Value == value;
  }
  
  private static void SetIntelligentPlaceholder(DXO2021WComtExt.CommentExtensible openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.IntelligentPlaceholder = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.IntelligentPlaceholder = null;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMW.ExtensionList? GetExtensionList(DXO2021WComtExt.CommentExtensible openXmlElement)
  {
    return DMXW.ExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2021WComtExt.ExtensionList>());
  }
  
  private static bool CmpExtensionList(DXO2021WComtExt.CommentExtensible openXmlElement, DMW.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXW.ExtensionListConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2021WComtExt.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.CommentExtensible? value)
    where OpenXmlElementType: DXO2021WComtExt.CommentExtensible, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDurableId(openXmlElement, value?.DurableId);
      SetDateUtc(openXmlElement, value?.DateUtc);
      SetIntelligentPlaceholder(openXmlElement, value?.IntelligentPlaceholder);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
