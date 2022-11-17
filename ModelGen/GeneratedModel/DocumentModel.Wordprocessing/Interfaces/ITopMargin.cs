namespace DocumentModel.Wordprocessing;

public interface ITopMargin // : DocumentFormat.OpenXml.Wordprocessing.TableWidthType
{
  public string? Width { get ; set; }

  public TableWidthUnit? Type { get ; set; }

}
