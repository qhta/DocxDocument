namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Build Chart.
/// </summary>
public static class BuildChartConverter
{
  /// <summary>
  /// Build
  /// </summary>
  private static String? GetBuild(DXDraw.BuildChart openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Build);
  }
  
  private static bool CmpBuild(DXDraw.BuildChart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Build, value, diffs, objName, "Build");
  }
  
  private static void SetBuild(DXDraw.BuildChart openXmlElement, String? value)
  {
    openXmlElement.Build = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Animate Background
  /// </summary>
  private static Boolean? GetAnimateBackground(DXDraw.BuildChart openXmlElement)
  {
    return openXmlElement?.AnimateBackground?.Value;
  }
  
  private static bool CmpAnimateBackground(DXDraw.BuildChart openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.AnimateBackground?.Value == value) return true;
    diffs?.Add(objName, "AnimateBackground", openXmlElement?.AnimateBackground?.Value, value);
    return false;
  }
  
  private static void SetAnimateBackground(DXDraw.BuildChart openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AnimateBackground = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.AnimateBackground = null;
  }
  
  public static DocumentModel.Drawings.BuildChart? CreateModelElement(DXDraw.BuildChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.BuildChart();
      value.Build = GetBuild(openXmlElement);
      value.AnimateBackground = GetAnimateBackground(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.BuildChart? openXmlElement, DMDraws.BuildChart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBuild(openXmlElement, value.Build, diffs, objName))
        ok = false;
      if (!CmpAnimateBackground(openXmlElement, value.AnimateBackground, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.BuildChart value)
    where OpenXmlElementType: DXDraw.BuildChart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.BuildChart openXmlElement, DMDraws.BuildChart value)
  {
    SetBuild(openXmlElement, value?.Build);
    SetAnimateBackground(openXmlElement, value?.AnimateBackground);
  }
}
