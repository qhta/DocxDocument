namespace DocumentModel.Wordprocessing;

public interface IDivBorder // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Wordprocessing.ITopBorder? TopBorder { get ; set; }
  
  public DocumentModel.Wordprocessing.ILeftBorder? LeftBorder { get ; set; }
  
  public DocumentModel.Wordprocessing.IBottomBorder? BottomBorder { get ; set; }
  
  public DocumentModel.Wordprocessing.IRightBorder? RightBorder { get ; set; }
  
}
