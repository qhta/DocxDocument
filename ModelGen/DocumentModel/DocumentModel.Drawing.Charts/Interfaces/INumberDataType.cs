namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the NumberDataType Class.
/// </summary>
public interface INumberDataType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Format Code.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? FormatCode { get ; set; }
  
  /// <summary>
  /// Point Count.
  /// </summary>
  public System.UInt32? PointCount { get ; set; }
  
}
