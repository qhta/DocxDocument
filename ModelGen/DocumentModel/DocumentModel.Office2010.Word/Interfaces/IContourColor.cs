namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the ContourColor Class.
/// </summary>
public interface IContourColor // : DocumentModel.Office2010.Word.IColorType
{
  public DocumentModel.Office2010.Word.IRgbColorModelHex? RgbColorModelHex { get ; set; }
  
  public DocumentModel.Office2010.Word.ISchemeColor? SchemeColor { get ; set; }
  
}
