namespace DocumentModel.Spreadsheet;

/// <summary>
/// Members.
/// </summary>
public interface IMembers // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Item Count
  /// </summary>
  public System.UInt32? Count { get ; set; }
  
  /// <summary>
  /// Hierarchy Level
  /// </summary>
  public System.UInt32? Level { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IMember>? Members { get ; set; }
  
}
