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
    return openXmlElement?.Build?.Value;
  }
  
  private static bool CmpBuild(DXDraw.BuildChart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Build?.Value == value;
  }
  
  private static void SetBuild(DXDraw.BuildChart openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Build = new StringValue { Value = value };
    else
      openXmlElement.Build = null;
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
    return openXmlElement?.AnimateBackground?.Value == value;
  }
  
  private static void SetAnimateBackground(DXDraw.BuildChart openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AnimateBackground = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.AnimateBackground = null;
  }
  
  public static DMDraws.BuildChart? CreateModelElement(DXDraw.BuildChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.BuildChart();
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.BuildChart? value)
    where OpenXmlElementType: DXDraw.BuildChart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBuild(openXmlElement, value?.Build);
      SetAnimateBackground(openXmlElement, value?.AnimateBackground);
      return openXmlElement;
    }
    return default;
  }
}
