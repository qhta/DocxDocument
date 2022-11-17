namespace DocumentModel.Spreadsheet;

public interface IObjectAnchor // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public bool? MoveWithCells { get ; set; }
  
  public bool? SizeWithCells { get ; set; }
  
  public uint? ZOrder { get ; set; }
  
  public DocumentModel.Spreadsheet.IFromMarker? FromMarker { get ; set; }
  
  public DocumentModel.Spreadsheet.IToMarker? ToMarker { get ; set; }
  
}
