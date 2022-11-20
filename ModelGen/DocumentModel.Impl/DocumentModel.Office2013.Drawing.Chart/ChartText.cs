namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the ChartText Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IRichText))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IStringLiteral))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IStringReference))]
public class ChartText: IChartText
{
  /// <summary>
  /// String Reference.
  /// </summary>
  public IStringReference? StringReference
  {
    get;
    set;
  }
  
  /// <summary>
  /// Rich Text.
  /// </summary>
  public IRichText? RichText
  {
    get;
    set;
  }
  
  /// <summary>
  /// String Literal.
  /// </summary>
  public IStringLiteral? StringLiteral
  {
    get;
    set;
  }
  
}
