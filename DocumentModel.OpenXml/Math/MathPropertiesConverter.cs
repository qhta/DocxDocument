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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.MathFont>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXMath.BreakBinary>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BreakBinaryOperatorValues, DMMath.BreakBinaryOperatorKind>(itemElement.Val.Value);
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXMath.BreakBinarySubtraction>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BreakBinarySubtractionValues, DMMath.BreakBinarySubtractionKind>(itemElement.Val.Value);
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXMath.SmallFraction>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(itemElement.Val.Value);
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXMath.DisplayDefaults>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(itemElement.Val.Value);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.LeftMargin>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.RightMargin>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXMath.DefaultJustification>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.JustificationValues, DMMath.JustificationKind>(itemElement.Val.Value);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.PreSpacing>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.PostSpacing>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.InterSpacing>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.IntraSpacing>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.WrapIndent>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXMath.WrapRight>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(itemElement.Val.Value);
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXMath.IntegralLimitLocation>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.LimitLocationValues, DMMath.LimitLocationKind>(itemElement.Val.Value);
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXMath.NaryLimitLocation>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.LimitLocationValues, DMMath.LimitLocationKind>(itemElement.Val.Value);
    return null;
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
