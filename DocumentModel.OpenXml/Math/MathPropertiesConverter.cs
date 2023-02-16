namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Math Properties.
/// </summary>
public static class MathPropertiesConverter
{
  /// <summary>
  /// Math Font.
  /// </summary>
  private static String? GetMathFont(DXMath.MathProperties openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXMath.MathFont>()?.Val?.Value;
  }
  
  private static bool CmpMathFont(DXMath.MathProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXMath.MathFont>()?.Val?.Value == value;
  }
  
  private static void SetMathFont(DXMath.MathProperties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.MathFont>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXMath.MathFont { Val = value };
      openXmlElement.AddChild(itemElement);
    }
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
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.BreakBinaryOperatorValues, DMMath.BreakBinaryOperatorKind>(openXmlElement.GetFirstChild<DXMath.BreakBinary>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBreakBinary(DXMath.MathProperties openXmlElement, DMMath.BreakBinaryOperatorKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.BreakBinary>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXMath.BreakBinary, DocumentFormat.OpenXml.Math.BreakBinaryOperatorValues, DMMath.BreakBinaryOperatorKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
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
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.BreakBinarySubtractionValues, DMMath.BreakBinarySubtractionKind>(openXmlElement.GetFirstChild<DXMath.BreakBinarySubtraction>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBreakBinarySubtraction(DXMath.MathProperties openXmlElement, DMMath.BreakBinarySubtractionKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.BreakBinarySubtraction>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXMath.BreakBinarySubtraction, DocumentFormat.OpenXml.Math.BreakBinarySubtractionValues, DMMath.BreakBinarySubtractionKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
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
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.SmallFraction>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSmallFraction(DXMath.MathProperties openXmlElement, DMMath.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.SmallFraction>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXMath.SmallFraction, DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
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
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.DisplayDefaults>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDisplayDefaults(DXMath.MathProperties openXmlElement, DMMath.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.DisplayDefaults>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXMath.DisplayDefaults, DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Left Margin.
  /// </summary>
  private static UInt32? GetLeftMargin(DXMath.MathProperties openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXMath.LeftMargin>()?.Val?.Value;
  }
  
  private static bool CmpLeftMargin(DXMath.MathProperties openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXMath.LeftMargin>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXMath.LeftMargin", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetLeftMargin(DXMath.MathProperties openXmlElement, UInt32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.LeftMargin>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXMath.LeftMargin{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Right Margin.
  /// </summary>
  private static UInt32? GetRightMargin(DXMath.MathProperties openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXMath.RightMargin>()?.Val?.Value;
  }
  
  private static bool CmpRightMargin(DXMath.MathProperties openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXMath.RightMargin>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXMath.RightMargin", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetRightMargin(DXMath.MathProperties openXmlElement, UInt32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.RightMargin>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXMath.RightMargin{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
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
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.JustificationValues, DMMath.JustificationKind>(openXmlElement.GetFirstChild<DXMath.DefaultJustification>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDefaultJustification(DXMath.MathProperties openXmlElement, DMMath.JustificationKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.DefaultJustification>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXMath.DefaultJustification, DocumentFormat.OpenXml.Math.JustificationValues, DMMath.JustificationKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Pre-Equation Spacing.
  /// </summary>
  private static UInt32? GetPreSpacing(DXMath.MathProperties openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXMath.PreSpacing>()?.Val?.Value;
  }
  
  private static bool CmpPreSpacing(DXMath.MathProperties openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXMath.PreSpacing>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXMath.PreSpacing", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetPreSpacing(DXMath.MathProperties openXmlElement, UInt32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.PreSpacing>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXMath.PreSpacing{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Post-Equation Spacing.
  /// </summary>
  private static UInt32? GetPostSpacing(DXMath.MathProperties openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXMath.PostSpacing>()?.Val?.Value;
  }
  
  private static bool CmpPostSpacing(DXMath.MathProperties openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXMath.PostSpacing>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXMath.PostSpacing", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetPostSpacing(DXMath.MathProperties openXmlElement, UInt32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.PostSpacing>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXMath.PostSpacing{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Inter-Equation Spacing.
  /// </summary>
  private static UInt32? GetInterSpacing(DXMath.MathProperties openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXMath.InterSpacing>()?.Val?.Value;
  }
  
  private static bool CmpInterSpacing(DXMath.MathProperties openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXMath.InterSpacing>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXMath.InterSpacing", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetInterSpacing(DXMath.MathProperties openXmlElement, UInt32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.InterSpacing>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXMath.InterSpacing{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Intra-Equation Spacing.
  /// </summary>
  private static UInt32? GetIntraSpacing(DXMath.MathProperties openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXMath.IntraSpacing>()?.Val?.Value;
  }
  
  private static bool CmpIntraSpacing(DXMath.MathProperties openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXMath.IntraSpacing>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXMath.IntraSpacing", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetIntraSpacing(DXMath.MathProperties openXmlElement, UInt32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.IntraSpacing>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXMath.IntraSpacing{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static UInt32? GetWrapIndent(DXMath.MathProperties openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXMath.WrapIndent>()?.Val?.Value;
  }
  
  private static bool CmpWrapIndent(DXMath.MathProperties openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXMath.WrapIndent>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXMath.WrapIndent", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetWrapIndent(DXMath.MathProperties openXmlElement, UInt32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.WrapIndent>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXMath.WrapIndent{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.BooleanKind? GetWrapRight(DXMath.MathProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.WrapRight>()?.Val?.Value);
  }
  
  private static bool CmpWrapRight(DXMath.MathProperties openXmlElement, DMMath.BooleanKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.WrapRight>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetWrapRight(DXMath.MathProperties openXmlElement, DMMath.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.WrapRight>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXMath.WrapRight, DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.LimitLocationKind? GetIntegralLimitLocation(DXMath.MathProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.LimitLocationValues, DMMath.LimitLocationKind>(openXmlElement.GetFirstChild<DXMath.IntegralLimitLocation>()?.Val?.Value);
  }
  
  private static bool CmpIntegralLimitLocation(DXMath.MathProperties openXmlElement, DMMath.LimitLocationKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.LimitLocationValues, DMMath.LimitLocationKind>(openXmlElement.GetFirstChild<DXMath.IntegralLimitLocation>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetIntegralLimitLocation(DXMath.MathProperties openXmlElement, DMMath.LimitLocationKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.IntegralLimitLocation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXMath.IntegralLimitLocation, DocumentFormat.OpenXml.Math.LimitLocationValues, DMMath.LimitLocationKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.LimitLocationKind? GetNaryLimitLocation(DXMath.MathProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.LimitLocationValues, DMMath.LimitLocationKind>(openXmlElement.GetFirstChild<DXMath.NaryLimitLocation>()?.Val?.Value);
  }
  
  private static bool CmpNaryLimitLocation(DXMath.MathProperties openXmlElement, DMMath.LimitLocationKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.LimitLocationValues, DMMath.LimitLocationKind>(openXmlElement.GetFirstChild<DXMath.NaryLimitLocation>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNaryLimitLocation(DXMath.MathProperties openXmlElement, DMMath.LimitLocationKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.NaryLimitLocation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXMath.NaryLimitLocation, DocumentFormat.OpenXml.Math.LimitLocationValues, DMMath.LimitLocationKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Math.MathProperties? CreateModelElement(DXMath.MathProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.MathProperties();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMMath.MathProperties? value)
    where OpenXmlElementType: DXMath.MathProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
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
      return openXmlElement;
    }
    return default;
  }
}
