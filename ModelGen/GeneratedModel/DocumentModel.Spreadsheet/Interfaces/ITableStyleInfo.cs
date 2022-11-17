namespace DocumentModel.Spreadsheet;

public interface ITableStyleInfo // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public string? Name { get ; set; }

  public bool? ShowFirstColumn { get ; set; }

  public bool? ShowLastColumn { get ; set; }

  public bool? ShowRowStripes { get ; set; }

  public bool? ShowColumnStripes { get ; set; }

}
