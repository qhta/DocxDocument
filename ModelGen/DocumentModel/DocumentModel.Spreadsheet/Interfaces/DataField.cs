namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the DataField Class.
/// </summary>
public interface DataField // : System.Boolean
{
  /// <summary>
  /// isCountDistinct, this property is only available in Office 2013 and later.
  /// </summary>
  public Boolean? IsCountDistinct { get ; set; }
  
}
