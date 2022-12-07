namespace DocumentModel.Drawings;

/// <summary>
/// Data Table.
/// </summary>
public class DataTableImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.DataTable>, DataTable
{
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public ChartShapeProperties? ChartShapeProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Text Properties.
  /// </summary>
  public TextProperties1? TextProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public ExtensionList4? ExtensionList
  {
    get;
    set;
  }
  
}
