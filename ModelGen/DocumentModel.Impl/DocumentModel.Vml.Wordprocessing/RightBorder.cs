namespace DocumentModel.Vml.Wordprocessing;

/// <summary>
/// Right Border.
/// </summary>
public class RightBorder: IRightBorder
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
