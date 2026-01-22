namespace DocumentModel.VariantTypes;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Binary Versioned Stream.
/// </summary>
public partial class VTVStreamData : ModelElement
{
    /// <summary>
    ///   VSTREAM Version Attribute
    /// </summary>
    public string? Version { get => _Version; set => UpdateField(ref _Version, value, nameof(Version)); }

    private string? _Version;
}