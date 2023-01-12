namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Math Properties.
/// </summary>
public static class MathPropertiesConverter
{
  /// <summary>
  /// Math Font.
  /// </summary>
  public static String? GetMathFont(DocumentFormat.OpenXml.Math.MathProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Math.MathFont");
  }
  
  public static void SetMathFont(DocumentFormat.OpenXml.Math.MathProperties? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Math.MathFont");
  }
  
  /// <summary>
  /// Break on Binary Operators.
  /// </summary>
  public static DocumentModel.Math.BreakBinaryOperatorKind? GetBreakBinary(DocumentFormat.OpenXml.Math.MathProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.BreakBinary>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BreakBinaryOperatorValues, DocumentModel.Math.BreakBinaryOperatorKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetBreakBinary(DocumentFormat.OpenXml.Math.MathProperties? openXmlElement, DocumentModel.Math.BreakBinaryOperatorKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.BreakBinary>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.BreakBinary, DocumentFormat.OpenXml.Math.BreakBinaryOperatorValues, DocumentModel.Math.BreakBinaryOperatorKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Break on Binary Subtraction.
  /// </summary>
  public static DocumentModel.Math.BreakBinarySubtractionKind? GetBreakBinarySubtraction(DocumentFormat.OpenXml.Math.MathProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.BreakBinarySubtraction>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BreakBinarySubtractionValues, DocumentModel.Math.BreakBinarySubtractionKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetBreakBinarySubtraction(DocumentFormat.OpenXml.Math.MathProperties? openXmlElement, DocumentModel.Math.BreakBinarySubtractionKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.BreakBinarySubtraction>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.BreakBinarySubtraction, DocumentFormat.OpenXml.Math.BreakBinarySubtractionValues, DocumentModel.Math.BreakBinarySubtractionKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Small Fraction.
  /// </summary>
  public static DocumentModel.Math.BooleanKind? GetSmallFraction(DocumentFormat.OpenXml.Math.MathProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.SmallFraction>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetSmallFraction(DocumentFormat.OpenXml.Math.MathProperties? openXmlElement, DocumentModel.Math.BooleanKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.SmallFraction>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.SmallFraction, DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Use Display Math Defaults.
  /// </summary>
  public static DocumentModel.Math.BooleanKind? GetDisplayDefaults(DocumentFormat.OpenXml.Math.MathProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.DisplayDefaults>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetDisplayDefaults(DocumentFormat.OpenXml.Math.MathProperties? openXmlElement, DocumentModel.Math.BooleanKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.DisplayDefaults>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.DisplayDefaults, DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Left Margin.
  /// </summary>
  public static UInt32? GetLeftMargin(DocumentFormat.OpenXml.Math.MathProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.LeftMargin>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetLeftMargin(DocumentFormat.OpenXml.Math.MathProperties? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.LeftMargin>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Math.LeftMargin{ Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Right Margin.
  /// </summary>
  public static UInt32? GetRightMargin(DocumentFormat.OpenXml.Math.MathProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.RightMargin>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetRightMargin(DocumentFormat.OpenXml.Math.MathProperties? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.RightMargin>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Math.RightMargin{ Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Default Justification.
  /// </summary>
  public static DocumentModel.Math.JustificationKind? GetDefaultJustification(DocumentFormat.OpenXml.Math.MathProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.DefaultJustification>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.JustificationValues, DocumentModel.Math.JustificationKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetDefaultJustification(DocumentFormat.OpenXml.Math.MathProperties? openXmlElement, DocumentModel.Math.JustificationKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.DefaultJustification>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.DefaultJustification, DocumentFormat.OpenXml.Math.JustificationValues, DocumentModel.Math.JustificationKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Pre-Equation Spacing.
  /// </summary>
  public static UInt32? GetPreSpacing(DocumentFormat.OpenXml.Math.MathProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.PreSpacing>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetPreSpacing(DocumentFormat.OpenXml.Math.MathProperties? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.PreSpacing>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Math.PreSpacing{ Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Post-Equation Spacing.
  /// </summary>
  public static UInt32? GetPostSpacing(DocumentFormat.OpenXml.Math.MathProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.PostSpacing>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetPostSpacing(DocumentFormat.OpenXml.Math.MathProperties? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.PostSpacing>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Math.PostSpacing{ Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Inter-Equation Spacing.
  /// </summary>
  public static UInt32? GetInterSpacing(DocumentFormat.OpenXml.Math.MathProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.InterSpacing>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetInterSpacing(DocumentFormat.OpenXml.Math.MathProperties? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.InterSpacing>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Math.InterSpacing{ Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Intra-Equation Spacing.
  /// </summary>
  public static UInt32? GetIntraSpacing(DocumentFormat.OpenXml.Math.MathProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.IntraSpacing>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetIntraSpacing(DocumentFormat.OpenXml.Math.MathProperties? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.IntraSpacing>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Math.IntraSpacing{ Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static UInt32? GetWrapIndent(DocumentFormat.OpenXml.Math.MathProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.WrapIndent>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetWrapIndent(DocumentFormat.OpenXml.Math.MathProperties? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.WrapIndent>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Math.WrapIndent{ Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Math.BooleanKind? GetWrapRight(DocumentFormat.OpenXml.Math.MathProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.WrapRight>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetWrapRight(DocumentFormat.OpenXml.Math.MathProperties? openXmlElement, DocumentModel.Math.BooleanKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.WrapRight>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.WrapRight, DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Math.LimitLocationKind? GetIntegralLimitLocation(DocumentFormat.OpenXml.Math.MathProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.IntegralLimitLocation>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.LimitLocationValues, DocumentModel.Math.LimitLocationKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetIntegralLimitLocation(DocumentFormat.OpenXml.Math.MathProperties? openXmlElement, DocumentModel.Math.LimitLocationKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.IntegralLimitLocation>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.IntegralLimitLocation, DocumentFormat.OpenXml.Math.LimitLocationValues, DocumentModel.Math.LimitLocationKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Math.LimitLocationKind? GetNaryLimitLocation(DocumentFormat.OpenXml.Math.MathProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.NaryLimitLocation>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.LimitLocationValues, DocumentModel.Math.LimitLocationKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetNaryLimitLocation(DocumentFormat.OpenXml.Math.MathProperties? openXmlElement, DocumentModel.Math.LimitLocationKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.NaryLimitLocation>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.NaryLimitLocation, DocumentFormat.OpenXml.Math.LimitLocationValues, DocumentModel.Math.LimitLocationKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Math.MathProperties? CreateModelElement(DocumentFormat.OpenXml.Math.MathProperties? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Math.MathProperties, new()
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
      return openXmlElement;
    }
    return default;
  }
}
