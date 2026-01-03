namespace DocumentModel.Drawings;
/// <summary>
///   Extent for 2D drawings
/// </summary>

public interface Extent
{
  /// <summary>
  ///   X extent
  /// </summary>
  public EMU Cx { get; set; }
  /// <summary>
  ///   Y extent
  /// </summary>
  public EMU Cy { get; set; }
}