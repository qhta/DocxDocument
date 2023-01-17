namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Build Diagram.
/// </summary>
public static class BuildDiagramConverter
{
  /// <summary>
  /// Build
  /// </summary>
  private static String? GetBuild(DocumentFormat.OpenXml.Drawing.BuildDiagram openXmlElement)
  {
    return openXmlElement?.Build?.Value;
  }
  
  private static void SetBuild(DocumentFormat.OpenXml.Drawing.BuildDiagram openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Build = new StringValue { Value = value };
    else
      openXmlElement.Build = null;
  }
  
  /// <summary>
  /// Reverse Animation
  /// </summary>
  private static Boolean? GetReverseAnimation(DocumentFormat.OpenXml.Drawing.BuildDiagram openXmlElement)
  {
    return openXmlElement?.ReverseAnimation?.Value;
  }
  
  private static void SetReverseAnimation(DocumentFormat.OpenXml.Drawing.BuildDiagram openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ReverseAnimation = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ReverseAnimation = null;
  }
  
  public static DocumentModel.Drawings.BuildDiagram? CreateModelElement(DocumentFormat.OpenXml.Drawing.BuildDiagram? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.BuildDiagram, new()
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
