namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the TextOutlineEffect Class.
/// </summary>
public static class TextOutlineEffectConverter
{
  /// <summary>
  /// w, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetLineWidth(DXO10W.TextOutlineEffect openXmlElement)
  {
    return openXmlElement?.LineWidth?.Value;
  }
  
  private static bool CmpLineWidth(DXO10W.TextOutlineEffect openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.LineWidth?.Value == value) return true;
    diffs?.Add(objName, "LineWidth", openXmlElement?.LineWidth?.Value, value);
    return false;
  }
  
  private static void SetLineWidth(DXO10W.TextOutlineEffect openXmlElement, Int32? value)
  {
    openXmlElement.LineWidth = value;
  }
  
  /// <summary>
  /// cap, this property is only available in Office 2010 and later.
  /// </summary>
  private static DMW.LineCapKind? GetCapType(DXO10W.TextOutlineEffect openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.LineCapValues, DMW.LineCapKind>(openXmlElement?.CapType?.Value);
  }
  
  private static bool CmpCapType(DXO10W.TextOutlineEffect openXmlElement, DMW.LineCapKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.Word.LineCapValues, DMW.LineCapKind>(openXmlElement?.CapType?.Value, value, diffs, objName, propName);
  }
  
  private static void SetCapType(DXO10W.TextOutlineEffect openXmlElement, DMW.LineCapKind? value)
  {
    openXmlElement.CapType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.LineCapValues, DMW.LineCapKind>(value);
  }
  
  /// <summary>
  /// cmpd, this property is only available in Office 2010 and later.
  /// </summary>
  private static DMW.CompoundLineKind? GetCompound(DXO10W.TextOutlineEffect openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.CompoundLineValues, DMW.CompoundLineKind>(openXmlElement?.Compound?.Value);
  }
  
  private static bool CmpCompound(DXO10W.TextOutlineEffect openXmlElement, DMW.CompoundLineKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.Word.CompoundLineValues, DMW.CompoundLineKind>(openXmlElement?.Compound?.Value, value, diffs, objName, propName);
  }
  
  private static void SetCompound(DXO10W.TextOutlineEffect openXmlElement, DMW.CompoundLineKind? value)
  {
    openXmlElement.Compound = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.CompoundLineValues, DMW.CompoundLineKind>(value);
  }
  
  /// <summary>
  /// algn, this property is only available in Office 2010 and later.
  /// </summary>
  private static DMW.PenAlignmentKind? GetAlignment(DXO10W.TextOutlineEffect openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.PenAlignmentValues, DMW.PenAlignmentKind>(openXmlElement?.Alignment?.Value);
  }
  
  private static bool CmpAlignment(DXO10W.TextOutlineEffect openXmlElement, DMW.PenAlignmentKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.Word.PenAlignmentValues, DMW.PenAlignmentKind>(openXmlElement?.Alignment?.Value, value, diffs, objName, propName);
  }
  
  private static void SetAlignment(DXO10W.TextOutlineEffect openXmlElement, DMW.PenAlignmentKind? value)
  {
    openXmlElement.Alignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.PenAlignmentValues, DMW.PenAlignmentKind>(value);
  }
  
  private static Boolean? GetNoFillEmpty(DXO10W.TextOutlineEffect openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO10W.NoFillEmpty>() != null;
  }
  
  private static bool CmpNoFillEmpty(DXO10W.TextOutlineEffect openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXO10W.NoFillEmpty>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO10W.NoFillEmpty", val, value);
    return false;
  }
  
  private static void SetNoFillEmpty(DXO10W.TextOutlineEffect openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO10W.NoFillEmpty>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO10W.NoFillEmpty();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMW.SolidColorFillProperties? GetSolidColorFillProperties(DXO10W.TextOutlineEffect openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10W.SolidColorFillProperties>();
    if (element != null)
      return DMXW.SolidColorFillPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSolidColorFillProperties(DXO10W.TextOutlineEffect openXmlElement, DMW.SolidColorFillProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.SolidColorFillPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10W.SolidColorFillProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetSolidColorFillProperties(DXO10W.TextOutlineEffect openXmlElement, DMW.SolidColorFillProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10W.SolidColorFillProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.SolidColorFillPropertiesConverter.CreateOpenXmlElement<DXO10W.SolidColorFillProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMW.GradientFillProperties? GetGradientFillProperties(DXO10W.TextOutlineEffect openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10W.GradientFillProperties>();
    if (element != null)
      return DMXW.GradientFillPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGradientFillProperties(DXO10W.TextOutlineEffect openXmlElement, DMW.GradientFillProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.GradientFillPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10W.GradientFillProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetGradientFillProperties(DXO10W.TextOutlineEffect openXmlElement, DMW.GradientFillProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10W.GradientFillProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.GradientFillPropertiesConverter.CreateOpenXmlElement<DXO10W.GradientFillProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMW.PresetLineDashKind? GetPresetLineDashProperties(DXO10W.TextOutlineEffect openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.PresetLineDashValues, DMW.PresetLineDashKind>(openXmlElement.GetFirstChild<DXO10W.PresetLineDashProperties>()?.Val?.Value);
  }
  
  private static bool CmpPresetLineDashProperties(DXO10W.TextOutlineEffect openXmlElement, DMW.PresetLineDashKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.Word.PresetLineDashValues, DMW.PresetLineDashKind>(openXmlElement.GetFirstChild<DXO10W.PresetLineDashProperties>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetPresetLineDashProperties(DXO10W.TextOutlineEffect openXmlElement, DMW.PresetLineDashKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10W.PresetLineDashProperties>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.PresetLineDashValues, DMW.PresetLineDashKind>(itemElement, (DMW.PresetLineDashKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXO10W.PresetLineDashProperties, DocumentFormat.OpenXml.Office2010.Word.PresetLineDashValues, DMW.PresetLineDashKind>((DMW.PresetLineDashKind)value));
  }
  
  private static Boolean? GetRoundEmpty(DXO10W.TextOutlineEffect openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO10W.RoundEmpty>() != null;
  }
  
  private static bool CmpRoundEmpty(DXO10W.TextOutlineEffect openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXO10W.RoundEmpty>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO10W.RoundEmpty", val, value);
    return false;
  }
  
  private static void SetRoundEmpty(DXO10W.TextOutlineEffect openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO10W.RoundEmpty>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO10W.RoundEmpty();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetBevelEmpty(DXO10W.TextOutlineEffect openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO10W.BevelEmpty>() != null;
  }
  
  private static bool CmpBevelEmpty(DXO10W.TextOutlineEffect openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXO10W.BevelEmpty>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO10W.BevelEmpty", val, value);
    return false;
  }
  
  private static void SetBevelEmpty(DXO10W.TextOutlineEffect openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO10W.BevelEmpty>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO10W.BevelEmpty();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMW.LineJoinMiterProperties? GetLineJoinMiterProperties(DXO10W.TextOutlineEffect openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10W.LineJoinMiterProperties>();
    if (element != null)
      return DMXW.LineJoinMiterPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLineJoinMiterProperties(DXO10W.TextOutlineEffect openXmlElement, DMW.LineJoinMiterProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.LineJoinMiterPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10W.LineJoinMiterProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetLineJoinMiterProperties(DXO10W.TextOutlineEffect openXmlElement, DMW.LineJoinMiterProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10W.LineJoinMiterProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.LineJoinMiterPropertiesConverter.CreateOpenXmlElement<DXO10W.LineJoinMiterProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMW.TextOutlineEffect? CreateModelElement(DXO10W.TextOutlineEffect? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.TextOutlineEffect();
      value.LineWidth = GetLineWidth(openXmlElement);
      value.CapType = GetCapType(openXmlElement);
      value.Compound = GetCompound(openXmlElement);
      value.Alignment = GetAlignment(openXmlElement);
      value.NoFillEmpty = GetNoFillEmpty(openXmlElement);
      value.SolidColorFillProperties = GetSolidColorFillProperties(openXmlElement);
      value.GradientFillProperties = GetGradientFillProperties(openXmlElement);
      value.PresetLineDashProperties = GetPresetLineDashProperties(openXmlElement);
      value.RoundEmpty = GetRoundEmpty(openXmlElement);
      value.BevelEmpty = GetBevelEmpty(openXmlElement);
      value.LineJoinMiterProperties = GetLineJoinMiterProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO10W.TextOutlineEffect? openXmlElement, DMW.TextOutlineEffect? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLineWidth(openXmlElement, value.LineWidth, diffs, objName, propName))
        ok = false;
      if (!CmpCapType(openXmlElement, value.CapType, diffs, objName, propName))
        ok = false;
      if (!CmpCompound(openXmlElement, value.Compound, diffs, objName, propName))
        ok = false;
      if (!CmpAlignment(openXmlElement, value.Alignment, diffs, objName, propName))
        ok = false;
      if (!CmpNoFillEmpty(openXmlElement, value.NoFillEmpty, diffs, objName, propName))
        ok = false;
      if (!CmpSolidColorFillProperties(openXmlElement, value.SolidColorFillProperties, diffs, objName, propName))
        ok = false;
      if (!CmpGradientFillProperties(openXmlElement, value.GradientFillProperties, diffs, objName, propName))
        ok = false;
      if (!CmpPresetLineDashProperties(openXmlElement, value.PresetLineDashProperties, diffs, objName, propName))
        ok = false;
      if (!CmpRoundEmpty(openXmlElement, value.RoundEmpty, diffs, objName, propName))
        ok = false;
      if (!CmpBevelEmpty(openXmlElement, value.BevelEmpty, diffs, objName, propName))
        ok = false;
      if (!CmpLineJoinMiterProperties(openXmlElement, value.LineJoinMiterProperties, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.TextOutlineEffect value)
    where OpenXmlElementType: DXO10W.TextOutlineEffect, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10W.TextOutlineEffect openXmlElement, DMW.TextOutlineEffect value)
  {
    SetLineWidth(openXmlElement, value?.LineWidth);
    SetCapType(openXmlElement, value?.CapType);
    SetCompound(openXmlElement, value?.Compound);
    SetAlignment(openXmlElement, value?.Alignment);
    SetNoFillEmpty(openXmlElement, value?.NoFillEmpty);
    SetSolidColorFillProperties(openXmlElement, value?.SolidColorFillProperties);
    SetGradientFillProperties(openXmlElement, value?.GradientFillProperties);
    SetPresetLineDashProperties(openXmlElement, value?.PresetLineDashProperties);
    SetRoundEmpty(openXmlElement, value?.RoundEmpty);
    SetBevelEmpty(openXmlElement, value?.BevelEmpty);
    SetLineJoinMiterProperties(openXmlElement, value?.LineJoinMiterProperties);
  }
}
