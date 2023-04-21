namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the CommentExtensible Class.
/// </summary>
public static class CommentExtensibleConverter
{
  #region DurableId conversion.
  private static DM.HexInt? GetDurableId(DXO21WCE.CommentExtensible openXmlElement)
  {
    if (openXmlElement?.DurableId?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.DurableId.Value);
    return null;
  }
  
  private static bool CmpDurableId(DXO21WCE.CommentExtensible openXmlElement, DM.HexInt? value, DiffList? diffs, string? objName)
  {
    return HexIntConverter.CmpValue(openXmlElement?.DurableId?.Value, value, diffs, objName, "DurableId");
  }
  
  private static void SetDurableId(DXO21WCE.CommentExtensible openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.DurableId = value.ToString();
    else
      openXmlElement.DurableId = null;
  }
  #endregion

  #region DateUtc conversion.
  private static DateTime? GetDateUtc(DXO21WCE.CommentExtensible openXmlElement)
  {
    return openXmlElement?.DateUtc?.Value;
  }
  
  private static bool CmpDateUtc(DXO21WCE.CommentExtensible openXmlElement, DateTime? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.DateUtc?.Value == value) return true;
    diffs?.Add(objName, "DateUtc", openXmlElement?.DateUtc?.Value, value);
    return false;
  }
  
  private static void SetDateUtc(DXO21WCE.CommentExtensible openXmlElement, DateTime? value)
  {
    openXmlElement.DateUtc = value;
  }
  #endregion

  #region IntelligentPlaceholder conversion.
  private static Boolean? GetIntelligentPlaceholder(DXO21WCE.CommentExtensible openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.IntelligentPlaceholder);
  }
  
  private static bool CmpIntelligentPlaceholder(DXO21WCE.CommentExtensible openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.IntelligentPlaceholder, value, diffs, objName, "IntelligentPlaceholder");
  }
  
  private static void SetIntelligentPlaceholder(DXO21WCE.CommentExtensible openXmlElement, Boolean? value)
  {
    openXmlElement.IntelligentPlaceholder = BooleanValueConverter.CreateOnOffValue(value);
  }
  #endregion

  #region ExtensionList conversion.
  private static DMW.ExtensionList? GetExtensionList(DXO21WCE.CommentExtensible openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO21WCE.ExtensionList>();
    if (element != null)
      return DMXW.ExtensionListConverter.GetExtensions(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXO21WCE.CommentExtensible openXmlElement, DMW.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXW.ExtensionListConverter.CmpExtensions(openXmlElement.GetFirstChild<DXO21WCE.ExtensionList>(), value, diffs, objName);
  }
  
  private static void SetExtensionList(DXO21WCE.CommentExtensible openXmlElement, DMW.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO21WCE.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ExtensionListConverter.CreateOpenXmlElement<DXO21WCE.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.CommentExtensible? CreateModelElement(DXO21WCE.CommentExtensible? openXmlElement)
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
  
  public static bool CompareModelElement(DXO21WCE.CommentExtensible? openXmlElement, DMW.CommentExtensible? value, DiffList? diffs, string? objName)
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
    where OpenXmlElementType: DXO21WCE.CommentExtensible, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO21WCE.CommentExtensible openXmlElement, DMW.CommentExtensible value)
  {
    SetDurableId(openXmlElement, value?.DurableId);
    SetDateUtc(openXmlElement, value?.DateUtc);
    SetIntelligentPlaceholder(openXmlElement, value?.IntelligentPlaceholder);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
  #endregion
}
