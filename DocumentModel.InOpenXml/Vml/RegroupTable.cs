namespace DocumentModel.Vml;
/// <summary>
///   Shape Grouping History.
/// </summary>
public partial class RegroupTable : ModelElement<DXVO.RegroupTable>
{
    /// <summary>
    ///   VML Extension Handling Behavior
    /// </summary>
    [OpenXmlProperty(nameof(DXVO.RegroupTable.Extension))]
    public ExtensionHandlingBehaviorKind? Extension { get => _Extension; set => UpdateField(ref _Extension, value, nameof(Extension)); }

    private ExtensionHandlingBehaviorKind? _Extension;
    public Entries? Entries { get => _Entries; set => UpdateField(ref _Entries, value, nameof(Entries)); }

    private Entries? _Entries;
}