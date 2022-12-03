namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NumberDataType Class.
/// </summary>
public interface NumberDataType // : DocumentModel.BaseTypes.ModelElement
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
