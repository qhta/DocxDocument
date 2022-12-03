namespace DocumentModel.Spreadsheet;

/// <summary>
/// Field Items.
/// </summary>
public interface Items // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Field Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<Item>? Items { get ; set; }
  
}
