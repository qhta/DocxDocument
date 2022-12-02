namespace DocumentModel.Presentation;

/// <summary>
/// Build List.
/// </summary>
public interface IBuildList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IBuildParagraph>? BuildParagraphs { get ; set; }
  
  public Collection<IBuildDiagram>? BuildDiagrams { get ; set; }
  
  public Collection<IBuildOleChart>? BuildOleCharts { get ; set; }
  
  public Collection<IBuildGraphics>? BuildGraphicses { get ; set; }
  
}
