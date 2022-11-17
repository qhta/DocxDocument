namespace DocumentModel.Wordprocessing;

public interface IPageBorders // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public PageBorderZOrder? ZOrder { get ; set; }

  public PageBorderDisplay? Display { get ; set; }

  public PageBorderOffset? OffsetFrom { get ; set; }

  public DocumentModel.Wordprocessing.ITopBorder? TopBorder { get ; set; }

  public DocumentModel.Wordprocessing.ILeftBorder? LeftBorder { get ; set; }

  public DocumentModel.Wordprocessing.IBottomBorder? BottomBorder { get ; set; }

  public DocumentModel.Wordprocessing.IRightBorder? RightBorder { get ; set; }

}
