namespace DocumentModel.Drawings;

/// <summary>
///   Represents a tab stop in text, including its position and alignment.
/// </summary>
[OpenXmlType(typeof(DXD.TabStop))]
[DataContract]
[XmlRoot("TabStop", Namespace = "DocumentModel.Drawings")]
public partial class TabStop: ModelElement<DXD.TabStop>
{
  /// <summary>
  ///   Position of the tab stop.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.TabStop.Position))]
  public EMU? Position
  {
    get => _Position ??= GetProperty<EMU?>(GetUpdatableElement()?.Position);
    set => UpdateField(ref _Position, value, nameof(Position));
  }

  private EMU? _Position;

  /// <summary>
  ///   Alignment type for the tab stop.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.TabStop.Alignment))]
  public TextTabAlignment? Alignment
  {
    get => _Alignment ??= GetProperty<TextTabAlignment?>(GetUpdatableElement()?.Alignment);
    set => UpdateField(ref _Alignment, value, nameof(Alignment));
  }

  private TextTabAlignment? _Alignment;
}