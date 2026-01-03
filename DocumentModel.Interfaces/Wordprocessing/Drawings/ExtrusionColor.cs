namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the ExtrusionColor Class.
/// </summary>
public interface ExtrusionColor: IModelElement
{
  public RgbColorModelHex? RgbColorModelHex { get; set; }
  public SchemeColor? SchemeColor { get; set; }
}