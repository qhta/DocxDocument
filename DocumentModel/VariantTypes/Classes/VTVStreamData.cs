namespace DocumentModel.VariantTypes;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Binary Versioned Stream.
/// </summary>
public class VTVStreamData: ModelElement
{
  /// <summary>
  ///   VSTREAM IVersion Attribute
  /// </summary>
  public string? IVersion { get; set; }
}
