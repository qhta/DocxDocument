namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Emphasis Class.
/// </summary>
public class Emphasis: IEmphasis
{
  /// <summary>
  /// Emphasis Mark Type
  /// </summary>
  public EmphasisMarkValues? Val
  {
    get;
    set;
  }
  
}
