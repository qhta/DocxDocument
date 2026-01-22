namespace DocumentModel.VariantTypes;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Clipboard Data.
/// </summary>
public partial class VTClipboardData : ModelElement
{
    /// <summary>
    ///   Format Attribute
    /// </summary>
    public Int32? Format { get => _Format; set => UpdateField(ref _Format, value, nameof(Format)); }

    private Int32? _Format;
    /// <summary>
    ///   size
    /// </summary>
    public UInt32? Size { get; set; }
}