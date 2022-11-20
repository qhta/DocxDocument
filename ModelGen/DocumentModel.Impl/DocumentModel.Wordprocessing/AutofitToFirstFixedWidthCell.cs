namespace DocumentModel.Wordprocessing;

/// <summary>
/// Allow Table Columns To Exceed Preferred Widths of Constituent Cells.
/// </summary>
public class AutofitToFirstFixedWidthCell: IAutofitToFirstFixedWidthCell
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
