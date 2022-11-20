namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Layout Target.
/// </summary>
public interface ILayoutTarget // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Layout Target Value
  /// </summary>
  public LayoutTargetValues? Val { get ; set; }
  
}
