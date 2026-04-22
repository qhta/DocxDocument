using DocumentModel.Drawings.Charts;

namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Defines the Statistics Class.
/// </summary>
[OpenXmlType(typeof(DXO16DCD.Statistics))]
[XmlRoot("Statistics", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public class Statistics : ModelElement<DXO16DCD.Statistics>
{
 /// <summary>
 /// Specifies the quartile method.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.Statistics.QuartileMethod))]
 public QuartileMethod? QuartileMethod { get => _QuartileMethod; set => UpdateField(ref _QuartileMethod, value, nameof(QuartileMethod)); }
 private QuartileMethod? _QuartileMethod;
}