namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP Member Properties.
/// </summary>
public interface IMemberProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// OLAP Member Properties Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<IMemberProperty>? MemberProperties { get ; set; }
  
}
