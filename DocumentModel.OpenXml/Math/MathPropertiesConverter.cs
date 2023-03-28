namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Math Properties converter from/to OpenXml.
///</summary>
public static class MathPropertiesConverter
{
  /// <summary>
  /// Math Font.
  /// </summary>
  private static String? GetMathFont(DXMath.MathProperties openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXMath.MathFont>()?.Val);
  }
  
  private static bool CmpMathFont(DXMath.MathProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXMath.MathFont>()?.Val, value, diffs, objName, "MathFont");
  }
  
  private static void SetMathFont(DXMath.MathProperties openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXMath.MathFont>(openXmlElement, value);
  }
  
  /// <summary>
  /// Break on Binary Operators.
  /// </summary>
  private static DMMath.BreakBinaryOperatorKind? GetBreakBinary(DXMath.MathProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BreakBinaryOperatorValues, DMMath.BreakBinaryOperatorKind>(openXmlElement.GetFirstChild<DXMath.BreakBinary>()?.Val?.Value);
  }
  
  private static bool CmpBreakBinary(DXMath.MathProperties openXmlElement, DMMath.BreakBinaryOperatorKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.BreakBinaryOperatorValues, DMMath.BreakBinaryOperatorKind>(openXmlElement.GetFirstChild<DXMath.BreakBinary>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetBreakBinary(DXMath.MathProperties openXmlElement, DMMath.BreakBinaryOperatorKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.BreakBinary>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Math.BreakBinaryOperatorValues, DMMath.BreakBinaryOperatorKind>(itemElement, (DMMath.BreakBinaryOperatorKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXMath.BreakBinary, DocumentFormat.OpenXml.Math.BreakBinaryOperatorValues, DMMath.BreakBinaryOperatorKind>((DMMath.BreakBinaryOperatorKind)value));
  }
  
  /// <summary>
  /// Break on Binary Subtraction.
  /// </summary>
  private static DMMath.BreakBinarySubtractionKind? GetBreakBinarySubtraction(DXMath.MathProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BreakBinarySubtractionValues, DMMath.BreakBinarySubtractionKind>(openXmlElement.GetFirstChild<DXMath.BreakBinarySubtraction>()?.Val?.Value);
  }
  
  private static bool CmpBreakBinarySubtraction(DXMath.MathProperties openXmlElement, DMMath.BreakBinarySubtractionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.BreakBinarySubtractionValues, DMMath.BreakBinarySubtractionKind>(openXmlElement.GetFirstChild<DXMath.BreakBinarySubtraction>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetBreakBinarySubtraction(DXMath.MathProperties openXmlElement, DMMath.BreakBinarySubtractionKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.BreakBinarySubtraction>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Math.BreakBinarySubtractionValues, DMMath.BreakBinarySubtractionKind>(itemElement, (DMMath.BreakBinarySubtractionKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXMath.BreakBinarySubtraction, DocumentFormat.OpenXml.Math.BreakBinarySubtractionValues, DMMath.BreakBinarySubtractionKind>((DMMath.BreakBinarySubtractionKind)value));
  }
  
  /// <summary>
  /// Small Fraction.
  /// </summary>
  private static DMMath.BooleanKind? GetSmallFraction(DXMath.MathProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.SmallFraction>()?.Val?.Value);
  }
  
  private static bool CmpSmallFraction(DXMath.MathProperties openXmlElement, DMMath.BooleanKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.SmallFraction>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetSmallFraction(DXMath.MathProperties openXmlElement, DMMath.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.SmallFraction>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(itemElement, (DMMath.BooleanKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXMath.SmallFraction, DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>((DMMath.BooleanKind)value));
  }
  
  /// <summary>
  /// Use Display Math Defaults.
  /// </summary>
  private static DMMath.BooleanKind? GetDisplayDefaults(DXMath.MathProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.DisplayDefaults>()?.Val?.Value);
  }
  
  private static bool CmpDisplayDefaults(DXMath.MathProperties openXmlElement, DMMath.BooleanKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.DisplayDefaults>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetDisplayDefaults(DXMath.MathProperties openXmlElement, DMMath.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.DisplayDefaults>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(itemElement, (DMMath.BooleanKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXMath.DisplayDefaults, DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>((DMMath.BooleanKind)value));
  }
  
  /// <summary>
  /// Left Margin.
  /// </summary>
  private static UInt32? GetLeftMargin(DXMath.MathProperties openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXMath.LeftMargin>()?.Val);
  }
  
  private static bool CmpLeftMargin(DXMath.MathProperties openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXMath.LeftMargin>()?.Val, value, diffs, objName, "LeftMargin");
  }
  
  private static void SetLeftMargin(DXMath.MathProperties openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXMath.LeftMargin,System.UInt32>(openXmlElement, value);
  }
  
  /// <summary>
  /// Right Margin.
  /// </summary>
  private static UInt32? GetRightMargin(DXMath.MathProperties openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXMath.RightMargin>()?.Val);
  }
  
  private static bool CmpRightMargin(DXMath.MathProperties openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXMath.RightMargin>()?.Val, value, diffs, objName, "RightMargin");
  }
  
  private static void SetRightMargin(DXMath.MathProperties openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXMath.RightMargin,System.UInt32>(openXmlElement, value);
  }
  
  /// <summary>
  /// Default Justification.
  /// </summary>
  private static DMMath.JustificationKind? GetDefaultJustification(DXMath.MathProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.JustificationValues, DMMath.JustificationKind>(openXmlElement.GetFirstChild<DXMath.DefaultJustification>()?.Val?.Value);
  }
  
  private static bool CmpDefaultJustification(DXMath.MathProperties openXmlElement, DMMath.JustificationKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.JustificationValues, DMMath.JustificationKind>(openXmlElement.GetFirstChild<DXMath.DefaultJustification>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetDefaultJustification(DXMath.MathProperties openXmlElement, DMMath.JustificationKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.DefaultJustification>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Math.JustificationValues, DMMath.JustificationKind>(itemElement, (DMMath.JustificationKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXMath.DefaultJustification, DocumentFormat.OpenXml.Math.JustificationValues, DMMath.JustificationKind>((DMMath.JustificationKind)value));
  }
  
  /// <summary>
  /// Pre-Equation Spacing.
  /// </summary>
  private static UInt32? GetPreSpacing(DXMath.MathProperties openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXMath.PreSpacing>()?.Val);
  }
  
  private static bool CmpPreSpacing(DXMath.MathProperties openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXMath.PreSpacing>()?.Val, value, diffs, objName, "PreSpacing");
  }
  
  private static void SetPreSpacing(DXMath.MathProperties openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXMath.PreSpacing,System.UInt32>(openXmlElement, value);
  }
  
  /// <summary>
  /// Post-Equation Spacing.
  /// </summary>
  private static UInt32? GetPostSpacing(DXMath.MathProperties openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXMath.PostSpacing>()?.Val);
  }
  
  private static bool CmpPostSpacing(DXMath.MathProperties openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXMath.PostSpacing>()?.Val, value, diffs, objName, "PostSpacing");
  }
  
  private static void SetPostSpacing(DXMath.MathProperties openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXMath.PostSpacing,System.UInt32>(openXmlElement, value);
  }
  
  /// <summary>
  /// Inter-Equation Spacing.
  /// </summary>
  private static UInt32? GetInterSpacing(DXMath.MathProperties openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXMath.InterSpacing>()?.Val);
  }
  
  private static bool CmpInterSpacing(DXMath.MathProperties openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXMath.InterSpacing>()?.Val, value, diffs, objName, "InterSpacing");
  }
  
  private static void SetInterSpacing(DXMath.MathProperties openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXMath.InterSpacing,System.UInt32>(openXmlElement, value);
  }
  
  /// <summary>
  /// Intra-Equation Spacing.
  /// </summary>
  private static UInt32? GetIntraSpacing(DXMath.MathProperties openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXMath.IntraSpacing>()?.Val);
  }
  
  private static bool CmpIntraSpacing(DXMath.MathProperties openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXMath.IntraSpacing>()?.Val, value, diffs, objName, "IntraSpacing");
  }
  
  private static void SetIntraSpacing(DXMath.MathProperties openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXMath.IntraSpacing,System.UInt32>(openXmlElement, value);
  }
  
  private static UInt32? GetWrapIndent(DXMath.MathProperties openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXMath.WrapIndent>()?.Val);
  }
  
  private static bool CmpWrapIndent(DXMath.MathProperties openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXMath.WrapIndent>()?.Val, value, diffs, objName, "WrapIndent");
  }
  
  private static void SetWrapIndent(DXMath.MathProperties openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXMath.WrapIndent,System.UInt32>(openXmlElement, value);
  }
  
  private static DMMath.BooleanKind? GetWrapRight(DXMath.MathProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.WrapRight>()?.Val?.Value);
  }
  
  private static bool CmpWrapRight(DXMath.MathProperties openXmlElement, DMMath.BooleanKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.WrapRight>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetWrapRight(DXMath.MathProperties openXmlElement, DMMath.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.WrapRight>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(itemElement, (DMMath.BooleanKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXMath.WrapRight, DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>((DMMath.BooleanKind)value));
  }
  
  private static DMMath.LimitLocationKind? GetIntegralLimitLocation(DXMath.MathProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.LimitLocationValues, DMMath.LimitLocationKind>(openXmlElement.GetFirstChild<DXMath.IntegralLimitLocation>()?.Val?.Value);
  }
  
  private static bool CmpIntegralLimitLocation(DXMath.MathProperties openXmlElement, DMMath.LimitLocationKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.LimitLocationValues, DMMath.LimitLocationKind>(openXmlElement.GetFirstChild<DXMath.IntegralLimitLocation>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetIntegralLimitLocation(DXMath.MathProperties openXmlElement, DMMath.LimitLocationKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.IntegralLimitLocation>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Math.LimitLocationValues, DMMath.LimitLocationKind>(itemElement, (DMMath.LimitLocationKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXMath.IntegralLimitLocation, DocumentFormat.OpenXml.Math.LimitLocationValues, DMMath.LimitLocationKind>((DMMath.LimitLocationKind)value));
  }
  
  private static DMMath.LimitLocationKind? GetNaryLimitLocation(DXMath.MathProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.LimitLocationValues, DMMath.LimitLocationKind>(openXmlElement.GetFirstChild<DXMath.NaryLimitLocation>()?.Val?.Value);
  }
  
  private static bool CmpNaryLimitLocation(DXMath.MathProperties openXmlElement, DMMath.LimitLocationKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.LimitLocationValues, DMMath.LimitLocationKind>(openXmlElement.GetFirstChild<DXMath.NaryLimitLocation>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetNaryLimitLocation(DXMath.MathProperties openXmlElement, DMMath.LimitLocationKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.NaryLimitLocation>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Math.LimitLocationValues, DMMath.LimitLocationKind>(itemElement, (DMMath.LimitLocationKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXMath.NaryLimitLocation, DocumentFormat.OpenXml.Math.LimitLocationValues, DMMath.LimitLocationKind>((DMMath.LimitLocationKind)value));
  }
  
  public static DMMath.MathProperties? CreateModelElement(DXMath.MathProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMMath.MathProperties();
      value.MathFont = GetMathFont(openXmlElement);
      value.BreakBinary = GetBreakBinary(openXmlElement);
      value.BreakBinarySubtraction = GetBreakBinarySubtraction(openXmlElement);
      value.SmallFraction = GetSmallFraction(openXmlElement);
      value.DisplayDefaults = GetDisplayDefaults(openXmlElement);
      value.LeftMargin = GetLeftMargin(openXmlElement);
      value.RightMargin = GetRightMargin(openXmlElement);
      value.DefaultJustification = GetDefaultJustification(openXmlElement);
      value.PreSpacing = GetPreSpacing(openXmlElement);
      value.PostSpacing = GetPostSpacing(openXmlElement);
      value.InterSpacing = GetInterSpacing(openXmlElement);
      value.IntraSpacing = GetIntraSpacing(openXmlElement);
      value.WrapIndent = GetWrapIndent(openXmlElement);
      value.WrapRight = GetWrapRight(openXmlElement);
      value.IntegralLimitLocation = GetIntegralLimitLocation(openXmlElement);
      value.NaryLimitLocation = GetNaryLimitLocation(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXMath.MathProperties? openXmlElement, DMMath.MathProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpMathFont(openXmlElement, value.MathFont, diffs, objName))
        ok = false;
      if (!CmpBreakBinary(openXmlElement, value.BreakBinary, diffs, objName))
        ok = false;
      if (!CmpBreakBinarySubtraction(openXmlElement, value.BreakBinarySubtraction, diffs, objName))
        ok = false;
      if (!CmpSmallFraction(openXmlElement, value.SmallFraction, diffs, objName))
        ok = false;
      if (!CmpDisplayDefaults(openXmlElement, value.DisplayDefaults, diffs, objName))
        ok = false;
      if (!CmpLeftMargin(openXmlElement, value.LeftMargin, diffs, objName))
        ok = false;
      if (!CmpRightMargin(openXmlElement, value.RightMargin, diffs, objName))
        ok = false;
      if (!CmpDefaultJustification(openXmlElement, value.DefaultJustification, diffs, objName))
        ok = false;
      if (!CmpPreSpacing(openXmlElement, value.PreSpacing, diffs, objName))
        ok = false;
      if (!CmpPostSpacing(openXmlElement, value.PostSpacing, diffs, objName))
        ok = false;
      if (!CmpInterSpacing(openXmlElement, value.InterSpacing, diffs, objName))
        ok = false;
      if (!CmpIntraSpacing(openXmlElement, value.IntraSpacing, diffs, objName))
        ok = false;
      if (!CmpWrapIndent(openXmlElement, value.WrapIndent, diffs, objName))
        ok = false;
      if (!CmpWrapRight(openXmlElement, value.WrapRight, diffs, objName))
        ok = false;
      if (!CmpIntegralLimitLocation(openXmlElement, value.IntegralLimitLocation, diffs, objName))
        ok = false;
      if (!CmpNaryLimitLocation(openXmlElement, value.NaryLimitLocation, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMMath.MathProperties value)
    where OpenXmlElementType: DXMath.MathProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXMath.MathProperties openXmlElement, DMMath.MathProperties value)
  {
    SetMathFont(openXmlElement, value?.MathFont);
    SetBreakBinary(openXmlElement, value?.BreakBinary);
    SetBreakBinarySubtraction(openXmlElement, value?.BreakBinarySubtraction);
    SetSmallFraction(openXmlElement, value?.SmallFraction);
    SetDisplayDefaults(openXmlElement, value?.DisplayDefaults);
    SetLeftMargin(openXmlElement, value?.LeftMargin);
    SetRightMargin(openXmlElement, value?.RightMargin);
    SetDefaultJustification(openXmlElement, value?.DefaultJustification);
    SetPreSpacing(openXmlElement, value?.PreSpacing);
    SetPostSpacing(openXmlElement, value?.PostSpacing);
    SetInterSpacing(openXmlElement, value?.InterSpacing);
    SetIntraSpacing(openXmlElement, value?.IntraSpacing);
    SetWrapIndent(openXmlElement, value?.WrapIndent);
    SetWrapRight(openXmlElement, value?.WrapRight);
    SetIntegralLimitLocation(openXmlElement, value?.IntegralLimitLocation);
    SetNaryLimitLocation(openXmlElement, value?.NaryLimitLocation);
  }
}
