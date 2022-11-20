namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Plus.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.INumberLiteral))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.INumberReference))]
public interface IPlus // : DocumentFormat.OpenXml.Drawing.Charts.NumberDataSourceType
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
