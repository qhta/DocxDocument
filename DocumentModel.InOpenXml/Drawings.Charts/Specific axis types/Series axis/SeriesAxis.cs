namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a series axis for a chart, including tick label and mark skipping, and extension list.
/// </summary>
[OpenXmlType(typeof(DXDC.SeriesAxis))]
[DataContract]
[XmlRoot("SeriesAxis", Namespace = "DocumentModel.Drawings.Charts")]
public partial class SeriesAxis : ModelElement<DXDC.SeriesAxis>
{
 /// <summary>
 ///   Number of tick labels to skip on the axis.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.TickLabelSkip))]
 public Int32? TickLabelSkip { get => _TickLabelSkip; set => UpdateField(ref _TickLabelSkip, value, nameof(TickLabelSkip)); }
 private Int32? _TickLabelSkip;

 /// <summary>
 ///   Number of tick marks to skip on the axis.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.TickMarkSkip))]
 public Int32? TickMarkSkip { get => _TickMarkSkip; set => UpdateField(ref _TickMarkSkip, value, nameof(TickMarkSkip)); }
 private Int32? _TickMarkSkip;

 /// <summary>
 ///   Extension list for additional series axis properties.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.SerAxExtensionList))]
 public SerAxExtensionList? SerAxExtensionList { get => _SerAxExtensionList; set => UpdateField(ref _SerAxExtensionList, value, nameof(SerAxExtensionList)); }
 private SerAxExtensionList? _SerAxExtensionList;
}