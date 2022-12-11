namespace DocumentModel.Drawings;

/// <summary>
/// Effect.
/// </summary>
public class EffectImpl: ModelElementImpl, Effect
{
  public DocumentFormat.OpenXml.Drawing.Effect? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Effect?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public EffectImpl(): base() {}
  
  public EffectImpl(DocumentFormat.OpenXml.Drawing.Effect openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Reference
  /// </summary>
  public String? Reference
  {
    get => (String?)OpenXmlElement?.Reference?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Reference = (System.String?)value;
    }
  }
  
}
