namespace DocumentModel.Drawings;

/// <summary>
/// Defines the EffectContainerType Class.
/// </summary>
public class EffectContainerTypeImpl: ModelElement<DocumentFormat.OpenXml.Drawing.EffectContainerType>, EffectContainerType
{
  /// <summary>
  /// Effect Container Type
  /// </summary>
  public EffectContainerKind? Type
  {
    get => (EffectContainerKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Drawing.EffectContainerValues?)value;
    }
  }
  
}
