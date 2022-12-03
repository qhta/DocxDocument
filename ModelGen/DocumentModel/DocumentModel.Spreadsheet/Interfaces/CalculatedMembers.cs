namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CalculatedMembers Class.
/// </summary>
public interface CalculatedMembers // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Calculated Members Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<CalculatedMember>? CalculatedMembers { get ; set; }
  
}
