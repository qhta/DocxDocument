namespace DocumentModel.VariantTypes;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Clipboard Data.
/// </summary>
public class VTClipboardData: ModelElement
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