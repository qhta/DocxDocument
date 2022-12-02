namespace DocumentModel.Drawing;

/// <summary>
/// Defines the NumberDataType Class.
/// </summary>
public interface INumberDataType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Format Code.
  /// </summary>
  public String? FormatCode { get ; set; }
  
  /// <summary>
  /// Point Count.
  /// </summary>
  public UInt32? PointCount { get ; set; }
  
}
