namespace DocumentModel.Drawings;

/// <summary>
/// Defines the EffectContainerType Class.
/// </summary>
public partial class EffectContainerTypeImpl: ModelElementImpl, EffectContainerType
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.EffectContainerType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.EffectContainerType?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public EffectContainerTypeImpl(): base() {}
  
  public EffectContainerTypeImpl(DocumentFormat.OpenXml.Drawing.EffectContainerType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Effect Container Type
  /// </summary>
  public DocumentModel.Drawings.EffectContainerKind? Type
  {
    get => (DocumentModel.Drawings.EffectContainerKind?)OpenXmlElement?.Type?.Value;
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
    get => (System.String?)OpenXmlElement?.Name?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Name = (System.String?)value;
    }
  }
  
}
