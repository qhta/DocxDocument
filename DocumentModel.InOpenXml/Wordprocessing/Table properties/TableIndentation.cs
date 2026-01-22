namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the indentation settings for a table in a Wordprocessing document.
/// This interface provides properties for specifying the width and unit type of the table's indentation from the leading margin, enabling precise control over table positioning.
/// </summary>
public partial class TableIndentation : ModelElement<DXW.TableIndentation>
{
    /// <summary>
    /// The width of the table indentation, specifying the distance from the leading margin.
    /// </summary>
    public Int32? Width { get => _Width; set => UpdateField(ref _Width, value, nameof(Width)); }

    private Int32? _Width;
    /// <summary>
    /// The unit type for the table indentation width, such as points, percentage, or other supported units.
    /// </summary>
    public TableWidthUnitType? Type { get; set; }
}