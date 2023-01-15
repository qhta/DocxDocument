using DocumentFormat.OpenXml.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Build Chart.
/// </summary>
public static class BuildChartConverter
{
  /// <summary>
  ///   Build
  /// </summary>
  public static String? GetBuild(BuildChart? openXmlElement)
  {
    return openXmlElement?.Build?.Value;
  }

  public static void SetBuild(BuildChart? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Build = new StringValue { Value = value };
      else
        openXmlElement.Build = null;
  }

  /// <summary>
  ///   Animate Background
  /// </summary>
  public static Boolean? GetAnimateBackground(BuildChart? openXmlElement)
  {
    return openXmlElement?.AnimateBackground?.Value;
  }

  public static void SetAnimateBackground(BuildChart? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AnimateBackground = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.AnimateBackground = null;
  }

  public static DocumentModel.Drawings.BuildChart? CreateModelElement(BuildChart? openXmlElement)
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.BuildChart? value)
    where OpenXmlElementType : BuildChart, new()
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