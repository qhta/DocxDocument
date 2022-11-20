namespace DocumentModel.Office2013.Word;

/// <summary>
/// Defines the Appearance Class.
/// </summary>
public class Appearance: IAppearance
{
  /// <summary>
  /// val, this property is only available in Office 2013 and later.
  /// </summary>
  public SdtAppearance? Val
  {
    get;
    set;
  }
  
}
