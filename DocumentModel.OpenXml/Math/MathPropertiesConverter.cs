using DocumentFormat.OpenXml.Math;
using DocumentModel.Math;
using MathProperties = DocumentFormat.OpenXml.Math.MathProperties;

namespace DocumentModel.OpenXml.Math;

/// <summary>
///   Math Properties.
/// </summary>
public static class MathPropertiesConverter
{
  /// <summary>
  ///   Math Font.
  /// </summary>
  public static String? GetMathFont(MathProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<MathFont>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetMathFont(MathProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MathFont>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new MathFont { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Break on Binary Operators.
  /// </summary>
  public static BreakBinaryOperatorKind? GetBreakBinary(MathProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BreakBinary>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<BreakBinaryOperatorValues, BreakBinaryOperatorKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetBreakBinary(MathProperties? openXmlElement, BreakBinaryOperatorKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BreakBinary>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<BreakBinary, BreakBinaryOperatorValues, BreakBinaryOperatorKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Break on Binary Subtraction.
  /// </summary>
  public static BreakBinarySubtractionKind? GetBreakBinarySubtraction(MathProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BreakBinarySubtraction>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<BreakBinarySubtractionValues, BreakBinarySubtractionKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetBreakBinarySubtraction(MathProperties? openXmlElement, BreakBinarySubtractionKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BreakBinarySubtraction>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<BreakBinarySubtraction, BreakBinarySubtractionValues, BreakBinarySubtractionKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Small Fraction.
  /// </summary>
  public static BooleanKind? GetSmallFraction(MathProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SmallFraction>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<BooleanValues, BooleanKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetSmallFraction(MathProperties? openXmlElement, BooleanKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SmallFraction>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<SmallFraction, BooleanValues, BooleanKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Use Display Math Defaults.
  /// </summary>
  public static BooleanKind? GetDisplayDefaults(MathProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DisplayDefaults>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<BooleanValues, BooleanKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetDisplayDefaults(MathProperties? openXmlElement, BooleanKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DisplayDefaults>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DisplayDefaults, BooleanValues, BooleanKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Left Margin.
  /// </summary>
  public static UInt32? GetLeftMargin(MathProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<LeftMargin>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetLeftMargin(MathProperties? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LeftMargin>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new LeftMargin { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Right Margin.
  /// </summary>
  public static UInt32? GetRightMargin(MathProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<RightMargin>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetRightMargin(MathProperties? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<RightMargin>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new RightMargin { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Default Justification.
  /// </summary>
  public static JustificationKind? GetDefaultJustification(MathProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DefaultJustification>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<JustificationValues, JustificationKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetDefaultJustification(MathProperties? openXmlElement, JustificationKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DefaultJustification>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DefaultJustification, JustificationValues, JustificationKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Pre-Equation Spacing.
  /// </summary>
  public static UInt32? GetPreSpacing(MathProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<PreSpacing>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetPreSpacing(MathProperties? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<PreSpacing>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new PreSpacing { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Post-Equation Spacing.
  /// </summary>
  public static UInt32? GetPostSpacing(MathProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<PostSpacing>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetPostSpacing(MathProperties? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<PostSpacing>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new PostSpacing { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Inter-Equation Spacing.
  /// </summary>
  public static UInt32? GetInterSpacing(MathProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<InterSpacing>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetInterSpacing(MathProperties? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<InterSpacing>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new InterSpacing { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Intra-Equation Spacing.
  /// </summary>
  public static UInt32? GetIntraSpacing(MathProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<IntraSpacing>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetIntraSpacing(MathProperties? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<IntraSpacing>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new IntraSpacing { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static UInt32? GetWrapIndent(MathProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<WrapIndent>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetWrapIndent(MathProperties? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<WrapIndent>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new WrapIndent { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static BooleanKind? GetWrapRight(MathProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<WrapRight>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<BooleanValues, BooleanKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetWrapRight(MathProperties? openXmlElement, BooleanKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<WrapRight>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<WrapRight, BooleanValues, BooleanKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static LimitLocationKind? GetIntegralLimitLocation(MathProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<IntegralLimitLocation>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<LimitLocationValues, LimitLocationKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetIntegralLimitLocation(MathProperties? openXmlElement, LimitLocationKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<IntegralLimitLocation>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<IntegralLimitLocation, LimitLocationValues, LimitLocationKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static LimitLocationKind? GetNaryLimitLocation(MathProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NaryLimitLocation>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<LimitLocationValues, LimitLocationKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetNaryLimitLocation(MathProperties? openXmlElement, LimitLocationKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NaryLimitLocation>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<NaryLimitLocation, LimitLocationValues, LimitLocationKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Math.MathProperties? CreateModelElement(MathProperties? openXmlElement)
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.MathProperties? value)
    where OpenXmlElementType : MathProperties, new()
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