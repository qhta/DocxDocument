namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Number Literal.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.INumericPoint))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IPointCount))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IFormatCode))]
public interface INumberLiteral // : DocumentFormat.OpenXml.Drawing.Charts.NumberDataType
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
