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
