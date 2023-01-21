namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Diagram to Animate.
/// </summary>
public static class DiagramConverter
{
  /// <summary>
  /// Identifier
  /// </summary>
  private static String? GetId(DXDraw.Diagram openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DXDraw.Diagram openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Animation Build Step
  /// </summary>
  private static DMDraws.DiagramBuildStepKind? GetBuildStep(DXDraw.Diagram openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.DiagramBuildStepValues, DMDraws.DiagramBuildStepKind>(openXmlElement?.BuildStep?.Value);
  }
  
  private static void SetBuildStep(DXDraw.Diagram openXmlElement, DMDraws.DiagramBuildStepKind? value)
  {
    openXmlElement.BuildStep = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.DiagramBuildStepValues, DMDraws.DiagramBuildStepKind>(value);
  }
  
  public static DMDraws.Diagram? CreateModelElement(DXDraw.Diagram? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.Diagram();
      value.Id = GetId(openXmlElement);
      value.BuildStep = GetBuildStep(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.Diagram? value)
    where OpenXmlElementType: DXDraw.Diagram, new()
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
