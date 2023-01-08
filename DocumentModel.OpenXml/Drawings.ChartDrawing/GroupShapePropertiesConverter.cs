namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Group Shape Properties.
/// </summary>
public static class GroupShapePropertiesConverter
{
  /// <summary>
  /// Black and White Mode
  /// </summary>
  public static DocumentModel.Drawings.BlackWhiteMode? GetBlackWhiteMode(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DocumentModel.Drawings.BlackWhiteMode>(openXmlElement?.BlackWhiteMode?.Value);
  }
  
  public static void SetBlackWhiteMode(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties? openXmlElement, DocumentModel.Drawings.BlackWhiteMode? value)
  {
    if (openXmlElement != null)
      openXmlElement.BlackWhiteMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DocumentModel.Drawings.BlackWhiteMode>(value);
  }
  
  /// <summary>
  /// 2D Transform for Grouped Objects.
  /// </summary>
  public static DocumentModel.Drawings.TransformGroup? GetTransformGroup(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTransformGroup(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties? openXmlElement, DocumentModel.Drawings.TransformGroup? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetNoFill(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetNoFill(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.SolidFill? GetSolidFill(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSolidFill(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties? openXmlElement, DocumentModel.Drawings.SolidFill? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.GradientFill? GetGradientFill(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetGradientFill(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties? openXmlElement, DocumentModel.Drawings.GradientFill? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.BlipFill? GetBlipFill(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBlipFill(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties? openXmlElement, DocumentModel.Drawings.BlipFill? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.PatternFill? GetPatternFill(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetPatternFill(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties? openXmlElement, DocumentModel.Drawings.PatternFill? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetGroupFill(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetGroupFill(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.EffectList? GetEffectList(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetEffectList(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties? openXmlElement, DocumentModel.Drawings.EffectList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.EffectDag? GetEffectDag(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetEffectDag(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties? openXmlElement, DocumentModel.Drawings.EffectDag? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Scene3DType? GetScene3DType(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetScene3DType(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties? openXmlElement, DocumentModel.Drawings.Scene3DType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties? openXmlElement, DocumentModel.Drawings.ExtensionList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
