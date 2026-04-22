namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Defines the UpDownBarType Class.
/// </summary>
[OpenXmlType(typeof(DXDC.UpDownBarType))]
[XmlRoot("UpDownBarType", Namespace = "DocumentModel.Drawings.Charts")]
public partial class UpDownBarType : ModelElement<DXDC.UpDownBarType>
{
 /// <summary>
 ///   ChartShapeProperties.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.UpDownBarType.ChartShapeProperties))]
 public ChartShapeProperties? ChartShapeProperties { get => _ChartShapeProperties; set => UpdateField(ref _ChartShapeProperties, value, nameof(ChartShapeProperties)); }
 private ChartShapeProperties? _ChartShapeProperties;
}