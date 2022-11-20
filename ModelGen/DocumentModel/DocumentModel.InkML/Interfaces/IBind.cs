namespace DocumentModel.InkML;

/// <summary>
/// Defines the Bind Class.
/// </summary>
public interface IBind // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// source
  /// </summary>
  public string? Source { get ; set; }
  
  /// <summary>
  /// target
  /// </summary>
  public string? Target { get ; set; }
  
  /// <summary>
  /// column
  /// </summary>
  public string? Column { get ; set; }
  
  /// <summary>
  /// variable
  /// </summary>
  public string? Variable { get ; set; }
  
}
