namespace DocumentModel.Drawings;

/// <summary>
/// Build Diagram.
/// </summary>
public class BuildDiagramImpl: ModelElementImpl, BuildDiagram
{
  public DocumentFormat.OpenXml.Drawing.BuildDiagram? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.BuildDiagram?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Build
  /// </summary>
  public String? Build
  {
    get;
    set;
  }
  
  /// <summary>
  /// Reverse Animation
  /// </summary>
  public Boolean? ReverseAnimation
  {
    get;
    set;
  }
  
}
