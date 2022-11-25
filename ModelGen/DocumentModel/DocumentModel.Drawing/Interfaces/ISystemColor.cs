namespace DocumentModel.Drawing;

/// <summary>
/// System Color.
/// </summary>
public interface ISystemColor // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Value
  /// </summary>
  public DocumentModel.Drawing.SystemColorKind? Val { get ; set; }
  
  /// <summary>
  /// Last Color
  /// </summary>
  public DocumentModel.IHexBinaryValue? LastColor { get ; set; }
  
}
