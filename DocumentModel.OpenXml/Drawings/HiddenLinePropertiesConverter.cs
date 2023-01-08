namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the HiddenLineProperties Class.
/// </summary>
public static class HiddenLinePropertiesConverter
{
  /// <summary>
  /// line width
  /// </summary>
  public static Int32? GetWidth(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetWidth(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// line cap
  /// </summary>
  public static DocumentModel.Drawings.LineCapKind? GetCapType(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.LineCapValues, DocumentModel.Drawings.LineCapKind>(openXmlElement?.CapType?.Value);
  }
  
  public static void SetCapType(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties? openXmlElement, DocumentModel.Drawings.LineCapKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.CapType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.LineCapValues, DocumentModel.Drawings.LineCapKind>(value);
  }
  
  /// <summary>
  /// compound line type
  /// </summary>
  public static DocumentModel.Drawings.CompoundLineKind? GetCompoundLineType(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.CompoundLineValues, DocumentModel.Drawings.CompoundLineKind>(openXmlElement?.CompoundLineType?.Value);
  }
  
  public static void SetCompoundLineType(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties? openXmlElement, DocumentModel.Drawings.CompoundLineKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.CompoundLineType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.CompoundLineValues, DocumentModel.Drawings.CompoundLineKind>(value);
  }
  
  /// <summary>
  /// pen alignment
  /// </summary>
  public static DocumentModel.Drawings.PenAlignmentKind? GetAlignment(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.PenAlignmentValues, DocumentModel.Drawings.PenAlignmentKind>(openXmlElement?.Alignment?.Value);
  }
  
  public static void SetAlignment(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties? openXmlElement, DocumentModel.Drawings.PenAlignmentKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Alignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.PenAlignmentValues, DocumentModel.Drawings.PenAlignmentKind>(value);
  }
  
  public static Boolean? GetNoFill(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetNoFill(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.SolidFill? GetSolidFill(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSolidFill(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties? openXmlElement, DocumentModel.Drawings.SolidFill? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.GradientFill? GetGradientFill(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetGradientFill(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties? openXmlElement, DocumentModel.Drawings.GradientFill? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.PatternFill? GetPatternFill(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetPatternFill(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties? openXmlElement, DocumentModel.Drawings.PatternFill? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.PresetLineDashKind? GetPresetDash(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PresetDash>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.PresetLineDashValues, DocumentModel.Drawings.PresetLineDashKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetPresetDash(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties? openXmlElement, DocumentModel.Drawings.PresetLineDashKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PresetDash>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.PresetDash, DocumentFormat.OpenXml.Drawing.PresetLineDashValues, DocumentModel.Drawings.PresetLineDashKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.CustomDash? GetCustomDash(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetCustomDash(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties? openXmlElement, DocumentModel.Drawings.CustomDash? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetRound(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRound(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetLineJoinBevel(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLineJoinBevel(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Miter? GetMiter(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetMiter(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties? openXmlElement, DocumentModel.Drawings.Miter? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.LineEndPropertiesType? GetHeadEnd(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetHeadEnd(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties? openXmlElement, DocumentModel.Drawings.LineEndPropertiesType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.LineEndPropertiesType? GetTailEnd(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTailEnd(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties? openXmlElement, DocumentModel.Drawings.LineEndPropertiesType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.LinePropertiesExtensionList? GetLinePropertiesExtensionList(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLinePropertiesExtensionList(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties? openXmlElement, DocumentModel.Drawings.LinePropertiesExtensionList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
