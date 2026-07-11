namespace DocumentModel;

/// <summary>
/// Interface representing a percentage value, providing access to both the integer percentage and its decimal factor representation.
/// </summary>
public interface IPercentage
{
  /// <summary>
  /// Gets the integer percentage value represented by this instance (e.g., 50 for 50%).
  /// </summary>
  /// <returns>The integer representation of the percentage value.</returns>
  public int AsInteger();

  /// <summary>
  /// Gets the percentage value represented by this instance.
  /// </summary>
  /// <returns>The decimal representation of the percentage value.</returns>
  public decimal AsDecimal();

  /// <summary>
  /// Gets the factor in double form represented by this instance (e.g., 0.5 for 50%).
  /// </summary>
  /// <returns>The double representation of the percentage value as a factor.</returns> 
  public double AsDouble();

}