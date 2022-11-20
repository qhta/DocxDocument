namespace DocumentModel.Office2010.Ink;

/// <summary>
/// Defines the SourceLink Class.
/// </summary>
public class SourceLink: ISourceLink
{
  /// <summary>
  /// direction
  /// </summary>
  public LinkDirectionValues? Direction
  {
    get;
    set;
  }
  
  /// <summary>
  /// ref
  /// </summary>
  public string? Reference
  {
    get;
    set;
  }
  
}
