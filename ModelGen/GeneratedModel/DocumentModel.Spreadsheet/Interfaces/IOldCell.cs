namespace DocumentModel.Spreadsheet;

public interface IOldCell // : DocumentFormat.OpenXml.Spreadsheet.CellType
{
  public string? CellReference { get ; set; }

  public uint? StyleIndex { get ; set; }

  public Cell? DataType { get ; set; }

  public uint? CellMetaIndex { get ; set; }

  public uint? ValueMetaIndex { get ; set; }

  public bool? ShowPhonetic { get ; set; }

  public ICellFormula? CellFormula { get ; set; }

  public ICellValue? CellValue { get ; set; }

  public IInlineString? InlineString { get ; set; }

  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }

}
