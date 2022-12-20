namespace DocumentModel.Drawings;

/// <summary>
/// Defines the BiLevel Class.
/// </summary>
public partial class BiLevelImpl: ModelElementImpl, BiLevel
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.BiLevel? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.BiLevel?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public BiLevelImpl(): base() {}
  
  public BiLevelImpl(DocumentFormat.OpenXml.Drawing.BiLevel openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Threshold
  /// </summary>
  public Int32? Threshold
  {
    get => (System.Int32?)OpenXmlElement?.Threshold?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Threshold = (System.Int32?)value;
    }
  }
  
}
