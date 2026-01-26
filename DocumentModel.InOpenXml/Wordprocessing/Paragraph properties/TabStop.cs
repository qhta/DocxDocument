namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a custom tab stop in a paragraph for WordprocessingML documents.
/// This class extends <see cref = "CollectionItem"/> and provides properties for tab stop type, leader character, and position, enabling advanced control over tab alignment and formatting within paragraphs.
/// </summary>
[OpenXmlType(typeof(DXW.TabStop))]
public partial class TabStop : ModelElement<DXW.TabStop>
{
 /// <summary>
 /// Type of the tab stop, specifying the alignment (e.g., left, center, right, decimal, bar).
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TabStop.Val))]
 [OpenXmlElement(typeof(DXW.TabStop))]
 public TabStopKind? Val { get => _Val; set => UpdateField(ref _Val, value, nameof(Val)); }

 private TabStopKind? _Val;
 /// <summary>
 /// Leader character for the tab stop, specifying the character used to fill the space advanced by the tab (e.g., dots, dashes, underline).
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TabStop.Leader))]
 [OpenXmlElement(typeof(DXW.TabStop))]
 public TabStopLeaderCharKind? Leader { get => _Leader; set => UpdateField(ref _Leader, value, nameof(Leader)); }

 private TabStopLeaderCharKind? _Leader;
 /// <summary>
 /// Position of the tab stop, specified in twentieths of a point from the paragraph's left margin.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TabStop.Position))]
 [OpenXmlElement(typeof(DXW.TabStop))]
 public Int32? Position { get => _Position; set => UpdateField(ref _Position, value, nameof(Position)); }

 private Int32? _Position;
}