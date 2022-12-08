namespace DocumentModel.Drawings;

/// <summary>
/// Defines the EffectContainerType Class.
/// </summary>
public class EffectContainerTypeImpl: ModelElementImpl, EffectContainerType
{
  public DocumentFormat.OpenXml.Drawing.EffectContainerType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.EffectContainerType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
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
  
  /// <summary>
  /// Name
  /// </summary>
  public String? Name
  {
    get;
    set;
  }
  
}
