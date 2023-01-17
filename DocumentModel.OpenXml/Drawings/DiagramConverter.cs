namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Diagram to Animate.
/// </summary>
public static class DiagramConverter
{
  /// <summary>
  /// Identifier
  /// </summary>
  private static String? GetId(DocumentFormat.OpenXml.Drawing.Diagram openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DocumentFormat.OpenXml.Drawing.Diagram openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Animation Build Step
  /// </summary>
  private static DocumentModel.Drawings.DiagramBuildStepKind? GetBuildStep(DocumentFormat.OpenXml.Drawing.Diagram openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.DiagramBuildStepValues, DocumentModel.Drawings.DiagramBuildStepKind>(openXmlElement?.BuildStep?.Value);
  }
  
  private static void SetBuildStep(DocumentFormat.OpenXml.Drawing.Diagram openXmlElement, DocumentModel.Drawings.DiagramBuildStepKind? value)
  {
    openXmlElement.BuildStep = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.DiagramBuildStepValues, DocumentModel.Drawings.DiagramBuildStepKind>(value);
  }
  
  public static DocumentModel.Drawings.Diagram? CreateModelElement(DocumentFormat.OpenXml.Drawing.Diagram? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagram();
      value.Id = GetId(openXmlElement);
      value.BuildStep = GetBuildStep(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagram? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Diagram, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetBuildStep(openXmlElement, value?.BuildStep);
      return openXmlElement;
    }
    return default;
  }
}
