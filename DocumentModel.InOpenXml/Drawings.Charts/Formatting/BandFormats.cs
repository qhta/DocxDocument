namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a collection of band formats for a surface chart.
///   Each band format defines the visual appearance of a specific range or band in the chart.
/// </summary>
[OpenXmlType(typeof(DXDC.BandFormats))]
[DataContract]
[XmlRoot("BandFormats", Namespace = "DocumentModel.Drawings.Charts")]
public class BandFormats : ModelElementCollection<BandFormat, DXDC.BandFormats, DXDC.BandFormat>
{
}