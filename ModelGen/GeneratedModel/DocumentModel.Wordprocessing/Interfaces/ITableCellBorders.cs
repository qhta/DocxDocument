namespace DocumentModel.Wordprocessing;

public interface ITableCellBorders // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Wordprocessing.ITopBorder? TopBorder { get ; set; }

  public DocumentModel.Wordprocessing.ILeftBorder? LeftBorder { get ; set; }

  public DocumentModel.Wordprocessing.IStartBorder? StartBorder { get ; set; }

  public DocumentModel.Wordprocessing.IBottomBorder? BottomBorder { get ; set; }

  public DocumentModel.Wordprocessing.IRightBorder? RightBorder { get ; set; }

  public DocumentModel.Wordprocessing.IEndBorder? EndBorder { get ; set; }

  public DocumentModel.Wordprocessing.IInsideHorizontalBorder? InsideHorizontalBorder { get ; set; }

  public DocumentModel.Wordprocessing.IInsideVerticalBorder? InsideVerticalBorder { get ; set; }

  public ITopLeftToBottomRightCellBorder? TopLeftToBottomRightCellBorder { get ; set; }

  public ITopRightToBottomLeftCellBorder? TopRightToBottomLeftCellBorder { get ; set; }

}
