namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents the formatting for a specific band in a surface chart.
///   This class defines the index and visual properties of the band.
/// </summary>
[OpenXmlType(typeof(DXDC.BandFormat))]
[XmlRoot("BandFormat", Namespace = "DocumentModel.Drawings.Charts")]
public partial class BandFormat : ModelElement<DXDC.BandFormat>
{
 /// <summary>
 ///   Index of the band within the collection.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.BandFormat.Index))]
 public UInt32? Index { get => _Index; set => UpdateField(ref _Index, value, nameof(Index)); }

 private UInt32? _Index;
 /// <summary>
 ///   Visual and shape properties for the band.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.BandFormat.ChartShapeProperties))]
 public ChartShapeProperties? ChartShapeProperties { get => _ChartShapeProperties; set => UpdateField(ref _ChartShapeProperties, value, nameof(ChartShapeProperties)); }

 private ChartShapeProperties? _ChartShapeProperties;
}