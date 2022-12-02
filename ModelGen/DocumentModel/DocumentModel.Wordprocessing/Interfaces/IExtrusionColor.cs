namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ExtrusionColor Class.
/// </summary>
public interface IExtrusionColor // : DocumentModel.Wordprocessing.IColorType
{
  public DocumentModel.Wordprocessing.IRgbColorModelHex? RgbColorModelHex { get ; set; }
  
  public DocumentModel.Wordprocessing.ISchemeColor? SchemeColor { get ; set; }
  
}
