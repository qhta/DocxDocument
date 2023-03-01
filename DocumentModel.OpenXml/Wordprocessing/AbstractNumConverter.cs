namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Abstract Numbering Definition.
/// </summary>
public static class AbstractNumConverter
{
  /// <summary>
  /// Abstract Numbering Definition ID
  /// </summary>
  private static Int32? GetAbstractNumberId(DXW.AbstractNum openXmlElement)
  {
    return openXmlElement?.AbstractNumberId?.Value;
  }
  
  private static bool CmpAbstractNumberId(DXW.AbstractNum openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.AbstractNumberId?.Value == value) return true;
    diffs?.Add(objName, "AbstractNumberId", openXmlElement?.AbstractNumberId?.Value, value);
    return false;
  }
  
  private static void SetAbstractNumberId(DXW.AbstractNum openXmlElement, Int32? value)
  {
    openXmlElement.AbstractNumberId = value;
  }
  
  /// <summary>
  /// Abstract Numbering Definition Identifier.
  /// </summary>
  private static UInt32? GetNsid(DXW.AbstractNum openXmlElement)
  {
    if (openXmlElement?.Nsid?.Val?.Value != null)
      return UInt32.Parse(openXmlElement.Nsid.Val.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static bool CmpNsid(DXW.AbstractNum openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Nsid?.Val?.Value != null)
      if (UInt32.Parse(openXmlElement.Nsid.Val.Value, NumberStyles.HexNumber) == value)
        return true;
    if (openXmlElement?.Nsid?.Val?.Value == null && value == null) return true;
    diffs?.Add(objName, "Nsid", openXmlElement?.Nsid?.Val?.Value, value?.ToString("x8"));
    return false;
  }
  
  private static void SetNsid(DXW.AbstractNum openXmlElement, UInt32? value)
  {
    if (value != null)
      openXmlElement.Nsid = new DXW.Nsid { Val = ((UInt32)value).ToString("X8") };
    else
      openXmlElement.Nsid = null;
  }
  
  /// <summary>
  /// Abstract Numbering Definition Type.
  /// </summary>
  private static DMW.MultiLevelKind? GetMultiLevelType(DXW.AbstractNum openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.MultiLevelValues, DMW.MultiLevelKind>(openXmlElement.GetFirstChild<DXW.MultiLevelType>()?.Val?.Value);
  }
  
  private static bool CmpMultiLevelType(DXW.AbstractNum openXmlElement, DMW.MultiLevelKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.MultiLevelValues, DMW.MultiLevelKind>(openXmlElement.GetFirstChild<DXW.MultiLevelType>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetMultiLevelType(DXW.AbstractNum openXmlElement, DMW.MultiLevelKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MultiLevelType>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.MultiLevelValues, DMW.MultiLevelKind>(itemElement, (DMW.MultiLevelKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.MultiLevelType, DocumentFormat.OpenXml.Wordprocessing.MultiLevelValues, DMW.MultiLevelKind>((DMW.MultiLevelKind)value));
  }
  
  /// <summary>
  /// Numbering Template Code.
  /// </summary>
  private static UInt32? GetTemplateCode(DXW.AbstractNum openXmlElement)
  {
    if (openXmlElement?.TemplateCode?.Val?.Value != null)
      return UInt32.Parse(openXmlElement.TemplateCode.Val.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static bool CmpTemplateCode(DXW.AbstractNum openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.TemplateCode?.Val?.Value != null)
      if (UInt32.Parse(openXmlElement.TemplateCode.Val.Value, NumberStyles.HexNumber) == value)
        return true;
    if (openXmlElement?.TemplateCode?.Val?.Value == null && value == null) return true;
    diffs?.Add(objName, "TemplateCode", openXmlElement?.TemplateCode?.Val?.Value, value?.ToString("x8"));
    return false;
  }
  
  private static void SetTemplateCode(DXW.AbstractNum openXmlElement, UInt32? value)
  {
    if (value != null)
      openXmlElement.TemplateCode = new DXW.TemplateCode { Val = ((UInt32)value).ToString("X8") };
    else
      openXmlElement.TemplateCode = null;
  }
  
  /// <summary>
  /// Abstract Numbering Definition Name.
  /// </summary>
  private static String? GetAbstractNumDefinitionName(DXW.AbstractNum openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.AbstractNumDefinitionName>()?.Val);
  }
  
  private static bool CmpAbstractNumDefinitionName(DXW.AbstractNum openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.AbstractNumDefinitionName>()?.Val, value, diffs, objName, "AbstractNumDefinitionName");
  }
  
  private static void SetAbstractNumDefinitionName(DXW.AbstractNum openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXW.AbstractNumDefinitionName>(openXmlElement, value);
  }
  
  /// <summary>
  /// Numbering Style Definition.
  /// </summary>
  private static String? GetStyleLink(DXW.AbstractNum openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.StyleLink>()?.Val);
  }
  
  private static bool CmpStyleLink(DXW.AbstractNum openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.StyleLink>()?.Val, value, diffs, objName, "StyleLink");
  }
  
  private static void SetStyleLink(DXW.AbstractNum openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXW.StyleLink>(openXmlElement, value);
  }
  
  /// <summary>
  /// Numbering Style Reference.
  /// </summary>
  private static String? GetNumberingStyleLink(DXW.AbstractNum openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.NumberingStyleLink>()?.Val);
  }
  
  private static bool CmpNumberingStyleLink(DXW.AbstractNum openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.NumberingStyleLink>()?.Val, value, diffs, objName, "NumberingStyleLink");
  }
  
  private static void SetNumberingStyleLink(DXW.AbstractNum openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXW.NumberingStyleLink>(openXmlElement, value);
  }
  
  private static Collection<DMW.Level>? GetLevels(DXW.AbstractNum openXmlElement)
  {
    var collection = new Collection<DMW.Level>();
    foreach (var item in openXmlElement.Elements<DXW.Level>())
    {
      var newItem = DMXW.LevelConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpLevels(DXW.AbstractNum openXmlElement, Collection<DMW.Level>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXW.Level>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXW.LevelConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetLevels(DXW.AbstractNum openXmlElement, Collection<DMW.Level>? value)
  {
    openXmlElement.RemoveAllChildren<DXW.Level>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.LevelConverter.CreateOpenXmlElement<DXW.Level>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMW.AbstractNum? CreateModelElement(DXW.AbstractNum? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.AbstractNum();
      value.AbstractNumberId = GetAbstractNumberId(openXmlElement);
      value.Nsid = GetNsid(openXmlElement);
      value.MultiLevelType = GetMultiLevelType(openXmlElement);
      value.TemplateCode = GetTemplateCode(openXmlElement);
      value.AbstractNumDefinitionName = GetAbstractNumDefinitionName(openXmlElement);
      value.StyleLink = GetStyleLink(openXmlElement);
      value.NumberingStyleLink = GetNumberingStyleLink(openXmlElement);
      value.Levels = GetLevels(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.AbstractNum? openXmlElement, DMW.AbstractNum? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAbstractNumberId(openXmlElement, value.AbstractNumberId, diffs, objName))
        ok = false;
      if (!CmpNsid(openXmlElement, value.Nsid, diffs, objName))
        ok = false;
      if (!CmpMultiLevelType(openXmlElement, value.MultiLevelType, diffs, objName))
        ok = false;
      if (!CmpTemplateCode(openXmlElement, value.TemplateCode, diffs, objName))
        ok = false;
      if (!CmpAbstractNumDefinitionName(openXmlElement, value.AbstractNumDefinitionName, diffs, objName))
        ok = false;
      if (!CmpStyleLink(openXmlElement, value.StyleLink, diffs, objName))
        ok = false;
      if (!CmpNumberingStyleLink(openXmlElement, value.NumberingStyleLink, diffs, objName))
        ok = false;
      if (!CmpLevels(openXmlElement, value.Levels, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.AbstractNum value)
    where OpenXmlElementType: DXW.AbstractNum, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.AbstractNum openXmlElement, DMW.AbstractNum value)
  {
    SetAbstractNumberId(openXmlElement, value?.AbstractNumberId);
    SetNsid(openXmlElement, value?.Nsid);
    SetMultiLevelType(openXmlElement, value?.MultiLevelType);
    SetTemplateCode(openXmlElement, value?.TemplateCode);
    SetAbstractNumDefinitionName(openXmlElement, value?.AbstractNumDefinitionName);
    SetStyleLink(openXmlElement, value?.StyleLink);
    SetNumberingStyleLink(openXmlElement, value?.NumberingStyleLink);
    SetLevels(openXmlElement, value?.Levels);
  }
}
