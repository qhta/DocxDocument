namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP Member Properties.
/// </summary>
public interface MemberProperties // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// OLAP Member Properties Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<MemberProperty>? MemberProperties { get ; set; }
  
}
