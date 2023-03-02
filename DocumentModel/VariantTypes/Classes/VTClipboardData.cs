namespace DocumentModel.VariantTypes;

/// <summary>
///   Clipboard Data.
/// </summary>
public record VTClipboardData
{
  /// <summary>
  ///   Format Attribute
  /// </summary>
  public Int32? Format { get; set; }

  /// <summary>
  ///   size
  /// </summary>
  public UInt32? Size { get; set; }
}