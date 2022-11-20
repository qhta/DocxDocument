namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the ShadowObscured Class.
/// </summary>
public class ShadowObscured: IShadowObscured
{
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? Val
  {
    get;
    set;
  }
  
}
