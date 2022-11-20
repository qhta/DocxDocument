namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the ScatterStyle Class.
/// </summary>
public interface IScatterStyle // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Scatter Style Value
  /// </summary>
  public ScatterStyleValues? Val { get ; set; }
  
}
