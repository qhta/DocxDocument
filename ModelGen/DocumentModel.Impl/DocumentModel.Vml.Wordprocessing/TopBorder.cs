namespace DocumentModel.Vml.Wordprocessing;

/// <summary>
/// Top Border.
/// </summary>
public class TopBorder: ITopBorder
{
  /// <summary>
  /// Border Style
  /// </summary>
  public DocumentModel.Vml.Wordprocessing.BorderValues? Type
  {
    get;
    set;
  }
  
  /// <summary>
  /// Border Width
  /// </summary>
  public int? Width
  {
    get;
    set;
  }
  
  /// <summary>
  /// Border shadow
  /// </summary>
  public ITrueFalseValue? Shadow
  {
    get;
    set;
  }
  
}
