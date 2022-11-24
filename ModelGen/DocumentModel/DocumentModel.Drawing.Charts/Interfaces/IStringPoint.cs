namespace DocumentModel.Drawing.Charts;

/// <summary>
/// String Point.
/// </summary>
public interface IStringPoint // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Index
  /// </summary>
  public UInt32? Index { get ; set; }
  
  /// <summary>
  /// Text Value.
  /// </summary>
  public INumericValue? NumericValue { get ; set; }
  
}
