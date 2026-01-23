namespace DocumentModel.Drawings.Office;
/// <summary>
///   Defines the DataModelExtensionBlock Class.
/// </summary>
public partial class DataModelExtensionBlock : ModelElement<DXOD.DataModelExtensionBlock>
{
    /// <summary>
    ///   relId
    /// </summary>
    [OpenXmlProperty(nameof(DXOD.DataModelExtensionBlock.RelId))]
    /// <summary>
    ///   relId
    /// </summary>
    [OpenXmlElement(typeof(DXOD.DataModelExtensionBlock))]
    public string? RelId { get => _RelId; set => UpdateField(ref _RelId, value, nameof(RelId)); }

    private string? _RelId;
    /// <summary>
    ///   minVer
    /// </summary>
    [OpenXmlProperty(nameof(DXOD.DataModelExtensionBlock.MinVer))]
    /// <summary>
    ///   minVer
    /// </summary>
    [OpenXmlElement(typeof(DXOD.DataModelExtensionBlock))]
    public string? MinVer { get => _MinVer; set => UpdateField(ref _MinVer, value, nameof(MinVer)); }

    private string? _MinVer;
}