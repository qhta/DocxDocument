namespace DocumentModel.InkML;

/// <summary>
/// Defines the Bind Class.
/// </summary>
public interface IBind // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// source
  /// </summary>
  public String? Source { get ; set; }
  
  /// <summary>
  /// target
  /// </summary>
  public String? Target { get ; set; }
  
  /// <summary>
  /// column
  /// </summary>
  public String? Column { get ; set; }
  
  /// <summary>
  /// variable
  /// </summary>
  public String? Variable { get ; set; }
  
}
