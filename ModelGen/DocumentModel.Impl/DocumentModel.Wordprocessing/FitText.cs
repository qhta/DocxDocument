namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FitText Class.
/// </summary>
public class FitText: IFitText
{
  /// <summary>
  /// Value
  /// </summary>
  public uint? Val
  {
    get;
    set;
  }
  
  /// <summary>
  /// Fit Text Run ID
  /// </summary>
  public int? Id
  {
    get;
    set;
  }
  
}
