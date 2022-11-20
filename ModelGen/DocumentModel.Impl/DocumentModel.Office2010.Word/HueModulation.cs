namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the HueModulation Class.
/// </summary>
public class HueModulation: IHueModulation
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
