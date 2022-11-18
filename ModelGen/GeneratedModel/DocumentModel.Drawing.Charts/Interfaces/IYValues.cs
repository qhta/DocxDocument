namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the YValues Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.INumberLiteral))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.INumberReference))]
public interface IYValues // : DocumentFormat.OpenXml.Drawing.Charts.NumberDataSourceType
{
  /// <summary>
  /// Number Reference.
  /// </summary>
  public INumberReference? NumberReference { get ; set; }
  
  /// <summary>
  /// Number Literal.
  /// </summary>
  public INumberLiteral? NumberLiteral { get ; set; }
  
}
