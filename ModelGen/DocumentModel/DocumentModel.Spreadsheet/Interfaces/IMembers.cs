namespace DocumentModel.Spreadsheet;

/// <summary>
/// Members.
/// </summary>
public interface IMembers // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Item Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  /// <summary>
  /// Hierarchy Level
  /// </summary>
  public UInt32? Level { get ; set; }
  
  public Collection<IMember>? Members { get ; set; }
  
}
