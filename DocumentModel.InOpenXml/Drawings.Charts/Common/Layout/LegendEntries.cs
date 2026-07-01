namespace DocumentModel.Drawings.Charts;
/// <summary>
/// Collection of legend entries representing individual series or data points in a chart legend.
/// </summary>
[DataContract]
[XmlRoot("LegendEntries", Namespace = "DocumentModel.Drawings.Charts")]
public class LegendEntries : ModelElementCollection<LegendEntry>
{
}