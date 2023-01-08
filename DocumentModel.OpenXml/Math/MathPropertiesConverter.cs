namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Math Properties.
/// </summary>
public static class MathPropertiesConverter
{
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
  
}
