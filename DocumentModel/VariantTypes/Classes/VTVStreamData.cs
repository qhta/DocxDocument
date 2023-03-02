namespace DocumentModel.VariantTypes;

/// <summary>
///   Binary Versioned Stream.
/// </summary>
public record VTVStreamData
{
  /// <summary>
  ///   VSTREAM Version Attribute
  /// </summary>
  public String? Version { get; set; }
}