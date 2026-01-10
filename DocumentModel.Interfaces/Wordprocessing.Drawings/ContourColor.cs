namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the ContourColor Class.
/// </summary>
public interface ContourColor
{
  public RgbColor? RgbColor { get; set; }
  public SchemeColor? SchemeColor { get; set; }
}