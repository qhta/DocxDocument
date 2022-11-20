namespace DocumentModel.Drawing;

/// <summary>
/// Preset geometry.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IAdjustValueList))]
public class PresetGeometry: IPresetGeometry
{
  /// <summary>
  /// Preset Shape
  /// </summary>
  public ShapeTypeValues? Preset
  {
    get;
    set;
  }
  
  /// <summary>
  /// List of Shape Adjust Values.
  /// </summary>
  public IAdjustValueList? AdjustValueList
  {
    get;
    set;
  }
  
}
