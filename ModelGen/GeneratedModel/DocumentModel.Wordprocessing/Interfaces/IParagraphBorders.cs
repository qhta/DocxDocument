namespace DocumentModel.Wordprocessing;

public interface IParagraphBorders // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Wordprocessing.ITopBorder? TopBorder { get ; set; }

  public DocumentModel.Wordprocessing.ILeftBorder? LeftBorder { get ; set; }

  public DocumentModel.Wordprocessing.IBottomBorder? BottomBorder { get ; set; }

  public DocumentModel.Wordprocessing.IRightBorder? RightBorder { get ; set; }

  public IBetweenBorder? BetweenBorder { get ; set; }

  public IBarBorder? BarBorder { get ; set; }

}
