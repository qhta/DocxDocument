namespace DocumentModel.Vml;

/// <summary>
/// Defines the Shadow Class.
/// </summary>
public class ShadowImpl: ModelElement<DocumentFormat.OpenXml.Vml.Shadow>, Shadow
{
  /// <summary>
  /// Shadow Type
  /// </summary>
  public ShadowKind? Type
  {
    get => (ShadowKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Vml.ShadowValues?)value;
    }
  }
  
}
