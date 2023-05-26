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

  public static bool CmpRunStyle(DX.OpenXmlCompositeElement openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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

  public static bool CmpRightToLeftText(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.RightToLeftText>(), value, diffs, objName, propName);
  }

  public static void SetRightToLeftText(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.RightToLeftText>(openXmlElement, value, "0", null);
  }

  #endregion

  #region ComplexScript conversion.
  public static Boolean? GetComplexScript(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.ComplexScript>());
  }

  public static bool CmpComplexScript(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.ComplexScript>(), value, diffs, objName, propName);
  }

  public static void SetComplexScript(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.ComplexScript>(openXmlElement, value, "0", null);
  }

  #endregion

  #region Highlight conversion.
  public static DMW.HighlightColorKind? GetHighlight(DX.OpenXmlCompositeElement openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.HighlightColorValues, DMW.HighlightColorKind>(openXmlElement.GetFirstChild<DXW.Highlight>()?.Val?.Value);
  }

  public static bool CmpHighlight(DX.OpenXmlCompositeElement openXmlElement, DMW.HighlightColorKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DXW.HighlightColorValues, DMW.HighlightColorKind>(openXmlElement.GetFirstChild<DXW.Highlight>()?.Val?.Value, value, diffs, objName, propName);
  }

  public static void SetHighlight(DX.OpenXmlCompositeElement openXmlElement, DMW.HighlightColorKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Highlight>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DXW.HighlightColorValues, DMW.HighlightColorKind>(itemElement, (DMW.HighlightColorKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXW.Highlight, DXW.HighlightColorValues, DMW.HighlightColorKind>((DMW.HighlightColorKind)value));
  }
  #endregion

  #region ContextualAlternatives conversion
  public static DMW.OnOffKind? GetContextualAlternatives(DX.OpenXmlCompositeElement openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DMW.OnOffKind>(openXmlElement.GetFirstChild<DXO10W.ContextualAlternatives>()?.Val?.Value);
  }

  public static bool CmpContextualAlternatives(DX.OpenXmlCompositeElement openXmlElement, DMW.OnOffKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DMW.OnOffKind>(openXmlElement.GetFirstChild<DXO10W.ContextualAlternatives>()?.Val?.Value, value, diffs, objName, propName);
  }

  public static void SetContextualAlternatives(DX.OpenXmlCompositeElement openXmlElement, DMW.OnOffKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10W.ContextualAlternatives>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DMW.OnOffKind>(itemElement, (DMW.OnOffKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXO10W.ContextualAlternatives, DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DMW.OnOffKind>((DMW.OnOffKind)value));
  }
  #endregion

  #region Glow conversion
  public static DMW.Glow? GetGlow(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10W.Glow>();
    if (element != null)
      return DMXW.GlowConverter.CreateModelElement(element);
    return null;
  }

  public static bool CmpGlow(DX.OpenXmlCompositeElement openXmlElement, DMW.Glow? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.GlowConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10W.Glow>(), value, diffs, objName, propName);
  }

  public static void SetGlow(DX.OpenXmlCompositeElement openXmlElement, DMW.Glow? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10W.Glow>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.GlowConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region Shadow14 conversion.
  public static DMW.Shadow? GetShadow14(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10W.Shadow>();
    if (element != null)
      return DMXW.ShadowConverter.CreateModelElement(element);
    return null;
  }

  public static bool CmpShadow14(DX.OpenXmlCompositeElement openXmlElement, DMW.Shadow? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.ShadowConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10W.Shadow>(), value, diffs, objName, propName);
  }

  public static void SetShadow14(DX.OpenXmlCompositeElement openXmlElement, DMW.Shadow? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10W.Shadow>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ShadowConverter.CreateOpenXmlElement<DXO10W.Shadow>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region Reflection conversion.
  public static DMW.Reflection? GetReflection(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10W.Reflection>();
    if (element != null)
      return DMXW.ReflectionConverter.CreateModelElement(element);
    return null;
  }

  public static bool CmpReflection(DX.OpenXmlCompositeElement openXmlElement, DMW.Reflection? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.ReflectionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10W.Reflection>(), value, diffs, objName, propName);
  }

  public static void SetReflection(DX.OpenXmlCompositeElement openXmlElement, DMW.Reflection? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10W.Reflection>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ReflectionConverter.CreateOpenXmlElement<DXO10W.Reflection>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion
  
  #region TextOutlineEffect conversion.
  public static DMW.TextOutlineEffect? GetTextOutlineEffect(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10W.TextOutlineEffect>();
    if (element != null)
      return DMXW.TextOutlineEffectConverter.CreateModelElement(element);
    return null;
  }

  public static bool CmpTextOutlineEffect(DX.OpenXmlCompositeElement openXmlElement, DMW.TextOutlineEffect? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.TextOutlineEffectConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10W.TextOutlineEffect>(), value, diffs, objName, propName);
  }

  public static void SetTextOutlineEffect(DX.OpenXmlCompositeElement openXmlElement, DMW.TextOutlineEffect? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10W.TextOutlineEffect>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TextOutlineEffectConverter.CreateOpenXmlElement<DXO10W.TextOutlineEffect>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region FillTextEffect conversion.
  public static DMW.FillTextEffect? GetFillTextEffect(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10W.FillTextEffect>();
    if (element != null)
      return DMXW.FillTextEffectConverter.CreateModelElement(element);
    return null;
  }

  public static bool CmpFillTextEffect(DX.OpenXmlCompositeElement openXmlElement, DMW.FillTextEffect? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.FillTextEffectConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10W.FillTextEffect>(), value, diffs, objName, propName);
  }

  public static void SetFillTextEffect(DX.OpenXmlCompositeElement openXmlElement, DMW.FillTextEffect? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10W.FillTextEffect>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.FillTextEffectConverter.CreateOpenXmlElement<DXO10W.FillTextEffect>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region Scene3D conversion.
  public static DMW.Scene3D? GetScene3D(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10W.Scene3D>();
    if (element != null)
      return DMXW.Scene3DConverter.CreateModelElement(element);
    return null;
  }

  public static bool CmpScene3D(DX.OpenXmlCompositeElement openXmlElement, DMW.Scene3D? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.Scene3DConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10W.Scene3D>(), value, diffs, objName, propName);
  }

  public static void SetScene3D(DX.OpenXmlCompositeElement openXmlElement, DMW.Scene3D? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10W.Scene3D>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.Scene3DConverter.CreateOpenXmlElement<DXO10W.Scene3D>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region Properties3D conversion.
  public static DMW.Properties3D? GetProperties3D(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10W.Properties3D>();
    if (element != null)
      return DMXW.Properties3DConverter.CreateModelElement(element);
    return null;
  }

  public static bool CmpProperties3D(DX.OpenXmlCompositeElement openXmlElement, DMW.Properties3D? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.Properties3DConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10W.Properties3D>(), value, diffs, objName, propName);
  }

  public static void SetProperties3D(DX.OpenXmlCompositeElement openXmlElement, DMW.Properties3D? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10W.Properties3D>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.Properties3DConverter.CreateOpenXmlElement<DXO10W.Properties3D>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region Ligatures conversion.
  public static DMW.LigaturesKind? GetLigatures(DX.OpenXmlCompositeElement openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.LigaturesValues, DMW.LigaturesKind>(openXmlElement.GetFirstChild<DXO10W.Ligatures>()?.Val?.Value);
  }

  public static bool CmpLigatures(DX.OpenXmlCompositeElement openXmlElement, DMW.LigaturesKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.Word.LigaturesValues, DMW.LigaturesKind>(openXmlElement.GetFirstChild<DXO10W.Ligatures>()?.Val?.Value, value, diffs, objName, propName);
  }

  public static void SetLigatures(DX.OpenXmlCompositeElement openXmlElement, DMW.LigaturesKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10W.Ligatures>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.LigaturesValues, DMW.LigaturesKind>(itemElement, (DMW.LigaturesKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXO10W.Ligatures, DocumentFormat.OpenXml.Office2010.Word.LigaturesValues, DMW.LigaturesKind>((DMW.LigaturesKind)value));
  }
  #endregion

  #region NumberingFormat conversion.
  public static DMW.NumberFormKind? GetNumberingFormat(DX.OpenXmlCompositeElement openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.NumberFormValues, DMW.NumberFormKind>(openXmlElement.GetFirstChild<DXO10W.NumberingFormat>()?.Val?.Value);
  }

  public static bool CmpNumberingFormat(DX.OpenXmlCompositeElement openXmlElement, DMW.NumberFormKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.Word.NumberFormValues, DMW.NumberFormKind>(openXmlElement.GetFirstChild<DXO10W.NumberingFormat>()?.Val?.Value, value, diffs, objName, propName);
  }

  public static void SetNumberingFormat(DX.OpenXmlCompositeElement openXmlElement, DMW.NumberFormKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10W.NumberingFormat>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.NumberFormValues, DMW.NumberFormKind>(itemElement, (DMW.NumberFormKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXO10W.NumberingFormat, DocumentFormat.OpenXml.Office2010.Word.NumberFormValues, DMW.NumberFormKind>((DMW.NumberFormKind)value));
  }
  #endregion

  #region NumberSpacing conversion.
  public static DMW.NumberSpacingKind? GetNumberSpacing(DX.OpenXmlCompositeElement openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.NumberSpacingValues, DMW.NumberSpacingKind>(openXmlElement.GetFirstChild<DXO10W.NumberSpacing>()?.Val?.Value);
  }

  public static bool CmpNumberSpacing(DX.OpenXmlCompositeElement openXmlElement, DMW.NumberSpacingKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.Word.NumberSpacingValues, DMW.NumberSpacingKind>(openXmlElement.GetFirstChild<DXO10W.NumberSpacing>()?.Val?.Value, value, diffs, objName, propName);
  }

  public static void SetNumberSpacing(DX.OpenXmlCompositeElement openXmlElement, DMW.NumberSpacingKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10W.NumberSpacing>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.NumberSpacingValues, DMW.NumberSpacingKind>(itemElement, (DMW.NumberSpacingKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXO10W.NumberSpacing, DocumentFormat.OpenXml.Office2010.Word.NumberSpacingValues, DMW.NumberSpacingKind>((DMW.NumberSpacingKind)value));
  }
  #endregion

  #region StylisticSets conversion.
  public static DMW.StylisticSets? GetStylisticSets(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10W.StylisticSets>();
    if (element != null)
      return DMXW.StylisticSetsConverter.CreateModelElement(element);
    return null;
  }

  public static bool CmpStylisticSets(DX.OpenXmlCompositeElement openXmlElement, DMW.StylisticSets? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.StylisticSetsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10W.StylisticSets>(), value, diffs, objName, propName);
  }

  public static void SetStylisticSets(DX.OpenXmlCompositeElement openXmlElement, DMW.StylisticSets? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10W.StylisticSets>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.StylisticSetsConverter.CreateOpenXmlElement<DXO10W.StylisticSets>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region ExtBaseRunProperties model conversion.
  public static void UpdateModelElement(DMW.ExtBaseRunProperties model, DX.OpenXmlCompositeElement openXmlElement)
  {
    BaseRunPropertiesConverter.UpdateModelElement(model, openXmlElement);
    model.RunStyle = GetRunStyle(openXmlElement);
    model.RightToLeftText = GetRightToLeftText(openXmlElement);
    model.ComplexScript = GetComplexScript(openXmlElement);
    model.Highlight = GetHighlight(openXmlElement);
    model.ContextualAlternates = GetContextualAlternatives(openXmlElement);
    model.Glow = GetGlow(openXmlElement);
    model.Shadow14 = GetShadow14(openXmlElement);
    model.Reflection = GetReflection(openXmlElement);
    model.TextOutlineEffect = GetTextOutlineEffect(openXmlElement);
    model.FillTextEffect = GetFillTextEffect(openXmlElement);
    model.Scene3D = GetScene3D(openXmlElement);
    model.Properties3D = GetProperties3D(openXmlElement);
    model.Ligatures = GetLigatures(openXmlElement);
    model.NumberingFormat = GetNumberingFormat(openXmlElement);
    model.NumberSpacing = GetNumberSpacing(openXmlElement);
    model.StylisticSets = GetStylisticSets(openXmlElement);
  }

  public static bool CompareModelElement(DX.OpenXmlCompositeElement? openXmlElement, DMW.ExtBaseRunProperties? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!BaseRunPropertiesConverter.CompareModelElement(openXmlElement, model, diffs, objName, propName)) 
        ok = false;
      if (!CmpRunStyle(openXmlElement, model.RunStyle, diffs, objName, propName))
        ok = false;
      if (!CmpRightToLeftText(openXmlElement, model.RightToLeftText, diffs, objName, propName))
        ok = false;
      if (!CmpComplexScript(openXmlElement, model.ComplexScript, diffs, objName, propName))
        ok = false;
      if (!CmpHighlight(openXmlElement, model.Highlight, diffs, objName, propName))
        ok = false;
      if (!CmpGlow(openXmlElement, model.Glow, diffs, objName, propName))
        ok = false;
      if (!CmpShadow14(openXmlElement, model.Shadow14, diffs, objName, propName))
        ok = false;
      if (!CmpReflection(openXmlElement, model.Reflection, diffs, objName, propName))
        ok = false;
      if (!CmpTextOutlineEffect(openXmlElement, model.TextOutlineEffect, diffs, objName, propName))
        ok = false;
      if (!CmpFillTextEffect(openXmlElement, model.FillTextEffect, diffs, objName, propName))
        ok = false;
      if (!CmpScene3D(openXmlElement, model.Scene3D, diffs, objName, propName))
        ok = false;
      if (!CmpProperties3D(openXmlElement, model.Properties3D, diffs, objName, propName))
        ok = false;
      if (!CmpLigatures(openXmlElement, model.Ligatures, diffs, objName, propName))
        ok = false;
      if (!CmpNumberingFormat(openXmlElement, model.NumberingFormat, diffs, objName, propName))
        ok = false;
      if (!CmpNumberSpacing(openXmlElement, model.NumberSpacing, diffs, objName, propName))
        ok = false;
      if (!CmpStylisticSets(openXmlElement, model.StylisticSets, diffs, objName, propName))
        ok = false;
      if (!CmpContextualAlternatives(openXmlElement, model.ContextualAlternates, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.ExtBaseRunProperties model)
    where OpenXmlElementType : DX.OpenXmlCompositeElement, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }

  public static void UpdateOpenXmlElement(DX.OpenXmlCompositeElement openXmlElement, DMW.ExtBaseRunProperties model)
  {
    BaseRunPropertiesConverter.UpdateOpenXmlElement(openXmlElement, model);
    SetRunStyle(openXmlElement, model.RunStyle);
    SetRightToLeftText(openXmlElement, model.RightToLeftText);
    SetComplexScript(openXmlElement, model.ComplexScript);
    SetHighlight(openXmlElement, model.Highlight);
    SetGlow(openXmlElement, model.Glow);
    SetShadow14(openXmlElement, model.Shadow14);
    SetReflection(openXmlElement, model.Reflection);
    SetTextOutlineEffect(openXmlElement, model.TextOutlineEffect);
    SetFillTextEffect(openXmlElement, model.FillTextEffect);
    SetScene3D(openXmlElement, model.Scene3D);
    SetProperties3D(openXmlElement, model.Properties3D);
    SetLigatures(openXmlElement, model.Ligatures);
    SetNumberingFormat(openXmlElement, model.NumberingFormat);
    SetNumberSpacing(openXmlElement, model.NumberSpacing);
    SetStylisticSets(openXmlElement, model.StylisticSets);
    SetContextualAlternatives(openXmlElement, model.ContextualAlternates);
  }
  #endregion

}
