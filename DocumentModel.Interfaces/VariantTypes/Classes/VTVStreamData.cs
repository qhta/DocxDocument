namespace DocumentModel.VariantTypes;

/// <summary>
///   Binary Versioned Stream.
/// </summary>
public interface VTVStreamData: IModelElement
{
  /// <summary>
  ///   VSTREAM Version Attribute
  /// </summary>
  public string? Version { get; set; }
}