namespace DocumentModel.InkML;

/// <summary>
/// Defines the Bind Class.
/// </summary>
public interface IBind // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// source
  /// </summary>
  public System.String? Source { get ; set; }
  
  /// <summary>
  /// target
  /// </summary>
  public System.String? Target { get ; set; }
  
  /// <summary>
  /// column
  /// </summary>
  public System.String? Column { get ; set; }
  
  /// <summary>
  /// variable
  /// </summary>
  public System.String? Variable { get ; set; }
  
}
