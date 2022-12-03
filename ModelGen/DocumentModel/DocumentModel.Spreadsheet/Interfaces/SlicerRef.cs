namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the SlicerRef Class.
/// </summary>
public interface SlicerRef // : System.Boolean
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Id { get ; set; }
  
}
