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
    return openXmlElement.LineWidth?.Value;
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
  
  private static void SetAlignment(DXO2010W.TextOutlineEffect openXmlElement, DMW.PenAlignmentKind? value)
  {
    openXmlElement.Alignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.PenAlignmentValues, DMW.PenAlignmentKind>(value);
  }
  
  private static Boolean? GetNoFillEmpty(DXO2010W.TextOutlineEffect openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.NoFillEmpty>();
    return itemElement != null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.SolidColorFillProperties>();
    if (itemElement != null)
      return DMXW.SolidColorFillPropertiesConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.GradientFillProperties>();
    if (itemElement != null)
      return DMXW.GradientFillPropertiesConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.PresetLineDashProperties>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.PresetLineDashValues, DMW.PresetLineDashKind>(itemElement.Val.Value);
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.RoundEmpty>();
    return itemElement != null;
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
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.BevelEmpty>();
    return itemElement != null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.LineJoinMiterProperties>();
    if (itemElement != null)
      return DMXW.LineJoinMiterPropertiesConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static DMW.TextOutlineEffect? CreateModelElement(DXO2010W.TextOutlineEffect? openXmlElement)
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
