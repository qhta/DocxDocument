namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Build Diagram.
/// </summary>
public static class BuildDiagramConverter
{
  /// <summary>
  /// Build
  /// </summary>
  private static String? GetBuild(DXD.BuildDiagram openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Build);
  }
  
  private static bool CmpBuild(DXD.BuildDiagram openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Build, value, diffs, objName, "Build");
  }
  
  private static void SetBuild(DXD.BuildDiagram openXmlElement, String? value)
  {
    openXmlElement.Build = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Reverse Animation
  /// </summary>
  private static Boolean? GetReverseAnimation(DXD.BuildDiagram openXmlElement)
  {
    return openXmlElement?.ReverseAnimation?.Value;
  }
  
  private static bool CmpReverseAnimation(DXD.BuildDiagram openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.ReverseAnimation?.Value == value) return true;
    diffs?.Add(objName, "ReverseAnimation", openXmlElement?.ReverseAnimation?.Value, value);
    return false;
  }
  
  private static void SetReverseAnimation(DXD.BuildDiagram openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ReverseAnimation = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ReverseAnimation = null;
  }
  
  public static DMD.BuildDiagram? CreateModelElement(DXD.BuildDiagram? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.BuildDiagram();
      value.Build = GetBuild(openXmlElement);
      value.ReverseAnimation = GetReverseAnimation(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.BuildDiagram? openXmlElement, DMD.BuildDiagram? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBuild(openXmlElement, value.Build, diffs, objName, propName))
        ok = false;
      if (!CmpReverseAnimation(openXmlElement, value.ReverseAnimation, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.BuildDiagram value)
    where OpenXmlElementType: DXD.BuildDiagram, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.BuildDiagram openXmlElement, DMD.BuildDiagram value)
  {
    SetBuild(openXmlElement, value?.Build);
    SetReverseAnimation(openXmlElement, value?.ReverseAnimation);
  }
}
