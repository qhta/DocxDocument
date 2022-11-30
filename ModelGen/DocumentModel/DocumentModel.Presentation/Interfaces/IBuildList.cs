namespace DocumentModel.Presentation;

/// <summary>
/// Build List.
/// </summary>
public interface IBuildList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public DocumentModel.Presentation.IBuildParagraph? BuildParagraph { get ; set; }
  
  public DocumentModel.Presentation.IBuildDiagram? BuildDiagram { get ; set; }
  
  public DocumentModel.Presentation.IBuildOleChart? BuildOleChart { get ; set; }
  
  public DocumentModel.Presentation.IBuildGraphics? BuildGraphics { get ; set; }
  
}
