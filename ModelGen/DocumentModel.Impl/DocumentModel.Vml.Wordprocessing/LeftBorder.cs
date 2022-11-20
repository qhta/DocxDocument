namespace DocumentModel.Vml.Wordprocessing;

/// <summary>
/// Left Border.
/// </summary>
public class LeftBorder: ILeftBorder
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
