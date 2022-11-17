namespace DocumentModel.Drawing;

public interface IDiagram // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public string? Id { get ; set; }
  
  public DiagramBuildStep? BuildStep { get ; set; }
  
}
