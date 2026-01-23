namespace DocumentModel.Drawings.Office.OEmbed;
/// <summary>
///   Defines the OEmbedShared Class.
/// </summary>
public partial class OEmbedShared : ModelElement<DXODY21OE.OEmbedShared>
{
    /// <summary>
    ///   srcUrl
    /// </summary>
    public string? SrcUrl { get => _SrcUrl; set => UpdateField(ref _SrcUrl, value, nameof(SrcUrl)); }

    private string? _SrcUrl;
    /// <summary>
    ///   type
    /// </summary>
    public string? Type { get => _Type; set => UpdateField(ref _Type, value, nameof(Type)); }

    private string? _Type;
    /// <summary>
    ///   OfficeArtExtensionList.
    /// </summary>
    public OfficeArtExtensionList? OfficeArtExtensionList { get => _OfficeArtExtensionList; set => UpdateField(ref _OfficeArtExtensionList, value, nameof(OfficeArtExtensionList)); }

    private OfficeArtExtensionList? _OfficeArtExtensionList;
}