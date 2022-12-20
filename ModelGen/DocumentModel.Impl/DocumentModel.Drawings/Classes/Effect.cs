namespace DocumentModel.Drawings;

/// <summary>
/// Effect.
/// </summary>
public partial class EffectImpl: ModelElementImpl, Effect
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Effect? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Effect?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
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
    get => (System.String?)OpenXmlElement?.Reference?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Reference = (System.String?)value;
    }
  }
  
}
