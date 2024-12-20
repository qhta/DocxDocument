namespace DocumentModel.Drawings;

/// <summary>
/// Defines the AlphaBiLevel Class.
/// </summary>
public partial class AlphaBiLevelImpl: ModelElementImpl, AlphaBiLevel
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.AlphaBiLevel? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.AlphaBiLevel?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public AlphaBiLevelImpl(): base() {}
  
  public AlphaBiLevelImpl(DocumentFormat.OpenXml.Drawing.AlphaBiLevel openXmlElement): base(openXmlElement)
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
