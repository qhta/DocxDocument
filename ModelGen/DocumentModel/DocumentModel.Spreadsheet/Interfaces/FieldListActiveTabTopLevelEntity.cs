namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the FieldListActiveTabTopLevelEntity Class.
/// </summary>
public interface FieldListActiveTabTopLevelEntity // : System.Boolean
{
  /// <summary>
  /// name, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// type, this property is only available in Office 2013 and later.
  /// </summary>
  public UInt32? Type { get ; set; }
  
}
