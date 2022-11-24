namespace DocumentModel.Wordprocessing;

/// <summary>
/// Inline Embedded Object.
/// </summary>
public interface IEmbeddedObject // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// dxaOrig
  /// </summary>
  public String? DxaOriginal { get ; set; }
  
  /// <summary>
  /// dyaOrig
  /// </summary>
  public String? DyaOriginal { get ; set; }
  
  /// <summary>
  /// anchorId, this property is only available in Office 2010 and later.
  /// </summary>
  public IHexBinaryValue? AnchorId { get ; set; }
  
}
