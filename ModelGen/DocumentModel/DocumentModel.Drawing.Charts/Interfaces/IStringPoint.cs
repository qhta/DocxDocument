namespace DocumentModel.Drawing.Charts;

/// <summary>
/// String Point.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.INumericValue))]
public interface IStringPoint // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Index
  /// </summary>
  public uint? Index { get ; set; }
  
  /// <summary>
  /// Text Value.
  /// </summary>
  public DocumentModel.Drawing.Charts.INumericValue? NumericValue { get ; set; }
  
}
