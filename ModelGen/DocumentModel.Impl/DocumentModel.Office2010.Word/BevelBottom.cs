namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the BevelBottom Class.
/// </summary>
public class BevelBottom: IBevelBottom
{
  /// <summary>
  /// w, this property is only available in Office 2010 and later.
  /// </summary>
  public long? Width
  {
    get;
    set;
  }
  
  /// <summary>
  /// h, this property is only available in Office 2010 and later.
  /// </summary>
  public long? Height
  {
    get;
    set;
  }
  
  /// <summary>
  /// prst, this property is only available in Office 2010 and later.
  /// </summary>
  public BevelPresetTypeValues? PresetProfileType
  {
    get;
    set;
  }
  
}
