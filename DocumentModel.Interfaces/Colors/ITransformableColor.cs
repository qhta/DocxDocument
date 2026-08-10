namespace DocumentModel;

/// <summary>
/// Interface representing a color that can be transformed by a collection of transformations.
/// </summary>
public interface ITransformableColor: IColor
{
  /// <summary>
  /// Adds a transformation to the color.
  /// </summary>
  /// <param name="transformation">The transformation to add.</param>
  /// <returns>True if the transformation was added successfully; otherwise, false.</returns>
  public bool AddTransformation(IColorTransformation transformation);
  
  /// <summary>
  /// Returns a collection of transformations applied to the color.
  /// </summary>
  /// <returns>A collection of transformations.</returns>
  public IEnumerable<IColorTransformation> GetTransformations();


  /// <summary>
  /// Evaluates and returns the effective color after applying color transformations to the original color.
  /// </summary>
  /// <returns>The effective color after transformations.</returns>
  public IColor GetEffectiveColor();
}