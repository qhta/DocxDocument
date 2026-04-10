namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
/// Collection of <see cref = "DataLabelHidden"/> elements that specify which data labels should be hidden in a chart.
/// </summary>
[XmlRoot("HiddenDataLabels", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public class HiddenDataLabels : ModelElementCollection<DataLabelHidden>
{
}