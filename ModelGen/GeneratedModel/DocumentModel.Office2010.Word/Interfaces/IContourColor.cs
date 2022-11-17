namespace DocumentModel.Office2010.Word;

public interface IContourColor // : DocumentFormat.OpenXml.Office2010.Word.ColorType
{
  public DocumentModel.Office2010.Word.IRgbColorModelHex? RgbColorModelHex { get ; set; }
  
  public DocumentModel.Office2010.Word.ISchemeColor? SchemeColor { get ; set; }
  
}
