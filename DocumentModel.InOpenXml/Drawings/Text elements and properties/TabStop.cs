namespace DocumentModel.Drawings;
/// <summary>
///   Represents a tab stop in text, including its position and alignment.
/// </summary>
[OpenXmlType(typeof(DXD.TabStop))]
[XmlRoot("TabStop", Namespace = "DocumentModel.Drawings")]
public partial class TabStop : ModelElement<DXD.TabStop>
{
 /// <summary>
 ///   Position of the tab stop.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.TabStop.Position))]
 public Int32? Position { get => _Position; set => UpdateField(ref _Position, value, nameof(Position)); }
 private Int32? _Position;

 /// <summary>
 ///   Alignment type for the tab stop.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.TabStop.Alignment))]
 public TextTabAlignment? Alignment { get => _Alignment; set => UpdateField(ref _Alignment, value, nameof(Alignment)); }
 private TextTabAlignment? _Alignment;
}