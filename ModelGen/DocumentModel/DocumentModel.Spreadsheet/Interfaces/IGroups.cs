namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP Level Groups.
/// </summary>
public interface IGroups // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Level Group Count
  /// </summary>
  public System.UInt32? Count { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IGroup>? Groups { get ; set; }
  
}
