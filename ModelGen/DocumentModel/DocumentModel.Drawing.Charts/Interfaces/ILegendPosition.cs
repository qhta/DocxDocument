namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Legend Position.
/// </summary>
public interface ILegendPosition // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Legend Position Value
  /// </summary>
  public LegendPositionValues? Val { get ; set; }
  
}
