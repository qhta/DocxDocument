namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the ScatterStyle Class.
/// </summary>
public interface IScatterStyle // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Scatter Style Value
  /// </summary>
  public ScatterStyleValues? Val { get ; set; }
  
}
