namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ContourColor Class.
/// </summary>
public interface IContourColor // : DocumentModel.Wordprocessing.IColorType
{
  public IRgbColorModelHex? RgbColorModelHex { get ; set; }
  
  public ISchemeColor? SchemeColor { get ; set; }
  
}
