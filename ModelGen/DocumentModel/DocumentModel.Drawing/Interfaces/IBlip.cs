namespace DocumentModel.Drawing;

/// <summary>
/// Defines the Blip Class.
/// </summary>
public interface IBlip // : DocumentModel.ITypedOpenXmlCompositeElement
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
