namespace DocumentModel.Math;

/// <summary>
///   Group-Character Properties.
/// </summary>
[OpenXmlType(typeof(DXM.GroupCharProperties))]
[DataContract]
[XmlRoot("GroupCharProperties", Namespace = "DocumentModel.Math")]
public partial class GroupCharProperties: ModelElement<DXM.GroupCharProperties>
{
  /// <summary>
  ///   Group Character (Grouping Character).
  /// </summary>
  [OpenXmlProperty(nameof(DXM.GroupCharProperties.AccentChar))]
  public string? AccentChar
  {
    get => _AccentChar ??= GetProperty<string?>(GetUpdatableElement()?.AccentChar);
    set => UpdateField(ref _AccentChar, value, nameof(AccentChar));
  }

  private string? _AccentChar;

  /// <summary>
  ///   Position (Group Character).
  /// </summary>
  [OpenXmlProperty(nameof(DXM.GroupCharProperties.Position))]
  public VerticalJustification? Position
  {
    get => _Position ??= GetProperty<VerticalJustification?>(GetUpdatableElement()?.Position);
    set => UpdateField(ref _Position, value, nameof(Position));
  }

  private VerticalJustification? _Position;

  /// <summary>
  ///   Vertical Justification.
  /// </summary>
  [OpenXmlProperty(nameof(DXM.GroupCharProperties.VerticalJustification))]
  public VerticalJustification? VerticalJustification
  {
    get => _VerticalJustification ??= GetProperty<VerticalJustification?>(GetUpdatableElement()?.VerticalJustification);
    set => UpdateField(ref _VerticalJustification, value, nameof(VerticalJustification));
  }

  private VerticalJustification? _VerticalJustification;

  /// <summary>
  ///   Specifies formatting of group-char object argument.
  /// </summary>
  [OpenXmlProperty(nameof(DXM.GroupCharProperties.ControlProperties))]
  public ControlProperties? ControlProperties
  {
    get => _ControlProperties ??= GetProperty<ControlProperties?>(GetUpdatableElement()?.ControlProperties);
    set => UpdateField(ref _ControlProperties, value, nameof(ControlProperties));
  }

  private ControlProperties? _ControlProperties;
}