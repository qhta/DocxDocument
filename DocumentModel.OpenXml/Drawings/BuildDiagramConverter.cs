namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Build Diagram.
/// </summary>
public static class BuildDiagramConverter
{
  /// <summary>
  /// Build
  /// </summary>
  public static String? GetBuild(DocumentFormat.OpenXml.Drawing.BuildDiagram? openXmlElement)
  {
    return openXmlElement?.Build?.Value;
  }
  
  public static void SetBuild(DocumentFormat.OpenXml.Drawing.BuildDiagram? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Build = new StringValue { Value = value };
      else
        openXmlElement.Build = null;
  }
  
  /// <summary>
  /// Reverse Animation
  /// </summary>
  public static Boolean? GetReverseAnimation(DocumentFormat.OpenXml.Drawing.BuildDiagram? openXmlElement)
  {
    return openXmlElement?.ReverseAnimation?.Value;
  }
  
  public static void SetReverseAnimation(DocumentFormat.OpenXml.Drawing.BuildDiagram? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
