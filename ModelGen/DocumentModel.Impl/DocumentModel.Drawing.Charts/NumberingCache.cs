namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the NumberingCache Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.INumericPoint))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IPointCount))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IFormatCode))]
public class NumberingCache: INumberingCache
{
  /// <summary>
  /// Format Code.
  /// </summary>
  public IFormatCode? FormatCode
  {
    get;
    set;
  }
  
  /// <summary>
  /// Point Count.
  /// </summary>
  public IPointCount? PointCount
  {
    get;
    set;
  }
  
}
