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
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXDraw.Diagram openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXDraw.Diagram openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Animation Build Step
  /// </summary>
  private static DMDraws.DiagramBuildStepKind? GetBuildStep(DXDraw.Diagram openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.DiagramBuildStepValues, DMDraws.DiagramBuildStepKind>(openXmlElement?.BuildStep?.Value);
  }
  
  private static bool CmpBuildStep(DXDraw.Diagram openXmlElement, DMDraws.DiagramBuildStepKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.DiagramBuildStepValues, DMDraws.DiagramBuildStepKind>(openXmlElement?.BuildStep?.Value, value, diffs, objName);
  }
  
  private static void SetBuildStep(DXDraw.Diagram openXmlElement, DMDraws.DiagramBuildStepKind? value)
  {
    openXmlElement.BuildStep = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.DiagramBuildStepValues, DMDraws.DiagramBuildStepKind>(value);
  }
  
  public static DocumentModel.Drawings.Diagram? CreateModelElement(DXDraw.Diagram? openXmlElement)
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
  
  public static bool CompareModelElement(DXDraw.Diagram? openXmlElement, DMDraws.Diagram? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpBuildStep(openXmlElement, value.BuildStep, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.Diagram value)
    where OpenXmlElementType: DXDraw.Diagram, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.Diagram openXmlElement, DMDraws.Diagram value)
  {
    SetId(openXmlElement, value?.Id);
    SetBuildStep(openXmlElement, value?.BuildStep);
  }
}
