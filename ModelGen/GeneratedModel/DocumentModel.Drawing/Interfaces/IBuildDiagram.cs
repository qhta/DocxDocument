namespace DocumentModel.Drawing;

public interface IBuildDiagram // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public string? Build { get ; set; }
  
  public bool? ReverseAnimation { get ; set; }
  
}
