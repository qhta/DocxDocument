namespace DocumentModel.Spreadsheet;

public interface IPivotTableStyle // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public string? Name { get ; set; }

  public bool? ShowRowHeaders { get ; set; }

  public bool? ShowColumnHeaders { get ; set; }

  public bool? ShowRowStripes { get ; set; }

  public bool? ShowColumnStripes { get ; set; }

  public bool? ShowLastColumn { get ; set; }

}
