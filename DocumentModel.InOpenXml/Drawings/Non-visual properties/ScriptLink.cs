namespace DocumentModel.Drawings.Office.ScriptLink;
/// <summary>
///   Defines the ScriptLink Class.
/// </summary>
public partial class ScriptLink : ModelElement<DXOY21SL.ScriptLink>
{
    /// <summary>
    ///   val
    /// </summary>
    [OpenXmlProperty(nameof(DXOY21SL.ScriptLink.Val))]
    /// <summary>
    ///   val
    /// </summary>
    [OpenXmlElement(typeof(DXOY21SL.ScriptLink))]
    public string? Val { get => _Val; set => UpdateField(ref _Val, value, nameof(Val)); }

    private string? _Val;
    /// <summary>
    ///   OfficeArtExtensionList.
    /// </summary>
    [OpenXmlProperty(nameof(DXOY21SL.ScriptLink.OfficeArtExtensionList))]
    /// <summary>
    ///   OfficeArtExtensionList.
    /// </summary>
    [OpenXmlElement(typeof(DXOY21SL.ScriptLink))]
    public OfficeArtExtensionList? OfficeArtExtensionList { get => _OfficeArtExtensionList; set => UpdateField(ref _OfficeArtExtensionList, value, nameof(OfficeArtExtensionList)); }

    private OfficeArtExtensionList? _OfficeArtExtensionList;
}