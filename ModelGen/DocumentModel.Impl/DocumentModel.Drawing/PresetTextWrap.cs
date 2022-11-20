namespace DocumentModel.Drawing;

/// <summary>
/// Preset Text Warp.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IAdjustValueList))]
public class PresetTextWrap: IPresetTextWrap
{
  /// <summary>
  /// Preset Warp Shape
  /// </summary>
  public TextShapeValues? Preset
  {
    get;
    set;
  }
  
  /// <summary>
  /// Adjust Value List.
  /// </summary>
  public IAdjustValueList? AdjustValueList
  {
    get;
    set;
  }
  
}
