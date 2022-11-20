namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the LuminanceModulation Class.
/// </summary>
public class LuminanceModulation: ILuminanceModulation
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
