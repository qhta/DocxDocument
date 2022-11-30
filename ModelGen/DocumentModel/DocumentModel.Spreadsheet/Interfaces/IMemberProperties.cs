namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP Member Properties.
/// </summary>
public interface IMemberProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// OLAP Member Properties Count
  /// </summary>
  public System.UInt32? Count { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IMemberProperty>? MemberProperties { get ; set; }
  
}
