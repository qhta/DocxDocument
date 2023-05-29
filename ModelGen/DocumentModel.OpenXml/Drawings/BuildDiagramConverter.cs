namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Build Diagram.
/// </summary>
public static class BuildDiagramConverter
{
  /// <summary>
  /// Build
  /// </summary>
  private static String? GetBuild(DXDraw.BuildDiagram openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Build);
  }
  
  private static bool CmpBuild(DXDraw.BuildDiagram openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Build, value, diffs, objName, "Build");
  }
  
  private static void SetBuild(DXDraw.BuildDiagram openXmlElement, String? value)
  {
    openXmlElement.Build = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Reverse Animation
  /// </summary>
  private static Boolean? GetReverseAnimation(DXDraw.BuildDiagram openXmlElement)
  {
    return openXmlElement?.ReverseAnimation?.Value;
  }
  
  private static bool CmpReverseAnimation(DXDraw.BuildDiagram openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ReverseAnimation?.Value == value) return true;
    diffs?.Add(objName, "ReverseAnimation", openXmlElement?.ReverseAnimation?.Value, value);
    return false;
  }
  
  private static void SetReverseAnimation(DXDraw.BuildDiagram openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ReverseAnimation = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ReverseAnimation = null;
  }
  
  public static DocumentModel.Drawings.BuildDiagram? CreateModelElement(DXDraw.BuildDiagram? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.BuildDiagram();
      value.Build = GetBuild(openXmlElement);
      value.ReverseAnimation = GetReverseAnimation(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.BuildDiagram? openXmlElement, DMDraws.BuildDiagram? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBuild(openXmlElement, value.Build, diffs, objName))
        ok = false;
      if (!CmpReverseAnimation(openXmlElement, value.ReverseAnimation, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.BuildDiagram value)
    where OpenXmlElementType: DXDraw.BuildDiagram, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.BuildDiagram openXmlElement, DMDraws.BuildDiagram value)
  {
    SetBuild(openXmlElement, value?.Build);
    SetReverseAnimation(openXmlElement, value?.ReverseAnimation);
  }
}
