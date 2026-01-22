namespace DocumentModel.Drawings;
/// <summary>
///   Represents a miter line join, specifying the miter limit for the join.
/// </summary>
public partial class Miter : ModelElement
{
    /// <summary>
    ///   Miter join limit value.
    /// </summary>
    public Int32? Limit { get => _Limit; set => UpdateField(ref _Limit, value, nameof(Limit)); }

    private Int32? _Limit;
}