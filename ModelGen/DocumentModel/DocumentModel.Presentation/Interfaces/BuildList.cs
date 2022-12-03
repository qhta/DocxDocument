namespace DocumentModel.Presentation;

/// <summary>
/// Build List.
/// </summary>
public interface BuildList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<BuildParagraph>? BuildParagraphs { get ; set; }
  
  public Collection<BuildDiagram>? BuildDiagrams { get ; set; }
  
  public Collection<BuildOleChart>? BuildOleCharts { get ; set; }
  
  public Collection<BuildGraphics>? BuildGraphicses { get ; set; }
  
}
