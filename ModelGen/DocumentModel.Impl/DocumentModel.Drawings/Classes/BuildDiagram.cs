namespace DocumentModel.Drawings;

/// <summary>
/// Build Diagram.
/// </summary>
public partial class BuildDiagramImpl: ModelElementImpl, BuildDiagram
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.BuildDiagram? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.BuildDiagram?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public BuildDiagramImpl(): base() {}
  
  public BuildDiagramImpl(DocumentFormat.OpenXml.Drawing.BuildDiagram openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Build
  /// </summary>
  public String? Build
  {
    get => (System.String?)OpenXmlElement?.Build?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Build = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Reverse Animation
  /// </summary>
  public Boolean? ReverseAnimation
  {
    get => (System.Boolean?)OpenXmlElement?.ReverseAnimation?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ReverseAnimation = (System.Boolean?)value;
    }
  }
  
}
