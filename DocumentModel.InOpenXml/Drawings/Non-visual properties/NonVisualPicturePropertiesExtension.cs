namespace DocumentModel.Drawings;
/// <summary>
///   Defines the NonVisualPicturePropertiesExtension interface.
/// </summary>
public partial class NonVisualPicturePropertiesExtension : ModelElement<DXD.NonVisualPicturePropertiesExtension>, IExtension
{
    public CameraTool? CameraTool { get => _CameraTool; set => UpdateField(ref _CameraTool, value, nameof(CameraTool)); }

    private CameraTool? _CameraTool;
    public SignatureLine? SignatureLine { get; set; }
    public ObjectProperties? ObjectProperties { get; set; }
    public LiveFeedProperties? LiveFeedProperties { get; set; }

    /// <summary>
    /// Gets or sets the URI associated with this instance.
    /// </summary>
    public string? Uri { get; set; }
}