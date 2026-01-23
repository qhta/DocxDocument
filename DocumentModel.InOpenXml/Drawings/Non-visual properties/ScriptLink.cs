namespace DocumentModel.Drawings.Office.ScriptLink;
/// <summary>
///   Defines the ScriptLink Class.
/// </summary>
public partial class ScriptLink : ModelElement<DXOY21SL.ScriptLink>
{
    /// <summary>
    ///   val
    /// </summary>
    public string? Val { get => _Val; set => UpdateField(ref _Val, value, nameof(Val)); }

    private string? _Val;
    /// <summary>
    ///   OfficeArtExtensionList.
    /// </summary>
    public OfficeArtExtensionList? OfficeArtExtensionList { get => _OfficeArtExtensionList; set => UpdateField(ref _OfficeArtExtensionList, value, nameof(OfficeArtExtensionList)); }

    private OfficeArtExtensionList? _OfficeArtExtensionList;
}