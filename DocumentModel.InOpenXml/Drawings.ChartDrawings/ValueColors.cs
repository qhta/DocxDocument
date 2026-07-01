namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Defines the ValueColors Class.
/// </summary>
[OpenXmlType(typeof(DXO16DCD.ValueColors))]
[DataContract]
[XmlRoot("ValueColors", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public partial class ValueColors : ModelElement<DXO16DCD.ValueColors>
{
  /// <summary>
  /// Specifies the min color solid color fill properties.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.ValueColors.MinColorSolidColorFillProperties))]
  public SolidColorFillProperties? MinColorSolidColorFillProperties { get => _MinColorSolidColorFillProperties; set => UpdateField(ref _MinColorSolidColorFillProperties, value, nameof(MinColorSolidColorFillProperties)); }

  private SolidColorFillProperties? _MinColorSolidColorFillProperties;
  /// <summary>
  /// Specifies the mid color solid color fill properties.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.ValueColors.MidColorSolidColorFillProperties))]
  public SolidColorFillProperties? MidColorSolidColorFillProperties { get => _MidColorSolidColorFillProperties; set => UpdateField(ref _MidColorSolidColorFillProperties, value, nameof(MidColorSolidColorFillProperties)); }

  private SolidColorFillProperties? _MidColorSolidColorFillProperties;
  /// <summary>
  /// Specifies the max color solid color fill properties.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.ValueColors.MaxColorSolidColorFillProperties))]
  public SolidColorFillProperties? MaxColorSolidColorFillProperties { get => _MaxColorSolidColorFillProperties; set => UpdateField(ref _MaxColorSolidColorFillProperties, value, nameof(MaxColorSolidColorFillProperties)); }

  private SolidColorFillProperties? _MaxColorSolidColorFillProperties;
}