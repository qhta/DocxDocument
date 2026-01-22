namespace DocumentModel.Wordprocessing;
/// <summary>
/// Defines the TableWidth interface. Its Value can be absolute (in twips) or relative (in fiftieth of percent), or "auto" or "nil".
/// The type of the Value is determined with the Type property.
/// This interface is used in multiple measures according to table horizontal dimension.
/// </summary>
public partial class TableWidth : ModelElement<DXW.TableWidth>
{
    /// <summary>
    /// Table width value, which can be absolute (in twips) or relative (in fiftieth of percent).
    /// </summary>
    public Int64 Value { get => _Value; set => UpdateField(ref _Value, value, nameof(Value)); }

    private Int64 _Value;
    /// <summary>
    /// Table width type, determining whether the value is absolute, relative, "auto", or "nil".
    /// </summary>
    public TableWidthUnitType? Type { get; set; }
}