namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Justification Class.
/// </summary>
public class Justification: IJustification
{
  /// <summary>
  /// Alignment Type
  /// </summary>
  public DocumentModel.Wordprocessing.JustificationValues? Val
  {
    get;
    set;
  }
  
}
