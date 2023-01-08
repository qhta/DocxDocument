namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the TextOutlineEffect Class.
/// </summary>
public static class TextOutlineEffectConverter
{
  /// <summary>
  /// w, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetLineWidth(DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLineWidth(DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// cap, this property is only available in Office 2010 and later.
  /// </summary>
  public static DocumentModel.Wordprocessing.LineCapKind? GetCapType(DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.LineCapValues, DocumentModel.Wordprocessing.LineCapKind>(openXmlElement?.CapType?.Value);
  }
  
  public static void SetCapType(DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect? openXmlElement, DocumentModel.Wordprocessing.LineCapKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.CapType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.LineCapValues, DocumentModel.Wordprocessing.LineCapKind>(value);
  }
  
  /// <summary>
  /// cmpd, this property is only available in Office 2010 and later.
  /// </summary>
  public static DocumentModel.Wordprocessing.CompoundLineKind? GetCompound(DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.CompoundLineValues, DocumentModel.Wordprocessing.CompoundLineKind>(openXmlElement?.Compound?.Value);
  }
  
  public static void SetCompound(DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect? openXmlElement, DocumentModel.Wordprocessing.CompoundLineKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Compound = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.CompoundLineValues, DocumentModel.Wordprocessing.CompoundLineKind>(value);
  }
  
  /// <summary>
  /// algn, this property is only available in Office 2010 and later.
  /// </summary>
  public static DocumentModel.Wordprocessing.PenAlignmentKind? GetAlignment(DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.PenAlignmentValues, DocumentModel.Wordprocessing.PenAlignmentKind>(openXmlElement?.Alignment?.Value);
  }
  
  public static void SetAlignment(DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect? openXmlElement, DocumentModel.Wordprocessing.PenAlignmentKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Alignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.PenAlignmentValues, DocumentModel.Wordprocessing.PenAlignmentKind>(value);
  }
  
  public static Boolean? GetNoFillEmpty(DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetNoFillEmpty(DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.SolidColorFillProperties? GetSolidColorFillProperties(DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSolidColorFillProperties(DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect? openXmlElement, DocumentModel.Wordprocessing.SolidColorFillProperties? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.GradientFillProperties? GetGradientFillProperties(DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetGradientFillProperties(DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect? openXmlElement, DocumentModel.Wordprocessing.GradientFillProperties? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.PresetLineDashKind? GetPresetLineDashProperties(DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.PresetLineDashProperties>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.PresetLineDashValues, DocumentModel.Wordprocessing.PresetLineDashKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetPresetLineDashProperties(DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect? openXmlElement, DocumentModel.Wordprocessing.PresetLineDashKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.PresetLineDashProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.PresetLineDashProperties, DocumentFormat.OpenXml.Office2010.Word.PresetLineDashValues, DocumentModel.Wordprocessing.PresetLineDashKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetRoundEmpty(DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRoundEmpty(DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetBevelEmpty(DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBevelEmpty(DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.LineJoinMiterProperties? GetLineJoinMiterProperties(DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLineJoinMiterProperties(DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect? openXmlElement, DocumentModel.Wordprocessing.LineJoinMiterProperties? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
