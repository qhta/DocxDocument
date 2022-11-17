namespace DocumentModel.Spreadsheet;

public interface IAlignment // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public DocumentModel.Spreadsheet.HorizontalAlignment? Horizontal { get ; set; }

  public DocumentModel.Spreadsheet.VerticalAlignment? Vertical { get ; set; }

  public uint? TextRotation { get ; set; }

  public bool? WrapText { get ; set; }

  public uint? Indent { get ; set; }

  public int? RelativeIndent { get ; set; }

  public bool? JustifyLastLine { get ; set; }

  public bool? ShrinkToFit { get ; set; }

  public uint? ReadingOrder { get ; set; }

  public string? MergeCell { get ; set; }

}
