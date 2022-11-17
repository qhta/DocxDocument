namespace DocumentModel.Spreadsheet;

public interface IOlapProperties // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public bool? Local { get ; set; }

  public string? LocalConnection { get ; set; }

  public bool? LocalRefresh { get ; set; }

  public bool? SendLocale { get ; set; }

  public uint? RowDrillCount { get ; set; }

  public bool? ServerFill { get ; set; }

  public bool? ServerNumberFormat { get ; set; }

  public bool? ServerFont { get ; set; }

  public bool? ServerFontColor { get ; set; }

}
