namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Diagram to Animate.
/// </summary>
public static class DiagramConverter
{
  /// <summary>
  /// Identifier
  /// </summary>
  private static String? GetId(DXD.Diagram openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXD.Diagram openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXD.Diagram openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Animation Build Step
  /// </summary>
  private static DMD.DiagramBuildStepKind? GetBuildStep(DXD.Diagram openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.DiagramBuildStepValues, DMD.DiagramBuildStepKind>(openXmlElement?.BuildStep?.Value);
  }
  
  private static bool CmpBuildStep(DXD.Diagram openXmlElement, DMD.DiagramBuildStepKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.DiagramBuildStepValues, DMD.DiagramBuildStepKind>(openXmlElement?.BuildStep?.Value, value, diffs, objName, propName);
  }
  
  private static void SetBuildStep(DXD.Diagram openXmlElement, DMD.DiagramBuildStepKind? value)
  {
    openXmlElement.BuildStep = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.DiagramBuildStepValues, DMD.DiagramBuildStepKind>(value);
  }
  
  public static DMD.Diagram? CreateModelElement(DXD.Diagram? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Diagram();
      value.Id = GetId(openXmlElement);
      value.BuildStep = GetBuildStep(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.Diagram? openXmlElement, DMD.Diagram? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName, propName))
        ok = false;
      if (!CmpBuildStep(openXmlElement, value.BuildStep, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.Diagram value)
    where OpenXmlElementType: DXD.Diagram, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.Diagram openXmlElement, DMD.Diagram value)
  {
    SetId(openXmlElement, value?.Id);
    SetBuildStep(openXmlElement, value?.BuildStep);
  }
}
