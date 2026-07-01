namespace DocumentModel.Drawings;

/// <summary>
/// Defines an interface for transformations that involve a percentage parameter. 
/// </summary>
public interface IPercentageTransformation: IColorTransformation
{
  /// <summary>
  /// Gets or sets the percentage value associated with the transformation.
  /// </summary>
  public Percentage Value { get; set; }
}