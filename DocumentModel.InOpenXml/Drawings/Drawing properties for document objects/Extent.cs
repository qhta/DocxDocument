namespace DocumentModel.Drawings;

/// <summary>
///   Represents the extent (width and height) for 2D drawings, measured in English Metric Units (EMUs).
/// </summary>
public class Extent: ModelElement<DXDW.Extent>
{
  /// <summary>
  ///   Width of the extent in EMUs.
  /// </summary>
  public EMU? Cx { get; set; }

  /// <summary>
  ///   Height of the extent in EMUs.
  /// </summary>
  public EMU? Cy { get; set; }
}