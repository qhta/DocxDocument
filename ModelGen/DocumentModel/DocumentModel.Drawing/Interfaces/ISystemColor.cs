namespace DocumentModel.Drawing;

/// <summary>
/// System Color.
/// </summary>
public interface ISystemColor // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Value
  /// </summary>
  public SystemColorValues? Val { get ; set; }
  
  /// <summary>
  /// Last Color
  /// </summary>
  public IHexBinaryValue? LastColor { get ; set; }
  
}
