namespace DocumentModel.OpenXml.Drawings.Office;

/// <summary>
/// Defines the GroupShapeProperties Class.
/// </summary>
public static class GroupShapePropertiesConverter
{
  /// <summary>
  /// Black and White Mode
  /// </summary>
  public static DocumentModel.Drawings.BlackWhiteMode? GetBlackWhiteMode(DocumentFormat.OpenXml.Office.Drawing.GroupShapeProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DocumentModel.Drawings.BlackWhiteMode>(openXmlElement?.BlackWhiteMode?.Value);
  }
  
  public static void SetBlackWhiteMode(DocumentFormat.OpenXml.Office.Drawing.GroupShapeProperties? openXmlElement, DocumentModel.Drawings.BlackWhiteMode? value)
  {
    if (openXmlElement != null)
      openXmlElement.BlackWhiteMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DocumentModel.Drawings.BlackWhiteMode>(value);
  }
  
  /// <summary>
  /// 2D Transform for Grouped Objects.
  /// </summary>
  public static DocumentModel.Drawings.TransformGroup? GetTransformGroup(DocumentFormat.OpenXml.Office.Drawing.GroupShapeProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTransformGroup(DocumentFormat.OpenXml.Office.Drawing.GroupShapeProperties? openXmlElement, DocumentModel.Drawings.TransformGroup? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetNoFill(DocumentFormat.OpenXml.Office.Drawing.GroupShapeProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetNoFill(DocumentFormat.OpenXml.Office.Drawing.GroupShapeProperties? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.SolidFill? GetSolidFill(DocumentFormat.OpenXml.Office.Drawing.GroupShapeProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSolidFill(DocumentFormat.OpenXml.Office.Drawing.GroupShapeProperties? openXmlElement, DocumentModel.Drawings.SolidFill? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.GradientFill? GetGradientFill(DocumentFormat.OpenXml.Office.Drawing.GroupShapeProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetGradientFill(DocumentFormat.OpenXml.Office.Drawing.GroupShapeProperties? openXmlElement, DocumentModel.Drawings.GradientFill? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.BlipFill? GetBlipFill(DocumentFormat.OpenXml.Office.Drawing.GroupShapeProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBlipFill(DocumentFormat.OpenXml.Office.Drawing.GroupShapeProperties? openXmlElement, DocumentModel.Drawings.BlipFill? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.PatternFill? GetPatternFill(DocumentFormat.OpenXml.Office.Drawing.GroupShapeProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetPatternFill(DocumentFormat.OpenXml.Office.Drawing.GroupShapeProperties? openXmlElement, DocumentModel.Drawings.PatternFill? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetGroupFill(DocumentFormat.OpenXml.Office.Drawing.GroupShapeProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetGroupFill(DocumentFormat.OpenXml.Office.Drawing.GroupShapeProperties? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.EffectList? GetEffectList(DocumentFormat.OpenXml.Office.Drawing.GroupShapeProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetEffectList(DocumentFormat.OpenXml.Office.Drawing.GroupShapeProperties? openXmlElement, DocumentModel.Drawings.EffectList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.EffectDag? GetEffectDag(DocumentFormat.OpenXml.Office.Drawing.GroupShapeProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetEffectDag(DocumentFormat.OpenXml.Office.Drawing.GroupShapeProperties? openXmlElement, DocumentModel.Drawings.EffectDag? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Scene3DType? GetScene3DType(DocumentFormat.OpenXml.Office.Drawing.GroupShapeProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetScene3DType(DocumentFormat.OpenXml.Office.Drawing.GroupShapeProperties? openXmlElement, DocumentModel.Drawings.Scene3DType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Office.Drawing.GroupShapeProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Office.Drawing.GroupShapeProperties? openXmlElement, DocumentModel.Drawings.ExtensionList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
