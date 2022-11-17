namespace DocumentModel.Presentation;

public interface IBuildSubElement // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Drawing.IBuildDiagram? BuildDiagram { get ; set; }
  
  public IBuildChart? BuildChart { get ; set; }
  
}
