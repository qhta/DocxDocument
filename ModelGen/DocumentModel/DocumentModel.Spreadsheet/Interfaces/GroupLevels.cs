namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the GroupLevels Class.
/// </summary>
public interface GroupLevels // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Grouping Level Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<GroupLevel>? GroupLevels { get ; set; }
  
}
