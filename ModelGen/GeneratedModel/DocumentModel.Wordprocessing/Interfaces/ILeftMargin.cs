namespace DocumentModel.Wordprocessing;

public interface ILeftMargin // : DocumentFormat.OpenXml.Wordprocessing.TableWidthType
{
  public string? Width { get ; set; }

  public TableWidthUnit? Type { get ; set; }

}
