namespace DocumentModel.Office2010.Excel;

public interface IIconFilter // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public IconSetType? IconSet { get ; set; }

  public uint? IconId { get ; set; }

}
