namespace DocumentModel.Office2013.WebExtension;

/// <summary>
/// Defines the Snapshot Class.
/// </summary>
public interface ISnapshot // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Embedded Picture Reference
  /// </summary>
  public System.String? Embed { get ; set; }
  
  /// <summary>
  /// Linked Picture Reference
  /// </summary>
  public System.String? Link { get ; set; }
  
  /// <summary>
  /// Compression state for blips.
  /// </summary>
  public DocumentModel.Drawing.BlipCompressionKind? CompressionState { get ; set; }
  
}
