namespace DocumentModel.Spreadsheet;

public interface IIconFilter // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public IconSet? IconSet { get ; set; }

  public uint? IconId { get ; set; }

}
