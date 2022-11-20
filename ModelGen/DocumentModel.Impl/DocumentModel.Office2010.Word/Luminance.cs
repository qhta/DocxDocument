namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the Luminance Class.
/// </summary>
public class Luminance: ILuminance
{
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public int? Val
  {
    get;
    set;
  }
  
}
