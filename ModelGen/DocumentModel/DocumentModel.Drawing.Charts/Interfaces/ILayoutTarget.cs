namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Layout Target.
/// </summary>
public interface ILayoutTarget // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Layout Target Value
  /// </summary>
  public LayoutTargetValues? Val { get ; set; }
  
}
