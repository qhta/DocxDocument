namespace DocumentModel.Presentation;

/// <summary>
/// Character Range.
/// </summary>
public class CharRange: ICharRange
{
  /// <summary>
  /// Start
  /// </summary>
  public uint? Start
  {
    get;
    set;
  }
  
  /// <summary>
  /// End
  /// </summary>
  public uint? End
  {
    get;
    set;
  }
  
}
