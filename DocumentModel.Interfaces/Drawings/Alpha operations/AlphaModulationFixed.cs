namespace DocumentModel.Drawings;

/// <summary>
/// Represents an alpha modulation effect with a fixed amount, used to adjust the transparency of an image or shape.
/// </summary>
public interface AlphaModulationFixed
{
  /// <summary>
  /// Fixed amount by which the alpha channel is modulated.
  /// </summary>
  public Int32? Amount { get; set; }
}