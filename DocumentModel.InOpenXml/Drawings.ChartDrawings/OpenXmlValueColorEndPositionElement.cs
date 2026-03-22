namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Defines the OpenXmlValueColorEndPositionElement Class.
/// </summary>
[OpenXmlType(typeof(DXO16DCD.OpenXmlValueColorEndPositionElement))]
public class OpenXmlValueColorEndPositionElement: ModelElement<DXO16DCD.OpenXmlValueColorEndPositionElement>
{
  /// <summary>
  /// Specifies the extreme value color position.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.OpenXmlValueColorEndPositionElement.ExtremeValueColorPosition))]
  public bool? ExtremeValueColorPosition
  {
    get => _ExtremeValueColorPosition;
    set => UpdateField(ref _ExtremeValueColorPosition, value, nameof(ExtremeValueColorPosition));
  }
  private bool? _ExtremeValueColorPosition;
  /// <summary>
  /// Specifies the number color position.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.OpenXmlValueColorEndPositionElement.NumberColorPosition))]
  public Double? NumberColorPosition
  {
    get => _NumberColorPosition;
    set => UpdateField(ref _NumberColorPosition, value, nameof(NumberColorPosition));
  }
  private Double? _NumberColorPosition;
  /// <summary>
  /// Specifies the percentage color position.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.OpenXmlValueColorEndPositionElement.PercentageColorPosition))]
  public Double? PercentageColorPosition
  {
    get => _PercentageColorPosition;
    set => UpdateField(ref _PercentageColorPosition, value, nameof(PercentageColorPosition));
  }
  private Double? _PercentageColorPosition;
}