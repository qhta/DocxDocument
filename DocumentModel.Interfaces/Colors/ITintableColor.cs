namespace DocumentModel;

/// <summary>
/// Interface representing a color that can be tinted or shaded, providing properties to get or set the tint and shade values of the color.
/// </summary>
public interface ITintableColor
{

  /// <summary>
  /// Gets or sets the tint value of the color. The tint is a double value that represents the amount of white or black added to the color.
  /// </summary>
  public double? Tint { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the shade value of the color. The shade is a double value that represents the amount of black added to the color.
  /// </summary>
  public double? Shade { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}