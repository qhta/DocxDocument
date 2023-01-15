using DocumentFormat.OpenXml.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Build Diagram.
/// </summary>
public static class BuildDiagramConverter
{
  /// <summary>
  ///   Build
  /// </summary>
  public static String? GetBuild(BuildDiagram? openXmlElement)
  {
    return openXmlElement?.Build?.Value;
  }

  public static void SetBuild(BuildDiagram? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Build = new StringValue { Value = value };
      else
        openXmlElement.Build = null;
  }

  /// <summary>
  ///   Reverse Animation
  /// </summary>
  public static Boolean? GetReverseAnimation(BuildDiagram? openXmlElement)
  {
    return openXmlElement?.ReverseAnimation?.Value;
  }

  public static void SetReverseAnimation(BuildDiagram? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ReverseAnimation = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.ReverseAnimation = null;
  }

  public static DocumentModel.Drawings.BuildDiagram? CreateModelElement(BuildDiagram? openXmlElement)
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.BuildDiagram? value)
    where OpenXmlElementType : BuildDiagram, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBuild(openXmlElement, value?.Build);
      SetReverseAnimation(openXmlElement, value?.ReverseAnimation);
      return openXmlElement;
    }
    return default;
  }
}