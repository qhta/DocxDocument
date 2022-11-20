namespace DocumentModel.Wordprocessing;

/// <summary>
/// Add Document Grid Line Pitch To Lines in Table Cells.
/// </summary>
public class AdjustLineHeightInTable: IAdjustLineHeightInTable
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val
  {
    get;
    set;
  }
  
}
