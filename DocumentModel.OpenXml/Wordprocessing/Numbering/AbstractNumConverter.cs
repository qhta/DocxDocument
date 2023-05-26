namespace DocumentModel.OpenXml.Wordprocessing;


/// <summary>
/// <see cref="DocumentModel.Wordprocessing.FontSignature"/> class from/to OpenXml converter.
/// </summary>
public static class AbstractNumConverter
{
  #region AbstractNumberId conversion.
  private static Int32? GetAbstractNumberId(DXW.AbstractNum openXmlElement)
  {
    return openXmlElement?.AbstractNumberId?.Value;
  }

  private static bool CmpAbstractNumberId(DXW.AbstractNum openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.AbstractNumberId?.Value == value) return true;
    diffs?.Add(objName, "AbstractNumberId", openXmlElement?.AbstractNumberId?.Value, value);
    return false;
  }

  private static void SetAbstractNumberId(DXW.AbstractNum openXmlElement, Int32? value)
  {
    openXmlElement.AbstractNumberId = value;
  }
  #endregion

  #region Nsid conversion.
  private static UInt32? GetNsid(DXW.AbstractNum openXmlElement)
  {
    if (openXmlElement?.Nsid?.Val?.Value != null)
      return UInt32.Parse(openXmlElement.Nsid.Val.Value, NumberStyles.HexNumber);
    return null;
  }

  private static bool CmpNsid(DXW.AbstractNum openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
  #endregion

  #region MultiLevelType conversion.
  private static DMW.MultiLevelKind? GetMultiLevelType(DXW.AbstractNum openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.MultiLevelValues, DMW.MultiLevelKind>(openXmlElement.GetFirstChild<DXW.MultiLevelType>()?.Val?.Value);
  }

  private static bool CmpMultiLevelType(DXW.AbstractNum openXmlElement, DMW.MultiLevelKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DXW.MultiLevelValues, DMW.MultiLevelKind>(openXmlElement.GetFirstChild<DXW.MultiLevelType>()?.Val?.Value, value, diffs, objName, propName);
  }

  private static void SetMultiLevelType(DXW.AbstractNum openXmlElement, DMW.MultiLevelKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MultiLevelType>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DXW.MultiLevelValues, DMW.MultiLevelKind>(itemElement, (DMW.MultiLevelKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXW.MultiLevelType, DXW.MultiLevelValues, DMW.MultiLevelKind>((DMW.MultiLevelKind)value));
  }
  #endregion

  #region TemplateCode conversion.
  private static UInt32? GetTemplateCode(DXW.AbstractNum openXmlElement)
  {
    if (openXmlElement?.TemplateCode?.Val?.Value != null)
      return UInt32.Parse(openXmlElement.TemplateCode.Val.Value, NumberStyles.HexNumber);
    return null;
  }

  private static bool CmpTemplateCode(DXW.AbstractNum openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
  #endregion

  #region AbstractNumDefinitionName conversion.
  private static String? GetAbstractNumDefinitionName(DXW.AbstractNum openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.AbstractNumDefinitionName>()?.Val);
  }

  private static bool CmpAbstractNumDefinitionName(DXW.AbstractNum openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.AbstractNumDefinitionName>()?.Val, value, diffs, objName, "AbstractNumDefinitionName");
  }

  private static void SetAbstractNumDefinitionName(DXW.AbstractNum openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXW.AbstractNumDefinitionName>(openXmlElement, value);
  }
  #endregion

  #region StyleLink conversion.
  private static String? GetStyleLink(DXW.AbstractNum openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.StyleLink>()?.Val);
  }

  private static bool CmpStyleLink(DXW.AbstractNum openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.StyleLink>()?.Val, value, diffs, objName, "StyleLink");
  }

  private static void SetStyleLink(DXW.AbstractNum openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXW.StyleLink>(openXmlElement, value);
  }
  #endregion

  #region NumberingStyleLink conversion.
  private static String? GetNumberingStyleLink(DXW.AbstractNum openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.NumberingStyleLink>()?.Val);
  }

  private static bool CmpNumberingStyleLink(DXW.AbstractNum openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.NumberingStyleLink>()?.Val, value, diffs, objName, "NumberingStyleLink");
  }

  private static void SetNumberingStyleLink(DXW.AbstractNum openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXW.NumberingStyleLink>(openXmlElement, value);
  }
  #endregion

  #region Levels conversion.
  private static DMW.NumLevels? GetLevels(DXW.AbstractNum openXmlElement)
  {
    var collection = new DMW.NumLevels();
    foreach (var item in openXmlElement.Elements<DXW.Level>())
    {
      var newItem = DMXW.LevelConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count > 0)
      return collection;
    return null;
  }

  private static bool CmpLevels(DXW.AbstractNum openXmlElement, Collection<DMW.NumLevel>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXW.Level>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, propName ?? openXmlElement.GetType().Name + ".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXW.LevelConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  private static void SetLevels(DXW.AbstractNum openXmlElement, Collection<DMW.NumLevel>? value)
  {
    openXmlElement.RemoveAllChildren<DXW.Level>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.LevelConverter.CreateOpenXmlElement<DXW.Level>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  #endregion

  #region RestartNumberingAfterBreak conversion.
  private static bool? GetRestartNumberingAfterBreak(DXW.AbstractNum openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.GetAttribute("restartNumberingAfterBreak","http://schemas.microsoft.com/office/word/2012/wordml").Value);
  }

  private static bool CmpRestartNumberingAfterBreak(DXW.AbstractNum openXmlElement, bool? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(
      openXmlElement?.GetAttribute("restartNumberingAfterBreak","http://schemas.microsoft.com/office/word/2012/wordml").Value,
      value, diffs, typeof(DXW.AbstractNum).Name, "restartNumberingAfterBreak");
  }

  private static void SetRestartNumberingAfterBreak(DXW.AbstractNum openXmlElement, bool? value)
  {
    if (value!=null)
      openXmlElement?.SetAttribute(
        new OpenXmlAttribute("restartNumberingAfterBreak","http://schemas.microsoft.com/office/word/2012/wordml", 
        BooleanValueConverter.Create01String(value)));
    else
      openXmlElement?.RemoveAttribute("restartNumberingAfterBreak","http://schemas.microsoft.com/office/word/2012/wordml");
  }
  #endregion

  #region AbstractNum model conversion
  public static DMW.AbstractNum? CreateModelElement(DXW.AbstractNum? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.AbstractNum();
      model.AbstractNumberId = GetAbstractNumberId(openXmlElement);
      model.Nsid = GetNsid(openXmlElement);
      model.MultiLevelType = GetMultiLevelType(openXmlElement);
      model.TemplateCode = GetTemplateCode(openXmlElement);
      model.AbstractNumDefinitionName = GetAbstractNumDefinitionName(openXmlElement);
      model.StyleLink = GetStyleLink(openXmlElement);
      model.NumberingStyleLink = GetNumberingStyleLink(openXmlElement);
      model.RestartNumberingAfterBreak = GetRestartNumberingAfterBreak(openXmlElement);
      model.Levels = GetLevels(openXmlElement);
      return model;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.AbstractNum? openXmlElement, DMW.AbstractNum? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpAbstractNumberId(openXmlElement, model.AbstractNumberId, diffs, objName, propName))
        ok = false;
      if (!CmpNsid(openXmlElement, model.Nsid, diffs, objName, propName))
        ok = false;
      if (!CmpMultiLevelType(openXmlElement, model.MultiLevelType, diffs, objName, propName))
        ok = false;
      if (!CmpTemplateCode(openXmlElement, model.TemplateCode, diffs, objName, propName))
        ok = false;
      if (!CmpAbstractNumDefinitionName(openXmlElement, model.AbstractNumDefinitionName, diffs, objName, propName))
        ok = false;
      if (!CmpStyleLink(openXmlElement, model.StyleLink, diffs, objName, propName))
        ok = false;
      if (!CmpNumberingStyleLink(openXmlElement, model.NumberingStyleLink, diffs, objName, propName))
        ok = false;
      if (!CmpRestartNumberingAfterBreak(openXmlElement, model.RestartNumberingAfterBreak, diffs, objName, propName))
        ok = false;
      if (!CmpLevels(openXmlElement, model.Levels, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.AbstractNum model)
    where OpenXmlElementType : DXW.AbstractNum, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }

  public static void UpdateOpenXmlElement(DXW.AbstractNum openXmlElement, DMW.AbstractNum model)
  {
    SetAbstractNumberId(openXmlElement, model?.AbstractNumberId);
    SetNsid(openXmlElement, model?.Nsid);
    SetMultiLevelType(openXmlElement, model?.MultiLevelType);
    SetTemplateCode(openXmlElement, model?.TemplateCode);
    SetAbstractNumDefinitionName(openXmlElement, model?.AbstractNumDefinitionName);
    SetStyleLink(openXmlElement, model?.StyleLink);
    SetNumberingStyleLink(openXmlElement, model?.NumberingStyleLink);
    SetRestartNumberingAfterBreak(openXmlElement, model?.RestartNumberingAfterBreak);
    SetLevels(openXmlElement, model?.Levels);
  }
  #endregion

}
