namespace DocumentModel.Wordprocessing;

public interface ITableCellMarginDefault // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public ITopMargin? TopMargin { get ; set; }

  public ITableCellLeftMargin? TableCellLeftMargin { get ; set; }

  public IStartMargin? StartMargin { get ; set; }

  public IBottomMargin? BottomMargin { get ; set; }

  public ITableCellRightMargin? TableCellRightMargin { get ; set; }

  public IEndMargin? EndMargin { get ; set; }

}
