namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Defines the ValueColorMiddlePosition Class.
/// </summary>
[OpenXmlType(typeof(DXO16DCD.ValueColorMiddlePosition))]
[DataContract]
[XmlRoot("ValueColorMiddlePosition", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public partial class ValueColorMiddlePosition : ModelElement<DXO16DCD.ValueColorMiddlePosition>
{
  /// <summary>
  /// Specifies the number color position.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.ValueColorMiddlePosition.NumberColorPosition))]
  public Double? NumberColorPosition { get => _NumberColorPosition; set => UpdateField(ref _NumberColorPosition, value, nameof(NumberColorPosition)); }

  private Double? _NumberColorPosition;
  /// <summary>
  /// Specifies the percentage color position.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.ValueColorMiddlePosition.PercentageColorPosition))]
  public Double? PercentageColorPosition { get => _PercentageColorPosition; set => UpdateField(ref _PercentageColorPosition, value, nameof(PercentageColorPosition)); }

  private Double? _PercentageColorPosition;
}