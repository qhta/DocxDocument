namespace DocumentModel.Office2010.Ink;

/// <summary>
/// Defines the DestinationLink Class.
/// </summary>
public class DestinationLink: IDestinationLink
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
