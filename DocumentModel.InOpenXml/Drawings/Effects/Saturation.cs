namespace DocumentModel.Drawings;

/// <summary>
///   Represents a saturation effect, allowing adjustment of color saturation for a drawing element.
/// </summary>
public interface Saturation
{
  /// <summary>
  ///   Amount of saturation adjustment.
  /// </summary>
  public Int32? SaturationAmount { get; set; }
}