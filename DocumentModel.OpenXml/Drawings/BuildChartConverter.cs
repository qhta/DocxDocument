namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Build Chart.
/// </summary>
public static class BuildChartConverter
{
  /// <summary>
  /// Build
  /// </summary>
  private static String? GetBuild(DXD.BuildChart openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Build);
  }
  
  private static bool CmpBuild(DXD.BuildChart openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Build, value, diffs, objName, "Build");
  }
  
  private static void SetBuild(DXD.BuildChart openXmlElement, String? value)
  {
    openXmlElement.Build = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Animate Background
  /// </summary>
  private static Boolean? GetAnimateBackground(DXD.BuildChart openXmlElement)
  {
    return openXmlElement?.AnimateBackground?.Value;
  }
  
  private static bool CmpAnimateBackground(DXD.BuildChart openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.AnimateBackground?.Value == value) return true;
    diffs?.Add(objName, "AnimateBackground", openXmlElement?.AnimateBackground?.Value, value);
    return false;
  }
  
  private static void SetAnimateBackground(DXD.BuildChart openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AnimateBackground = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.AnimateBackground = null;
  }
  
  public static DMD.BuildChart? CreateModelElement(DXD.BuildChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.BuildChart();
      value.Build = GetBuild(openXmlElement);
      value.AnimateBackground = GetAnimateBackground(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.BuildChart? openXmlElement, DMD.BuildChart? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBuild(openXmlElement, value.Build, diffs, objName, propName))
        ok = false;
      if (!CmpAnimateBackground(openXmlElement, value.AnimateBackground, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.BuildChart value)
    where OpenXmlElementType: DXD.BuildChart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.BuildChart openXmlElement, DMD.BuildChart value)
  {
    SetBuild(openXmlElement, value?.Build);
    SetAnimateBackground(openXmlElement, value?.AnimateBackground);
  }
}
