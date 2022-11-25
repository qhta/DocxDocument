namespace DocumentModel.Drawing.Charts;

/// <summary>
/// String Point.
/// </summary>
public interface IStringPoint // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Index
  /// </summary>
  public System.UInt32? Index { get ; set; }
  
  /// <summary>
  /// Text Value.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? NumericValue { get ; set; }
  
}
