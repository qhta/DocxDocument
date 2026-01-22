namespace DocumentModel.Drawings.Office;
/// <summary>
///   Defines the DataModelExtensionBlock Class.
/// </summary>
public partial class DataModelExtensionBlock : ModelElement<DXOD.DataModelExtensionBlock>
{
    /// <summary>
    ///   relId
    /// </summary>
    public string? RelId { get => _RelId; set => UpdateField(ref _RelId, value, nameof(RelId)); }

    private string? _RelId;
    /// <summary>
    ///   minVer
    /// </summary>
    public string? MinVer { get; set; }
}