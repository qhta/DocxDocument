namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ChartLinesType Class.
/// </summary>
public class ChartLinesTypeImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.ChartLinesType>, ChartLinesType
{
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public virtual ChartShapeProperties? ChartShapeProperties
  {
    get;
    set;
  }
  
}
