namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtContentText Class.
/// </summary>
public class SdtContentText: ISdtContentText
{
  /// <summary>
  /// Allow Soft Line Breaks
  /// </summary>
  public bool? MultiLine
  {
    get;
    set;
  }
  
}
