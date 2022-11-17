namespace DocumentModel.Wordprocessing;

public interface ITableCellMargin // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public ITopMargin? TopMargin { get ; set; }
  
  public DocumentModel.Wordprocessing.ILeftMargin? LeftMargin { get ; set; }
  
  public IStartMargin? StartMargin { get ; set; }
  
  public IBottomMargin? BottomMargin { get ; set; }
  
  public DocumentModel.Wordprocessing.IRightMargin? RightMargin { get ; set; }
  
  public IEndMargin? EndMargin { get ; set; }
  
}
