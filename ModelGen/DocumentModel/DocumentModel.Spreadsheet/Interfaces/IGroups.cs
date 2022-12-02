namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP Level Groups.
/// </summary>
public interface IGroups // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Level Group Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<IGroup>? Groups { get ; set; }
  
}
