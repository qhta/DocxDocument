namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a single column definition in a section of a Wordprocessing document.
/// This class provides properties for column width and spacing before the following column, enabling advanced configuration of multi-column layouts within document sections.
/// </summary>
[OpenXmlType(typeof(DXW.Column))]
public partial class TextColumn : ModelElement<DXW.Column>
{
 /// <summary>
 /// Column width, specifying the width of the column.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Column.Width))]
 public string? Width { get => _Width; set => UpdateField(ref _Width, value, nameof(Width)); }

 private string? _Width;
 /// <summary>
 /// Space before the following column, specifying the spacing between columns.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Column.Space))]
 public string? Space { get => _Space; set => UpdateField(ref _Space, value, nameof(Space)); }

 private string? _Space;
}