namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PivotSource Class.
/// </summary>
public class PivotSource1Impl: ModelElementImpl, PivotSource1
{
  public DocumentFormat.OpenXml.Drawing.Charts.PivotSource? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.PivotSource?)_OpenXmlElement;
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
