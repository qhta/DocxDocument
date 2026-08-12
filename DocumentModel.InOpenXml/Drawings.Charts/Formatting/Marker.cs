namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a marker in a chart, typically for line or scatter charts.
///   This class defines the visual appearance, size, and shape properties of the marker.
/// </summary>
[OpenXmlType(typeof(DXDC.Marker))]
[DataContract]
[XmlRoot("Marker", Namespace = "DocumentModel.Drawings.Charts")]
public partial class Marker : ModelElement<DXDC.Marker>
{
 /// <summary>
 ///   Symbol style of the marker.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.Marker.Symbol))]
 public MarkerStyle? Symbol { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

 /// <summary>
 ///   Size of the marker.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.Marker.Size))]
 public Byte? Size { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

 /// <summary>
 ///   Visual and shape properties for the marker.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.Marker.ChartShapeProperties))]
 public ChartShapeProperties? ChartShapeProperties { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

 /// <summary>
 ///   Collection of extension elements for additional marker customization.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.Marker.ExtensionList))]
 public IExtensionList? ExtensionList { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}