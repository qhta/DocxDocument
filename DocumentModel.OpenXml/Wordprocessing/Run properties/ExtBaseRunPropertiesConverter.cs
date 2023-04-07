namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.ExtBaseRunProperties"/> class from/to OpenXml converter.
/// </summary>
public static class ExtBaseRunPropertiesConverter
{
  #region RunStyle conversion.
  public static String? GetRunStyle(DX.OpenXmlCompositeElement openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.RunStyle>()?.Val);
  }

  public static bool CmpRunStyle(DX.OpenXmlCompositeElement openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.RunStyle>()?.Val, value, diffs, objName, "RunStyle");
  }

  public static void SetRunStyle(DX.OpenXmlCompositeElement openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXW.RunStyle>(openXmlElement, value);
  }
  #endregion

  #region RightToLeftText conversion.
  public static Boolean? GetRightToLeftText(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.RightToLeftText>());
  }

  public static bool CmpRightToLeftText(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.RightToLeftText>(), value, diffs, objName);
  }

  public static void SetRightToLeftText(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.RightToLeftText>(openXmlElement, value);
  }

  #endregion

  #region ComplexScript conversion.
  public static Boolean? GetComplexScript(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.ComplexScript>());
  }

  public static bool CmpComplexScript(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.ComplexScript>(), value, diffs, objName);
  }

  public static void SetComplexScript(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.ComplexScript>(openXmlElement, value);
  }

  #endregion

  #region Highlight conversion.
  public static DMW.HighlightColorKind? GetHighlight(DX.OpenXmlCompositeElement openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.HighlightColorValues, DMW.HighlightColorKind>(openXmlElement.GetFirstChild<DXW.Highlight>()?.Val?.Value);
  }

  public static bool CmpHighlight(DX.OpenXmlCompositeElement openXmlElement, DMW.HighlightColorKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.HighlightColorValues, DMW.HighlightColorKind>(openXmlElement.GetFirstChild<DXW.Highlight>()?.Val?.Value, value, diffs, objName);
  }

  public static void SetHighlight(DX.OpenXmlCompositeElement openXmlElement, DMW.HighlightColorKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Highlight>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.HighlightColorValues, DMW.HighlightColorKind>(itemElement, (DMW.HighlightColorKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.Highlight, DocumentFormat.OpenXml.Wordprocessing.HighlightColorValues, DMW.HighlightColorKind>((DMW.HighlightColorKind)value));
  }
  #endregion

  #region ContextualAlternatives conversion
  public static DMW.OnOffKind? GetContextualAlternatives(DX.OpenXmlCompositeElement openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DMW.OnOffKind>(openXmlElement.GetFirstChild<DXO2010W.ContextualAlternatives>()?.Val?.Value);
  }

  public static bool CmpContextualAlternatives(DX.OpenXmlCompositeElement openXmlElement, DMW.OnOffKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DMW.OnOffKind>(openXmlElement.GetFirstChild<DXO2010W.ContextualAlternatives>()?.Val?.Value, value, diffs, objName);
  }

  public static void SetContextualAlternatives(DX.OpenXmlCompositeElement openXmlElement, DMW.OnOffKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.ContextualAlternatives>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DMW.OnOffKind>(itemElement, (DMW.OnOffKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXO2010W.ContextualAlternatives, DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DMW.OnOffKind>((DMW.OnOffKind)value));
  }
  #endregion

  #region Glow conversion
  public static DMW.Glow? GetGlow(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.Glow>();
    if (element != null)
      return DMXW.GlowConverter.CreateModelElement(element);
    return null;
  }

  public static bool CmpGlow(DX.OpenXmlCompositeElement openXmlElement, DMW.Glow? value, DiffList? diffs, string? objName)
  {
    return DMXW.GlowConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.Glow>(), value, diffs, objName);
  }

  public static void SetGlow(DX.OpenXmlCompositeElement openXmlElement, DMW.Glow? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.Glow>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.GlowConverter.CreateOpenXmlElement<DXO2010W.Glow>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region Shadow14 conversion.
  public static DMW.Shadow2? GetShadow14(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.Shadow>();
    if (element != null)
      return DMXW.Shadow2Converter.CreateModelElement(element);
    return null;
  }

  public static bool CmpShadow14(DX.OpenXmlCompositeElement openXmlElement, DMW.Shadow2? value, DiffList? diffs, string? objName)
  {
    return DMXW.Shadow2Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.Shadow>(), value, diffs, objName);
  }

  public static void SetShadow14(DX.OpenXmlCompositeElement openXmlElement, DMW.Shadow2? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.Shadow>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.Shadow2Converter.CreateOpenXmlElement<DXO2010W.Shadow>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region Reflection conversion.
  public static DMW.Reflection? GetReflection(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.Reflection>();
    if (element != null)
      return DMXW.ReflectionConverter.CreateModelElement(element);
    return null;
  }

  public static bool CmpReflection(DX.OpenXmlCompositeElement openXmlElement, DMW.Reflection? value, DiffList? diffs, string? objName)
  {
    return DMXW.ReflectionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.Reflection>(), value, diffs, objName);
  }

  public static void SetReflection(DX.OpenXmlCompositeElement openXmlElement, DMW.Reflection? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.Reflection>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ReflectionConverter.CreateOpenXmlElement<DXO2010W.Reflection>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion
  
  #region TextOutlineEffect conversion.
  public static DMW.TextOutlineEffect? GetTextOutlineEffect(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.TextOutlineEffect>();
    if (element != null)
      return DMXW.TextOutlineEffectConverter.CreateModelElement(element);
    return null;
  }

  public static bool CmpTextOutlineEffect(DX.OpenXmlCompositeElement openXmlElement, DMW.TextOutlineEffect? value, DiffList? diffs, string? objName)
  {
    return DMXW.TextOutlineEffectConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.TextOutlineEffect>(), value, diffs, objName);
  }

  public static void SetTextOutlineEffect(DX.OpenXmlCompositeElement openXmlElement, DMW.TextOutlineEffect? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.TextOutlineEffect>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TextOutlineEffectConverter.CreateOpenXmlElement<DXO2010W.TextOutlineEffect>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region FillTextEffect conversion.
  public static DMW.FillTextEffect? GetFillTextEffect(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.FillTextEffect>();
    if (element != null)
      return DMXW.FillTextEffectConverter.CreateModelElement(element);
    return null;
  }

  public static bool CmpFillTextEffect(DX.OpenXmlCompositeElement openXmlElement, DMW.FillTextEffect? value, DiffList? diffs, string? objName)
  {
    return DMXW.FillTextEffectConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.FillTextEffect>(), value, diffs, objName);
  }

  public static void SetFillTextEffect(DX.OpenXmlCompositeElement openXmlElement, DMW.FillTextEffect? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.FillTextEffect>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.FillTextEffectConverter.CreateOpenXmlElement<DXO2010W.FillTextEffect>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region Scene3D conversion.
  public static DMW.Scene3D? GetScene3D(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.Scene3D>();
    if (element != null)
      return DMXW.Scene3DConverter.CreateModelElement(element);
    return null;
  }

  public static bool CmpScene3D(DX.OpenXmlCompositeElement openXmlElement, DMW.Scene3D? value, DiffList? diffs, string? objName)
  {
    return DMXW.Scene3DConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.Scene3D>(), value, diffs, objName);
  }

  public static void SetScene3D(DX.OpenXmlCompositeElement openXmlElement, DMW.Scene3D? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.Scene3D>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.Scene3DConverter.CreateOpenXmlElement<DXO2010W.Scene3D>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region Properties3D conversion.
  public static DMW.Properties3D? GetProperties3D(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.Properties3D>();
    if (element != null)
      return DMXW.Properties3DConverter.CreateModelElement(element);
    return null;
  }

  public static bool CmpProperties3D(DX.OpenXmlCompositeElement openXmlElement, DMW.Properties3D? value, DiffList? diffs, string? objName)
  {
    return DMXW.Properties3DConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.Properties3D>(), value, diffs, objName);
  }

  public static void SetProperties3D(DX.OpenXmlCompositeElement openXmlElement, DMW.Properties3D? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.Properties3D>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.Properties3DConverter.CreateOpenXmlElement<DXO2010W.Properties3D>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region Ligatures conversion.
  public static DMW.LigaturesKind? GetLigatures(DX.OpenXmlCompositeElement openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.LigaturesValues, DMW.LigaturesKind>(openXmlElement.GetFirstChild<DXO2010W.Ligatures>()?.Val?.Value);
  }

  public static bool CmpLigatures(DX.OpenXmlCompositeElement openXmlElement, DMW.LigaturesKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.Word.LigaturesValues, DMW.LigaturesKind>(openXmlElement.GetFirstChild<DXO2010W.Ligatures>()?.Val?.Value, value, diffs, objName);
  }

  public static void SetLigatures(DX.OpenXmlCompositeElement openXmlElement, DMW.LigaturesKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.Ligatures>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.LigaturesValues, DMW.LigaturesKind>(itemElement, (DMW.LigaturesKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXO2010W.Ligatures, DocumentFormat.OpenXml.Office2010.Word.LigaturesValues, DMW.LigaturesKind>((DMW.LigaturesKind)value));
  }
  #endregion

  #region NumberingFormat conversion.
  public static DMW.NumberFormKind? GetNumberingFormat(DX.OpenXmlCompositeElement openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.NumberFormValues, DMW.NumberFormKind>(openXmlElement.GetFirstChild<DXO2010W.NumberingFormat>()?.Val?.Value);
  }

  public static bool CmpNumberingFormat(DX.OpenXmlCompositeElement openXmlElement, DMW.NumberFormKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.Word.NumberFormValues, DMW.NumberFormKind>(openXmlElement.GetFirstChild<DXO2010W.NumberingFormat>()?.Val?.Value, value, diffs, objName);
  }

  public static void SetNumberingFormat(DX.OpenXmlCompositeElement openXmlElement, DMW.NumberFormKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.NumberingFormat>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.NumberFormValues, DMW.NumberFormKind>(itemElement, (DMW.NumberFormKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXO2010W.NumberingFormat, DocumentFormat.OpenXml.Office2010.Word.NumberFormValues, DMW.NumberFormKind>((DMW.NumberFormKind)value));
  }
  #endregion

  #region NumberSpacing conversion.
  public static DMW.NumberSpacingKind? GetNumberSpacing(DX.OpenXmlCompositeElement openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.NumberSpacingValues, DMW.NumberSpacingKind>(openXmlElement.GetFirstChild<DXO2010W.NumberSpacing>()?.Val?.Value);
  }

  public static bool CmpNumberSpacing(DX.OpenXmlCompositeElement openXmlElement, DMW.NumberSpacingKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.Word.NumberSpacingValues, DMW.NumberSpacingKind>(openXmlElement.GetFirstChild<DXO2010W.NumberSpacing>()?.Val?.Value, value, diffs, objName);
  }

  public static void SetNumberSpacing(DX.OpenXmlCompositeElement openXmlElement, DMW.NumberSpacingKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.NumberSpacing>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.NumberSpacingValues, DMW.NumberSpacingKind>(itemElement, (DMW.NumberSpacingKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXO2010W.NumberSpacing, DocumentFormat.OpenXml.Office2010.Word.NumberSpacingValues, DMW.NumberSpacingKind>((DMW.NumberSpacingKind)value));
  }
  #endregion

  #region StylisticSets conversion.
  public static DMW.StylisticSets? GetStylisticSets(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.StylisticSets>();
    if (element != null)
      return DMXW.StylisticSetsConverter.CreateModelElement(element);
    return null;
  }

  public static bool CmpStylisticSets(DX.OpenXmlCompositeElement openXmlElement, DMW.StylisticSets? value, DiffList? diffs, string? objName)
  {
    return DMXW.StylisticSetsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.StylisticSets>(), value, diffs, objName);
  }

  public static void SetStylisticSets(DX.OpenXmlCompositeElement openXmlElement, DMW.StylisticSets? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.StylisticSets>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.StylisticSetsConverter.CreateOpenXmlElement<DXO2010W.StylisticSets>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region ExtBaseRunProperties model conversion.
  public static void UpdateModelElement(DMW.ExtBaseRunProperties value, DX.OpenXmlCompositeElement openXmlElement)
  {
    BaseRunPropertiesConverter.UpdateModelElement(value, openXmlElement);
    value.RunStyle = GetRunStyle(openXmlElement);
    value.RightToLeftText = GetRightToLeftText(openXmlElement);
    value.ComplexScript = GetComplexScript(openXmlElement);
    value.Highlight = GetHighlight(openXmlElement);
    value.ContextualAlternates = GetContextualAlternatives(openXmlElement);
    value.Glow = GetGlow(openXmlElement);
    value.Shadow14 = GetShadow14(openXmlElement);
    value.Reflection = GetReflection(openXmlElement);
    value.TextOutlineEffect = GetTextOutlineEffect(openXmlElement);
    value.FillTextEffect = GetFillTextEffect(openXmlElement);
    value.Scene3D = GetScene3D(openXmlElement);
    value.Properties3D = GetProperties3D(openXmlElement);
    value.Ligatures = GetLigatures(openXmlElement);
    value.NumberingFormat = GetNumberingFormat(openXmlElement);
    value.NumberSpacing = GetNumberSpacing(openXmlElement);
    value.StylisticSets = GetStylisticSets(openXmlElement);
  }

  public static bool CompareModelElement(DX.OpenXmlCompositeElement? openXmlElement, DMW.ExtBaseRunProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!BaseRunPropertiesConverter.CompareModelElement(openXmlElement, value, diffs, objName)) 
        ok = false;
      if (!CmpRunStyle(openXmlElement, value.RunStyle, diffs, objName))
        ok = false;
      if (!CmpRightToLeftText(openXmlElement, value.RightToLeftText, diffs, objName))
        ok = false;
      if (!CmpComplexScript(openXmlElement, value.ComplexScript, diffs, objName))
        ok = false;
      if (!CmpHighlight(openXmlElement, value.Highlight, diffs, objName))
        ok = false;
      if (!CmpGlow(openXmlElement, value.Glow, diffs, objName))
        ok = false;
      if (!CmpShadow14(openXmlElement, value.Shadow14, diffs, objName))
        ok = false;
      if (!CmpReflection(openXmlElement, value.Reflection, diffs, objName))
        ok = false;
      if (!CmpTextOutlineEffect(openXmlElement, value.TextOutlineEffect, diffs, objName))
        ok = false;
      if (!CmpFillTextEffect(openXmlElement, value.FillTextEffect, diffs, objName))
        ok = false;
      if (!CmpScene3D(openXmlElement, value.Scene3D, diffs, objName))
        ok = false;
      if (!CmpProperties3D(openXmlElement, value.Properties3D, diffs, objName))
        ok = false;
      if (!CmpLigatures(openXmlElement, value.Ligatures, diffs, objName))
        ok = false;
      if (!CmpNumberingFormat(openXmlElement, value.NumberingFormat, diffs, objName))
        ok = false;
      if (!CmpNumberSpacing(openXmlElement, value.NumberSpacing, diffs, objName))
        ok = false;
      if (!CmpStylisticSets(openXmlElement, value.StylisticSets, diffs, objName))
        ok = false;
      if (!CmpContextualAlternatives(openXmlElement, value.ContextualAlternates, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.ExtBaseRunProperties value)
    where OpenXmlElementType : DX.OpenXmlCompositeElement, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }

  public static void UpdateOpenXmlElement(DX.OpenXmlCompositeElement openXmlElement, DMW.ExtBaseRunProperties value)
  {
    BaseRunPropertiesConverter.UpdateOpenXmlElement(openXmlElement, value);
    SetRunStyle(openXmlElement, value.RunStyle);
    SetRightToLeftText(openXmlElement, value.RightToLeftText);
    SetComplexScript(openXmlElement, value.ComplexScript);
    SetHighlight(openXmlElement, value.Highlight);
    SetGlow(openXmlElement, value.Glow);
    SetShadow14(openXmlElement, value.Shadow14);
    SetReflection(openXmlElement, value.Reflection);
    SetTextOutlineEffect(openXmlElement, value.TextOutlineEffect);
    SetFillTextEffect(openXmlElement, value.FillTextEffect);
    SetScene3D(openXmlElement, value.Scene3D);
    SetProperties3D(openXmlElement, value.Properties3D);
    SetLigatures(openXmlElement, value.Ligatures);
    SetNumberingFormat(openXmlElement, value.NumberingFormat);
    SetNumberSpacing(openXmlElement, value.NumberSpacing);
    SetStylisticSets(openXmlElement, value.StylisticSets);
    SetContextualAlternatives(openXmlElement, value.ContextualAlternates);
  }
  #endregion

}
