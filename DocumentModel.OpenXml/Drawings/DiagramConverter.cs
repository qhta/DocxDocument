namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Diagram to Animate.
/// </summary>
public static class DiagramConverter
{
  /// <summary>
  /// Identifier
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Drawing.Diagram? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetId(DocumentFormat.OpenXml.Drawing.Diagram? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Animation Build Step
  /// </summary>
  public static DocumentModel.Drawings.DiagramBuildStepKind? GetBuildStep(DocumentFormat.OpenXml.Drawing.Diagram? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.DiagramBuildStepValues, DocumentModel.Drawings.DiagramBuildStepKind>(openXmlElement?.BuildStep?.Value);
  }
  
  public static void SetBuildStep(DocumentFormat.OpenXml.Drawing.Diagram? openXmlElement, DocumentModel.Drawings.DiagramBuildStepKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.BuildStep = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.DiagramBuildStepValues, DocumentModel.Drawings.DiagramBuildStepKind>(value);
  }
  
}
