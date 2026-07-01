namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Defines the MaxValueColorEndPosition Class.
/// </summary>
[OpenXmlType(typeof(DXO16DCD.MaxValueColorEndPosition))]
[DataContract]
[XmlRoot("MaxValueColorEndPosition", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public partial class MaxValueColorEndPosition : ModelElement<DXO16DCD.MaxValueColorEndPosition>
{
  /// <summary>
  /// Specifies the extreme value color position.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.MaxValueColorEndPosition.ExtremeValueColorPosition))]
  public bool? ExtremeValueColorPosition { get => _ExtremeValueColorPosition; set => UpdateField(ref _ExtremeValueColorPosition, value, nameof(ExtremeValueColorPosition)); }

  private bool? _ExtremeValueColorPosition;
  /// <summary>
  /// Specifies the number color position.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.MaxValueColorEndPosition.NumberColorPosition))]
  public Double? NumberColorPosition { get => _NumberColorPosition; set => UpdateField(ref _NumberColorPosition, value, nameof(NumberColorPosition)); }

  private Double? _NumberColorPosition;
  /// <summary>
  /// Specifies the percentage color position.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.MaxValueColorEndPosition.PercentageColorPosition))]
  public Double? PercentageColorPosition { get => _PercentageColorPosition; set => UpdateField(ref _PercentageColorPosition, value, nameof(PercentageColorPosition)); }

  private Double? _PercentageColorPosition;
}