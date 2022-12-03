namespace DocumentModel.Wordprocessing;

/// <summary>
/// Single Column Definition.
/// </summary>
public interface Column // : System.Boolean
{
  /// <summary>
  /// Column Width
  /// </summary>
  public String? Width { get ; set; }
  
  /// <summary>
  /// Space Before Following Column
  /// </summary>
  public String? Space { get ; set; }
  
}
