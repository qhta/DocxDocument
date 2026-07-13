namespace DocumentModel;

/// <summary>
/// Represents a color transformation that can be applied to a color.
/// </summary>
public interface IColorTransformation
{
  /// <summary>
  /// Transforms the specified source color according to the transformation defined by the implementation of this interface.
  /// </summary>
  /// <param name="sourceColor">The source color to be transformed.</param>
  /// <returns>The transformed color.</returns>
  public IColor Transform(IColor sourceColor);
}