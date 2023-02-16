namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the TextOutlineEffect Class.
/// </summary>
public static class TextOutlineEffectConverter
{
  /// <summary>
  /// w, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetLineWidth(DXO2010W.TextOutlineEffect openXmlElement)
  {
    return openXmlElement?.LineWidth?.Value;
  }
  
  private static bool CmpLineWidth(DXO2010W.TextOutlineEffect openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.LineWidth?.Value == value) return true;
    diffs?.Add(objName, "LineWidth", openXmlElement?.LineWidth?.Value, value);
    return false;
  }
  
  private static void SetLineWidth(DXO2010W.TextOutlineEffect openXmlElement, Int32? value)
  {
    openXmlElement.LineWidth = value;
  }
  
  /// <summary>
  /// cap, this property is only available in Office 2010 and later.
  /// </summary>
  private static DMW.LineCapKind? GetCapType(DXO2010W.TextOutlineEffect openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.LineCapValues, DMW.LineCapKind>(openXmlElement?.CapType?.Value);
  }
  
  private static bool CmpCapType(DXO2010W.TextOutlineEffect openXmlElement, DMW.LineCapKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.Word.LineCapValues, DMW.LineCapKind>(openXmlElement?.CapType?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCapType(DXO2010W.TextOutlineEffect openXmlElement, DMW.LineCapKind? value)
  {
    openXmlElement.CapType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.LineCapValues, DMW.LineCapKind>(value);
  }
  
  /// <summary>
  /// cmpd, this property is only available in Office 2010 and later.
  /// </summary>
  private static DMW.CompoundLineKind? GetCompound(DXO2010W.TextOutlineEffect openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.CompoundLineValues, DMW.CompoundLineKind>(openXmlElement?.Compound?.Value);
  }
  
  private static bool CmpCompound(DXO2010W.TextOutlineEffect openXmlElement, DMW.CompoundLineKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.Word.CompoundLineValues, DMW.CompoundLineKind>(openXmlElement?.Compound?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCompound(DXO2010W.TextOutlineEffect openXmlElement, DMW.CompoundLineKind? value)
  {
    openXmlElement.Compound = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.CompoundLineValues, DMW.CompoundLineKind>(value);
  }
  
  /// <summary>
  /// algn, this property is only available in Office 2010 and later.
  /// </summary>
  private static DMW.PenAlignmentKind? GetAlignment(DXO2010W.TextOutlineEffect openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.PenAlignmentValues, DMW.PenAlignmentKind>(openXmlElement?.Alignment?.Value);
  }
  
  private static bool CmpAlignment(DXO2010W.TextOutlineEffect openXmlElement, DMW.PenAlignmentKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.Word.PenAlignmentValues, DMW.PenAlignmentKind>(openXmlElement?.Alignment?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetAlignment(DXO2010W.TextOutlineEffect openXmlElement, DMW.PenAlignmentKind? value)
  {
    openXmlElement.Alignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.PenAlignmentValues, DMW.PenAlignmentKind>(value);
  }
  
  private static Boolean? GetNoFillEmpty(DXO2010W.TextOutlineEffect openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO2010W.NoFillEmpty>() != null;
  }
  
  private static bool CmpNoFillEmpty(DXO2010W.TextOutlineEffect openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXO2010W.NoFillEmpty>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO2010W.NoFillEmpty", val, value);
    return false;
  }
  
  private static void SetNoFillEmpty(DXO2010W.TextOutlineEffect openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO2010W.NoFillEmpty>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO2010W.NoFillEmpty();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.SolidColorFillProperties? GetSolidColorFillProperties(DXO2010W.TextOutlineEffect openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.SolidColorFillProperties>();
    if (element != null)
      return DMXW.SolidColorFillPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSolidColorFillProperties(DXO2010W.TextOutlineEffect openXmlElement, DMW.SolidColorFillProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.SolidColorFillPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.SolidColorFillProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSolidColorFillProperties(DXO2010W.TextOutlineEffect openXmlElement, DMW.SolidColorFillProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.SolidColorFillProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.SolidColorFillPropertiesConverter.CreateOpenXmlElement<DXO2010W.SolidColorFillProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.GradientFillProperties? GetGradientFillProperties(DXO2010W.TextOutlineEffect openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.GradientFillProperties>();
    if (element != null)
      return DMXW.GradientFillPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGradientFillProperties(DXO2010W.TextOutlineEffect openXmlElement, DMW.GradientFillProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.GradientFillPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.GradientFillProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetGradientFillProperties(DXO2010W.TextOutlineEffect openXmlElement, DMW.GradientFillProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.GradientFillProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.GradientFillPropertiesConverter.CreateOpenXmlElement<DXO2010W.GradientFillProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.PresetLineDashKind? GetPresetLineDashProperties(DXO2010W.TextOutlineEffect openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.PresetLineDashValues, DMW.PresetLineDashKind>(openXmlElement.GetFirstChild<DXO2010W.PresetLineDashProperties>()?.Val?.Value);
  }
  
  private static bool CmpPresetLineDashProperties(DXO2010W.TextOutlineEffect openXmlElement, DMW.PresetLineDashKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.Word.PresetLineDashValues, DMW.PresetLineDashKind>(openXmlElement.GetFirstChild<DXO2010W.PresetLineDashProperties>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPresetLineDashProperties(DXO2010W.TextOutlineEffect openXmlElement, DMW.PresetLineDashKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.PresetLineDashProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXO2010W.PresetLineDashProperties, DocumentFormat.OpenXml.Office2010.Word.PresetLineDashValues, DMW.PresetLineDashKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetRoundEmpty(DXO2010W.TextOutlineEffect openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO2010W.RoundEmpty>() != null;
  }
  
  private static bool CmpRoundEmpty(DXO2010W.TextOutlineEffect openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXO2010W.RoundEmpty>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO2010W.RoundEmpty", val, value);
    return false;
  }
  
  private static void SetRoundEmpty(DXO2010W.TextOutlineEffect openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO2010W.RoundEmpty>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO2010W.RoundEmpty();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetBevelEmpty(DXO2010W.TextOutlineEffect openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO2010W.BevelEmpty>() != null;
  }
  
  private static bool CmpBevelEmpty(DXO2010W.TextOutlineEffect openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXO2010W.BevelEmpty>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO2010W.BevelEmpty", val, value);
    return false;
  }
  
  private static void SetBevelEmpty(DXO2010W.TextOutlineEffect openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO2010W.BevelEmpty>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO2010W.BevelEmpty();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.LineJoinMiterProperties? GetLineJoinMiterProperties(DXO2010W.TextOutlineEffect openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.LineJoinMiterProperties>();
    if (element != null)
      return DMXW.LineJoinMiterPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLineJoinMiterProperties(DXO2010W.TextOutlineEffect openXmlElement, DMW.LineJoinMiterProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.LineJoinMiterPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.LineJoinMiterProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLineJoinMiterProperties(DXO2010W.TextOutlineEffect openXmlElement, DMW.LineJoinMiterProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.LineJoinMiterProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.LineJoinMiterPropertiesConverter.CreateOpenXmlElement<DXO2010W.LineJoinMiterProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.TextOutlineEffect? CreateModelElement(DXO2010W.TextOutlineEffect? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.TextOutlineEffect();
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
  
  public static bool CompareModelElement(DXO2010W.TextOutlineEffect? openXmlElement, DMW.TextOutlineEffect? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLineWidth(openXmlElement, value.LineWidth, diffs, objName))
        ok = false;
      if (!CmpCapType(openXmlElement, value.CapType, diffs, objName))
        ok = false;
      if (!CmpCompound(openXmlElement, value.Compound, diffs, objName))
        ok = false;
      if (!CmpAlignment(openXmlElement, value.Alignment, diffs, objName))
        ok = false;
      if (!CmpNoFillEmpty(openXmlElement, value.NoFillEmpty, diffs, objName))
        ok = false;
      if (!CmpSolidColorFillProperties(openXmlElement, value.SolidColorFillProperties, diffs, objName))
        ok = false;
      if (!CmpGradientFillProperties(openXmlElement, value.GradientFillProperties, diffs, objName))
        ok = false;
      if (!CmpPresetLineDashProperties(openXmlElement, value.PresetLineDashProperties, diffs, objName))
        ok = false;
      if (!CmpRoundEmpty(openXmlElement, value.RoundEmpty, diffs, objName))
        ok = false;
      if (!CmpBevelEmpty(openXmlElement, value.BevelEmpty, diffs, objName))
        ok = false;
      if (!CmpLineJoinMiterProperties(openXmlElement, value.LineJoinMiterProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.TextOutlineEffect? value)
    where OpenXmlElementType: DXO2010W.TextOutlineEffect, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
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
      return openXmlElement;
    }
    return default;
  }
}
