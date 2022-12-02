namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ContourColor Class.
/// </summary>
public interface IContourColor // : DocumentModel.Wordprocessing.IColorType
{
  public DocumentModel.Wordprocessing.IRgbColorModelHex? RgbColorModelHex { get ; set; }
  
  public DocumentModel.Wordprocessing.ISchemeColor? SchemeColor { get ; set; }
  
}
