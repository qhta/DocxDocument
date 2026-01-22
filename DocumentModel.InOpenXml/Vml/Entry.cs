namespace DocumentModel.Vml;
/// <summary>
///   Regroup Entry.
/// </summary>
public partial class Entry : ModelElement<DXVO.Entry>
{
    /// <summary>
    ///   New Group ID
    /// </summary>
    public Int32? New { get => _New; set => UpdateField(ref _New, value, nameof(New)); }

    private Int32? _New;
    /// <summary>
    ///   Old Group ID
    /// </summary>
    public Int32? Old { get; set; }
}