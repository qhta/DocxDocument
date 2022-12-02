namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ExtrusionColor Class.
/// </summary>
public interface IExtrusionColor // : DocumentModel.Wordprocessing.IColorType
{
  public IRgbColorModelHex? RgbColorModelHex { get ; set; }
  
  public ISchemeColor? SchemeColor { get ; set; }
  
}
