namespace DocumentModel.Spreadsheet;

public interface ISelection // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public Pane? Pane { get ; set; }

  public string? ActiveCell { get ; set; }

  public uint? ActiveCellId { get ; set; }

  public List<string>? SequenceOfReferences { get ; set; }

}
