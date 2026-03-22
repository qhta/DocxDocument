namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a collection of 3D surface chart extensions.
/// </summary>
[OpenXmlType(typeof(DXDC.Surface3DChartExtensionList))]
public partial class Surface3DChartExtensionList: ModelElementCollection<Surface3DChartExtension, 
  DXDC.Surface3DChartExtensionList, DXDC.Surface3DChartExtension>
{
  /// <summary>
  ///   Collection of 3D surface chart extension items.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.Surface3DChartExtension))]
  public Surface3DChartExtensions? Surface3DChartExtensions
  {
    get => _Surface3DChartExtensions;
    set => UpdateField(ref _Surface3DChartExtensions, value, nameof(Surface3DChartExtensions));
  }
  private Surface3DChartExtensions? _Surface3DChartExtensions;
}