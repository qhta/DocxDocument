namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the ExtrusionColor Class.
/// </summary>
public interface IExtrusionColor // : DocumentModel.Office2010.Word.IColorType
{
  public DocumentModel.Office2010.Word.IRgbColorModelHex? RgbColorModelHex { get ; set; }
  
  public DocumentModel.Office2010.Word.ISchemeColor? SchemeColor { get ; set; }
  
}
