namespace DocumentModel.OpenXml.Math;

/// <summary>
/// <see cref="DMM.MathProperties"/> class from/to OpenXml converter.
/// </summary>
public static class MathPropertiesConverter
{
  #region Math Font. conversion.
  private static String? GetMathFont(DXM.MathProperties openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXM.MathFont>()?.Val);
  }
  
  private static bool CmpMathFont(DXM.MathProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXM.MathFont>()?.Val, value, diffs, objName, "MathFont");
  }
  
  private static void SetMathFont(DXM.MathProperties openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXM.MathFont>(openXmlElement, value);
  }
  #endregion

  #region Break on Binary Operators conversion.
  private static DMM.BreakBinaryOperatorKind? GetBreakBinary(DXM.MathProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BreakBinaryOperatorValues, DMM.BreakBinaryOperatorKind>(openXmlElement.GetFirstChild<DXM.BreakBinary>()?.Val?.Value);
  }
  
  private static bool CmpBreakBinary(DXM.MathProperties openXmlElement, DMM.BreakBinaryOperatorKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.BreakBinaryOperatorValues, DMM.BreakBinaryOperatorKind>(openXmlElement.GetFirstChild<DXM.BreakBinary>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetBreakBinary(DXM.MathProperties openXmlElement, DMM.BreakBinaryOperatorKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.BreakBinary>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Math.BreakBinaryOperatorValues, DMM.BreakBinaryOperatorKind>(itemElement, (DMM.BreakBinaryOperatorKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXM.BreakBinary, DocumentFormat.OpenXml.Math.BreakBinaryOperatorValues, DMM.BreakBinaryOperatorKind>((DMM.BreakBinaryOperatorKind)value));
  }
  #endregion

  #region Break on Binary Subtraction conversion.
  private static DMM.BreakBinarySubtractionKind? GetBreakBinarySubtraction(DXM.MathProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BreakBinarySubtractionValues, DMM.BreakBinarySubtractionKind>(openXmlElement.GetFirstChild<DXM.BreakBinarySubtraction>()?.Val?.Value);
  }
  
  private static bool CmpBreakBinarySubtraction(DXM.MathProperties openXmlElement, DMM.BreakBinarySubtractionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.BreakBinarySubtractionValues, DMM.BreakBinarySubtractionKind>(openXmlElement.GetFirstChild<DXM.BreakBinarySubtraction>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetBreakBinarySubtraction(DXM.MathProperties openXmlElement, DMM.BreakBinarySubtractionKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.BreakBinarySubtraction>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Math.BreakBinarySubtractionValues, DMM.BreakBinarySubtractionKind>(itemElement, (DMM.BreakBinarySubtractionKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXM.BreakBinarySubtraction, DocumentFormat.OpenXml.Math.BreakBinarySubtractionValues, DMM.BreakBinarySubtractionKind>((DMM.BreakBinarySubtractionKind)value));
  }
  #endregion

  #region Small Fraction conversion.
  private static bool? GetSmallFraction(DXM.MathProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXM.SmallFraction>()?.Val?.Value);
  }
  
  private static bool CmpSmallFraction(DXM.MathProperties openXmlElement, bool? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXM.SmallFraction>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetSmallFraction(DXM.MathProperties openXmlElement, bool? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.SmallFraction>();
    if (itemElement != null)
    {
      if (value != null)
        BooleanValueConverter.UpdateOpenXmlElement(itemElement, (bool)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(BooleanValueConverter.CreateMathOpenXmlElement<DXM.SmallFraction>((bool)value));
  }
  #endregion

  #region Use Display Math Defaults conversion.
  private static bool? GetDisplayDefaults(DXM.MathProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXM.DisplayDefaults>()?.Val?.Value);
  }
  
  private static bool CmpDisplayDefaults(DXM.MathProperties openXmlElement, bool? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXM.DisplayDefaults>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetDisplayDefaults(DXM.MathProperties openXmlElement, bool? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.DisplayDefaults>();
    if (itemElement != null)
    {
      if (value != null)
        BooleanValueConverter.UpdateOpenXmlElement(itemElement, (bool)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(BooleanValueConverter.CreateOpenXmlElement<DXM.DisplayDefaults>((bool)value));
  }
  #endregion

  #region Left Margin conversion.
  private static UInt32? GetLeftMargin(DXM.MathProperties openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXM.LeftMargin>()?.Val);
  }
  
  private static bool CmpLeftMargin(DXM.MathProperties openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXM.LeftMargin>()?.Val, value, diffs, objName, "LeftMargin");
  }
  
  private static void SetLeftMargin(DXM.MathProperties openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXM.LeftMargin,System.UInt32>(openXmlElement, value);
  }
  #endregion

  #region Right Margin conversion.
  private static UInt32? GetRightMargin(DXM.MathProperties openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXM.RightMargin>()?.Val);
  }
  
  private static bool CmpRightMargin(DXM.MathProperties openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXM.RightMargin>()?.Val, value, diffs, objName, "RightMargin");
  }
  
  private static void SetRightMargin(DXM.MathProperties openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXM.RightMargin,System.UInt32>(openXmlElement, value);
  }
  #endregion

  #region Default Justification conversion.
  private static DMM.JustificationKind? GetDefaultJustification(DXM.MathProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.JustificationValues, DMM.JustificationKind>(openXmlElement.GetFirstChild<DXM.DefaultJustification>()?.Val?.Value);
  }
  
  private static bool CmpDefaultJustification(DXM.MathProperties openXmlElement, DMM.JustificationKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.JustificationValues, DMM.JustificationKind>(openXmlElement.GetFirstChild<DXM.DefaultJustification>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetDefaultJustification(DXM.MathProperties openXmlElement, DMM.JustificationKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.DefaultJustification>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Math.JustificationValues, DMM.JustificationKind>(itemElement, (DMM.JustificationKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXM.DefaultJustification, DocumentFormat.OpenXml.Math.JustificationValues, DMM.JustificationKind>((DMM.JustificationKind)value));
  }
  #endregion

  #region Pre-Equation Spacing conversion.
  private static UInt32? GetPreSpacing(DXM.MathProperties openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXM.PreSpacing>()?.Val);
  }
  
  private static bool CmpPreSpacing(DXM.MathProperties openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXM.PreSpacing>()?.Val, value, diffs, objName, "PreSpacing");
  }
  
  private static void SetPreSpacing(DXM.MathProperties openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXM.PreSpacing,System.UInt32>(openXmlElement, value);
  }
  #endregion

  #region Post-Equation Spacing conversion.
  private static UInt32? GetPostSpacing(DXM.MathProperties openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXM.PostSpacing>()?.Val);
  }
  
  private static bool CmpPostSpacing(DXM.MathProperties openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXM.PostSpacing>()?.Val, value, diffs, objName, "PostSpacing");
  }
  
  private static void SetPostSpacing(DXM.MathProperties openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXM.PostSpacing,System.UInt32>(openXmlElement, value);
  }
  #endregion

  #region Inter-Equation Spacing conversion.
  private static UInt32? GetInterSpacing(DXM.MathProperties openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXM.InterSpacing>()?.Val);
  }
  
  private static bool CmpInterSpacing(DXM.MathProperties openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXM.InterSpacing>()?.Val, value, diffs, objName, "InterSpacing");
  }
  
  private static void SetInterSpacing(DXM.MathProperties openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXM.InterSpacing,System.UInt32>(openXmlElement, value);
  }
  #endregion

  #region Intra-Equation Spacing conversion.
  private static UInt32? GetIntraSpacing(DXM.MathProperties openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXM.IntraSpacing>()?.Val);
  }
  
  private static bool CmpIntraSpacing(DXM.MathProperties openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXM.IntraSpacing>()?.Val, value, diffs, objName, "IntraSpacing");
  }
  
  private static void SetIntraSpacing(DXM.MathProperties openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXM.IntraSpacing,System.UInt32>(openXmlElement, value);
  }
  
  private static UInt32? GetWrapIndent(DXM.MathProperties openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXM.WrapIndent>()?.Val);
  }
  
  private static bool CmpWrapIndent(DXM.MathProperties openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXM.WrapIndent>()?.Val, value, diffs, objName, "WrapIndent");
  }
  
  private static void SetWrapIndent(DXM.MathProperties openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXM.WrapIndent,System.UInt32>(openXmlElement, value);
  }
  
  private static bool? GetWrapRight(DXM.MathProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXM.WrapRight>()?.Val?.Value);
  }
  
  private static bool CmpWrapRight(DXM.MathProperties openXmlElement, bool? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXM.WrapRight>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetWrapRight(DXM.MathProperties openXmlElement, bool? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.WrapRight>();
    if (itemElement != null)
    {
      if (value != null)
        BooleanValueConverter.UpdateOpenXmlElement(itemElement, (bool)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(BooleanValueConverter.CreateOpenXmlElement<DXM.WrapRight>((bool)value));
  }
  
  private static DMM.LimitLocationKind? GetIntegralLimitLocation(DXM.MathProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.LimitLocationValues, DMM.LimitLocationKind>(openXmlElement.GetFirstChild<DXM.IntegralLimitLocation>()?.Val?.Value);
  }
  
  private static bool CmpIntegralLimitLocation(DXM.MathProperties openXmlElement, DMM.LimitLocationKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.LimitLocationValues, DMM.LimitLocationKind>(openXmlElement.GetFirstChild<DXM.IntegralLimitLocation>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetIntegralLimitLocation(DXM.MathProperties openXmlElement, DMM.LimitLocationKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.IntegralLimitLocation>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Math.LimitLocationValues, DMM.LimitLocationKind>(itemElement, (DMM.LimitLocationKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXM.IntegralLimitLocation, DocumentFormat.OpenXml.Math.LimitLocationValues, DMM.LimitLocationKind>((DMM.LimitLocationKind)value));
  }
  
  private static DMM.LimitLocationKind? GetNaryLimitLocation(DXM.MathProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.LimitLocationValues, DMM.LimitLocationKind>(openXmlElement.GetFirstChild<DXM.NaryLimitLocation>()?.Val?.Value);
  }
  
  private static bool CmpNaryLimitLocation(DXM.MathProperties openXmlElement, DMM.LimitLocationKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.LimitLocationValues, DMM.LimitLocationKind>(openXmlElement.GetFirstChild<DXM.NaryLimitLocation>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetNaryLimitLocation(DXM.MathProperties openXmlElement, DMM.LimitLocationKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.NaryLimitLocation>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Math.LimitLocationValues, DMM.LimitLocationKind>(itemElement, (DMM.LimitLocationKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXM.NaryLimitLocation, DocumentFormat.OpenXml.Math.LimitLocationValues, DMM.LimitLocationKind>((DMM.LimitLocationKind)value));
  }
  #endregion

  #region MathProperties model conversion.
  public static DMM.MathProperties? CreateModelElement(DXM.MathProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMM.MathProperties();
      model.MathFont = GetMathFont(openXmlElement);
      model.BreakBinary = GetBreakBinary(openXmlElement);
      model.BreakBinarySubtraction = GetBreakBinarySubtraction(openXmlElement);
      model.SmallFraction = GetSmallFraction(openXmlElement);
      model.DisplayDefaults = GetDisplayDefaults(openXmlElement);
      model.LeftMargin = GetLeftMargin(openXmlElement);
      model.RightMargin = GetRightMargin(openXmlElement);
      model.DefaultJustification = GetDefaultJustification(openXmlElement);
      model.PreSpacing = GetPreSpacing(openXmlElement);
      model.PostSpacing = GetPostSpacing(openXmlElement);
      model.InterSpacing = GetInterSpacing(openXmlElement);
      model.IntraSpacing = GetIntraSpacing(openXmlElement);
      model.WrapIndent = GetWrapIndent(openXmlElement);
      model.WrapRight = GetWrapRight(openXmlElement);
      model.IntegralLimitLocation = GetIntegralLimitLocation(openXmlElement);
      model.NaryLimitLocation = GetNaryLimitLocation(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXM.MathProperties? openXmlElement, DMM.MathProperties? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpMathFont(openXmlElement, model.MathFont, diffs, objName))
        ok = false;
      if (!CmpBreakBinary(openXmlElement, model.BreakBinary, diffs, objName))
        ok = false;
      if (!CmpBreakBinarySubtraction(openXmlElement, model.BreakBinarySubtraction, diffs, objName))
        ok = false;
      if (!CmpSmallFraction(openXmlElement, model.SmallFraction, diffs, objName))
        ok = false;
      if (!CmpDisplayDefaults(openXmlElement, model.DisplayDefaults, diffs, objName))
        ok = false;
      if (!CmpLeftMargin(openXmlElement, model.LeftMargin, diffs, objName))
        ok = false;
      if (!CmpRightMargin(openXmlElement, model.RightMargin, diffs, objName))
        ok = false;
      if (!CmpDefaultJustification(openXmlElement, model.DefaultJustification, diffs, objName))
        ok = false;
      if (!CmpPreSpacing(openXmlElement, model.PreSpacing, diffs, objName))
        ok = false;
      if (!CmpPostSpacing(openXmlElement, model.PostSpacing, diffs, objName))
        ok = false;
      if (!CmpInterSpacing(openXmlElement, model.InterSpacing, diffs, objName))
        ok = false;
      if (!CmpIntraSpacing(openXmlElement, model.IntraSpacing, diffs, objName))
        ok = false;
      if (!CmpWrapIndent(openXmlElement, model.WrapIndent, diffs, objName))
        ok = false;
      if (!CmpWrapRight(openXmlElement, model.WrapRight, diffs, objName))
        ok = false;
      if (!CmpIntegralLimitLocation(openXmlElement, model.IntegralLimitLocation, diffs, objName))
        ok = false;
      if (!CmpNaryLimitLocation(openXmlElement, model.NaryLimitLocation, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMM.MathProperties model)
    where OpenXmlElementType: DXM.MathProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXM.MathProperties openXmlElement, DMM.MathProperties model)
  {
    SetMathFont(openXmlElement, model?.MathFont);
    SetBreakBinary(openXmlElement, model?.BreakBinary);
    SetBreakBinarySubtraction(openXmlElement, model?.BreakBinarySubtraction);
    SetSmallFraction(openXmlElement, model?.SmallFraction);
    SetDisplayDefaults(openXmlElement, model?.DisplayDefaults);
    SetLeftMargin(openXmlElement, model?.LeftMargin);
    SetRightMargin(openXmlElement, model?.RightMargin);
    SetDefaultJustification(openXmlElement, model?.DefaultJustification);
    SetPreSpacing(openXmlElement, model?.PreSpacing);
    SetPostSpacing(openXmlElement, model?.PostSpacing);
    SetInterSpacing(openXmlElement, model?.InterSpacing);
    SetIntraSpacing(openXmlElement, model?.IntraSpacing);
    SetWrapIndent(openXmlElement, model?.WrapIndent);
    SetWrapRight(openXmlElement, model?.WrapRight);
    SetIntegralLimitLocation(openXmlElement, model?.IntegralLimitLocation);
    SetNaryLimitLocation(openXmlElement, model?.NaryLimitLocation);
  }
  #endregion
}
