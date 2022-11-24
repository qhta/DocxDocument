namespace DocumentModel.Drawing;

/// <summary>
/// Defines the Blip Class.
/// </summary>
public interface IBlip // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Embedded Picture Reference
  /// </summary>
  public String? Embed { get ; set; }
  
  /// <summary>
  /// Linked Picture Reference
  /// </summary>
  public String? Link { get ; set; }
  
  /// <summary>
  /// Compression state for blips.
  /// </summary>
  public BlipCompressionValues? CompressionState { get ; set; }
  
}
