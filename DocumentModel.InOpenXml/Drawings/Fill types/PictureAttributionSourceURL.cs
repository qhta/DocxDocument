namespace DocumentModel.Drawings;
/// <summary>
///   Represents a picture attribution source URL, providing an identifier for the attribution source.
/// </summary>
public partial class PictureAttributionSourceURL : ModelElement<DXO19D.PictureAttributionSourceURL>
{
    /// <summary>
    ///   Identifier for the picture attribution source.
    /// </summary>
    [OpenXmlProperty(nameof(DXO19D.PictureAttributionSourceURL.Id))]
    public string? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

    private string? _Id;
}