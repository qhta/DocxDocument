namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PivotSource Class.
/// </summary>
public class PivotSource2Impl: ModelElementImpl, PivotSource2
{
  public DocumentFormat.OpenXml.Office2013.Drawing.Chart.PivotSource? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.PivotSource?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Pivot Name.
  /// </summary>
  public String? PivotTableName
  {
    get;
    set;
  }
  
  /// <summary>
  /// Format ID.
  /// </summary>
  public UInt32? FormatId
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
