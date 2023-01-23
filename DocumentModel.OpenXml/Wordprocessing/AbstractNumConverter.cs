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
    return openXmlElement.AbstractNumberId?.Value;
  }
  
  private static bool CmpAbstractNumberId(DXW.AbstractNum openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.AbstractNumberId?.Value == value;
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
    if (openXmlElement.Nsid?.Val?.Value != null)
      return UInt32.Parse(openXmlElement.Nsid.Val.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static bool CmpNsid(DXW.AbstractNum openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement.Nsid?.Val?.Value != null)
      if (UInt32.Parse(openXmlElement.Nsid.Val.Value, NumberStyles.HexNumber) == value)
        return true;
    if (openXmlElement.Nsid?.Val?.Value == null && value == null) return true;
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
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.MultiLevelValues, DMW.MultiLevelKind>(openXmlElement.GetFirstChild<DXW.MultiLevelType>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMultiLevelType(DXW.AbstractNum openXmlElement, DMW.MultiLevelKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MultiLevelType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.MultiLevelType, DocumentFormat.OpenXml.Wordprocessing.MultiLevelValues, DMW.MultiLevelKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Numbering Template Code.
  /// </summary>
  private static UInt32? GetTemplateCode(DXW.AbstractNum openXmlElement)
  {
    if (openXmlElement.TemplateCode?.Val?.Value != null)
      return UInt32.Parse(openXmlElement.TemplateCode.Val.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static bool CmpTemplateCode(DXW.AbstractNum openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement.TemplateCode?.Val?.Value != null)
      if (UInt32.Parse(openXmlElement.TemplateCode.Val.Value, NumberStyles.HexNumber) == value)
        return true;
    if (openXmlElement.TemplateCode?.Val?.Value == null && value == null) return true;
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
      return openXmlElement?.GetFirstChild<DXW.AbstractNumDefinitionName>()?.Val?.Value;
  }
  
  private static bool CmpAbstractNumDefinitionName(DXW.AbstractNum openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXW.AbstractNumDefinitionName>()?.Val?.Value == value;
  }
  
  private static void SetAbstractNumDefinitionName(DXW.AbstractNum openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.AbstractNumDefinitionName>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.AbstractNumDefinitionName { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Numbering Style Definition.
  /// </summary>
  private static String? GetStyleLink(DXW.AbstractNum openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXW.StyleLink>()?.Val?.Value;
  }
  
  private static bool CmpStyleLink(DXW.AbstractNum openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXW.StyleLink>()?.Val?.Value == value;
  }
  
  private static void SetStyleLink(DXW.AbstractNum openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.StyleLink>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.StyleLink { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Numbering Style Reference.
  /// </summary>
  private static String? GetNumberingStyleLink(DXW.AbstractNum openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXW.NumberingStyleLink>()?.Val?.Value;
  }
  
  private static bool CmpNumberingStyleLink(DXW.AbstractNum openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXW.NumberingStyleLink>()?.Val?.Value == value;
  }
  
  private static void SetNumberingStyleLink(DXW.AbstractNum openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.NumberingStyleLink>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.NumberingStyleLink { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<DMW.Level> GetLevels(DXW.AbstractNum openXmlElement)
  {
    var collection = new Collection<DMW.Level>();
    foreach (var item in openXmlElement.Elements<DXW.Level>())
    {
      var newItem = DMXW.LevelConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpLevels(DXW.AbstractNum openXmlElement, Collection<DMW.Level>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXW.Level>();
      var origElementsCount = origElements.Count();
      var modelElementsCount = value.Count();
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().ToString()+".Count", origElementsCount, modelElementsCount);
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
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
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
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.AbstractNum? value)
    where OpenXmlElementType: DXW.AbstractNum, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAbstractNumberId(openXmlElement, value?.AbstractNumberId);
      SetNsid(openXmlElement, value?.Nsid);
      SetMultiLevelType(openXmlElement, value?.MultiLevelType);
      SetTemplateCode(openXmlElement, value?.TemplateCode);
      SetAbstractNumDefinitionName(openXmlElement, value?.AbstractNumDefinitionName);
      SetStyleLink(openXmlElement, value?.StyleLink);
      SetNumberingStyleLink(openXmlElement, value?.NumberingStyleLink);
      SetLevels(openXmlElement, value?.Levels);
      return openXmlElement;
    }
    return default;
  }
}
