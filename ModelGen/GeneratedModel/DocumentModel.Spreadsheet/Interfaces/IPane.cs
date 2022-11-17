namespace DocumentModel.Spreadsheet;

public interface IPane // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public double? HorizontalSplit { get ; set; }
  
  public double? VerticalSplit { get ; set; }
  
  public string? TopLeftCell { get ; set; }
  
  public Pane? ActivePane { get ; set; }
  
  public PaneState? State { get ; set; }
  
}
