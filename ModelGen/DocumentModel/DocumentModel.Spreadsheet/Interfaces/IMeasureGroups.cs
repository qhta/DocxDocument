namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the MeasureGroups Class.
/// </summary>
public interface IMeasureGroups // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Measure Group Count
  /// </summary>
  public System.UInt32? Count { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IMeasureGroup>? MeasureGroups { get ; set; }
  
}
