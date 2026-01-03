namespace DocumentModel.Drawings;

/// <summary>
///   Defines the Blur interface.
/// </summary>
public interface Blur: IModelElement
{
  /// <summary>
  ///   Radius
  /// </summary>
  public Int64? Radius { get; set; }
  /// <summary>
  ///   Grow Bounds
  /// </summary>
  public bool? Grow { get; set; }
}