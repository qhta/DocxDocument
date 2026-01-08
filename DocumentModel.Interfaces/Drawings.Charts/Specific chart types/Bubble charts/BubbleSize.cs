namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents the size values for bubbles in a bubble chart, including references and literals.
/// </summary>
public interface BubbleSize
{
  /// <summary>
  ///   Reference to the numeric values used for bubble sizes.
  /// </summary>
  public NumberReference? NumberReference { get; set; }

  /// <summary>
  ///   Literal numeric values for bubble sizes.
  /// </summary>
  public NumberLiteral? NumberLiteral { get; set; }
}