using DocumentFormat.OpenXml.Drawing;
using DocumentModel.Drawings;
using Diagram = DocumentFormat.OpenXml.Drawing.Diagram;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Diagram to Animate.
/// </summary>
public static class DiagramConverter
{
  /// <summary>
  ///   Identifier
  /// </summary>
  public static String? GetId(Diagram? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(Diagram? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }

  /// <summary>
  ///   Animation Build Step
  /// </summary>
  public static DiagramBuildStepKind? GetBuildStep(Diagram? openXmlElement)
  {
    return EnumValueConverter.GetValue<DiagramBuildStepValues, DiagramBuildStepKind>(openXmlElement?.BuildStep?.Value);
  }

  public static void SetBuildStep(Diagram? openXmlElement, DiagramBuildStepKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.BuildStep = EnumValueConverter.CreateEnumValue<DiagramBuildStepValues, DiagramBuildStepKind>(value);
  }

  public static DocumentModel.Drawings.Diagram? CreateModelElement(Diagram? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagram();
      value.Id = GetId(openXmlElement);
      value.BuildStep = GetBuildStep(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagram? value)
    where OpenXmlElementType : Diagram, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetBuildStep(openXmlElement, value?.BuildStep);
      return openXmlElement;
    }
    return default;
  }
}