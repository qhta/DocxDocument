namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Underline Stroke.
/// </summary>
public static class UnderlineConverter
{
  public static Boolean? GetNoFill(DocumentFormat.OpenXml.Drawing.Underline? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetNoFill(DocumentFormat.OpenXml.Drawing.Underline? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.SolidFill? GetSolidFill(DocumentFormat.OpenXml.Drawing.Underline? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSolidFill(DocumentFormat.OpenXml.Drawing.Underline? openXmlElement, DocumentModel.Drawings.SolidFill? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.GradientFill? GetGradientFill(DocumentFormat.OpenXml.Drawing.Underline? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetGradientFill(DocumentFormat.OpenXml.Drawing.Underline? openXmlElement, DocumentModel.Drawings.GradientFill? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.PatternFill? GetPatternFill(DocumentFormat.OpenXml.Drawing.Underline? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetPatternFill(DocumentFormat.OpenXml.Drawing.Underline? openXmlElement, DocumentModel.Drawings.PatternFill? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.PresetLineDashKind? GetPresetDash(DocumentFormat.OpenXml.Drawing.Underline? openXmlElement)
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
  
  public static void SetPresetDash(DocumentFormat.OpenXml.Drawing.Underline? openXmlElement, DocumentModel.Drawings.PresetLineDashKind? value)
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
  
  public static DocumentModel.Drawings.CustomDash? GetCustomDash(DocumentFormat.OpenXml.Drawing.Underline? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetCustomDash(DocumentFormat.OpenXml.Drawing.Underline? openXmlElement, DocumentModel.Drawings.CustomDash? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetRound(DocumentFormat.OpenXml.Drawing.Underline? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRound(DocumentFormat.OpenXml.Drawing.Underline? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetLineJoinBevel(DocumentFormat.OpenXml.Drawing.Underline? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLineJoinBevel(DocumentFormat.OpenXml.Drawing.Underline? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Miter? GetMiter(DocumentFormat.OpenXml.Drawing.Underline? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetMiter(DocumentFormat.OpenXml.Drawing.Underline? openXmlElement, DocumentModel.Drawings.Miter? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.LineEndPropertiesType? GetHeadEnd(DocumentFormat.OpenXml.Drawing.Underline? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetHeadEnd(DocumentFormat.OpenXml.Drawing.Underline? openXmlElement, DocumentModel.Drawings.LineEndPropertiesType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.LineEndPropertiesType? GetTailEnd(DocumentFormat.OpenXml.Drawing.Underline? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTailEnd(DocumentFormat.OpenXml.Drawing.Underline? openXmlElement, DocumentModel.Drawings.LineEndPropertiesType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.LinePropertiesExtensionList? GetLinePropertiesExtensionList(DocumentFormat.OpenXml.Drawing.Underline? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLinePropertiesExtensionList(DocumentFormat.OpenXml.Drawing.Underline? openXmlElement, DocumentModel.Drawings.LinePropertiesExtensionList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
