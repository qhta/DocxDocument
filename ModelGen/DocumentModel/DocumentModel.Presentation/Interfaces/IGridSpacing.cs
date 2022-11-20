namespace DocumentModel.Presentation;

/// <summary>
/// Grid Spacing.
/// </summary>
public interface IGridSpacing // : DocumentFormat.OpenXml.Presentation.PositiveSize2DType
{
  /// <summary>
  /// Extent Length
  /// </summary>
  public long? Cx { get ; set; }
  
  /// <summary>
  /// Extent Width
  /// </summary>
  public long? Cy { get ; set; }
  
}
