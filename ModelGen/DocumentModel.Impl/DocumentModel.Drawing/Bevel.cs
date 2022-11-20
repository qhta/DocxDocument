namespace DocumentModel.Drawing;

/// <summary>
/// Bevel.
/// </summary>
public class Bevel: IBevel
{
  /// <summary>
  /// Width
  /// </summary>
  public long? Width
  {
    get;
    set;
  }
  
  /// <summary>
  /// Height
  /// </summary>
  public long? Height
  {
    get;
    set;
  }
  
  /// <summary>
  /// Preset Bevel
  /// </summary>
  public BevelPresetValues? Preset
  {
    get;
    set;
  }
  
}
