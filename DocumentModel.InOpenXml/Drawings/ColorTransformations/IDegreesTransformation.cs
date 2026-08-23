namespace DocumentModel.Drawings;

/// <summary>
/// Defines an interface for transformations that involve a degrees parameter. 
/// </summary>
public interface IDegreesTransformation : IColorTransformation
{
  /// <summary>
  /// Gets or sets the degrees value associated with the transformation.
  /// </summary>
  public Degrees Value { get; set; }
}