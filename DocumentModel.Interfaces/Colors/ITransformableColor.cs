namespace DocumentModel;

/// <summary>
/// Interface representing a color that can be transformed, providing properties to get or set the tint and shade values of the color.
/// </summary>
public interface ITransformableColor
{

  /// <summary>
  /// Gets or sets the tint value of the color. The tint is a double value that represents the amount of white or black added to the color.
  /// </summary>
  public double? Tint { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the shade value of the color. The shade is a double value that represents the amount of black added to the color.
  /// </summary>
  public double? Shade { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Evaluates and returns the effective color after applying color transformations to the original color.
  /// </summary>
  /// <returns>The effective color after transformations.</returns>
  public IColor GetEffectiveColor();
  
  /// <summary>
  /// Returns a collection of transformations applied to the color.
  /// </summary>
  /// <returns>A collection of transformations.</returns>
  public IEnumerable<IColorTransformation> GetTransformations();
}