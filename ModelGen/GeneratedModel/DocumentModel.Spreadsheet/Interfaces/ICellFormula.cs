namespace DocumentModel.Spreadsheet;

public interface ICellFormula // : DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement
{
  public CellFormula? FormulaType { get ; set; }

  public bool? AlwaysCalculateArray { get ; set; }

  public string? Reference { get ; set; }

  public bool? DataTable2D { get ; set; }

  public bool? DataTableRow { get ; set; }

  public bool? Input1Deleted { get ; set; }

  public bool? Input2Deleted { get ; set; }

  public string? R1 { get ; set; }

  public string? R2 { get ; set; }

  public bool? CalculateCell { get ; set; }

  public uint? SharedIndex { get ; set; }

  public bool? Bx { get ; set; }

  public SpaceProcessingMode? Space { get ; set; }

  public string? Text { get ; set; }

}
