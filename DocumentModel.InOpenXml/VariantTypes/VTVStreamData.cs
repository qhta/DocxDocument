namespace DocumentModel.VariantTypes;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Binary Versioned Stream.
/// </summary>
public class VTVStreamData: ModelElement
{
  /// <summary>
  ///   VSTREAM Version Attribute
  /// </summary>
  public string? Version { get; set; }
}