namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a collection of 3D surface chart extensions.
/// </summary>
public class Surface3DChartExtensionList : ModelElement<DXDC.Surface3DChartExtensionList>
{
  /// <summary>
  ///   Collection of 3D surface chart extension items.
  /// </summary>
  public Surface3DChartExtensions? Surface3DChartExtensions { get; set; }
}