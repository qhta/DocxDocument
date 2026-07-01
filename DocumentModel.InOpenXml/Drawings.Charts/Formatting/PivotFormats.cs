namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Pivot chart format persistence data.
/// </summary>
[OpenXmlType(typeof(DXDC.PivotFormats))]
[DataContract]
[XmlRoot("PivotFormats", Namespace = "DocumentModel.Drawings.Charts")]
public class PivotFormats : ModelElementCollection<PivotFormat, DXDC.PivotFormats, DXDC.PivotFormat>
{
}