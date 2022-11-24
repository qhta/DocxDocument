namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the NumberDataType Class.
/// </summary>
public interface INumberDataType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Format Code.
  /// </summary>
  public IFormatCode? FormatCode { get ; set; }
  
  /// <summary>
  /// Point Count.
  /// </summary>
  public IPointCount? PointCount { get ; set; }
  
}
