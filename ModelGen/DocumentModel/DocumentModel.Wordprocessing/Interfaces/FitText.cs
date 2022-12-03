namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FitText Class.
/// </summary>
public interface FitText // : System.Boolean
{
  /// <summary>
  /// Value
  /// </summary>
  public UInt32? Val { get ; set; }
  
  /// <summary>
  /// Fit Text Run ID
  /// </summary>
  public Int32? Id { get ; set; }
  
}
