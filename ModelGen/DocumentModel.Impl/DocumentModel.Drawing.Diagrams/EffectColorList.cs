namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Effect Color List.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IHslColor))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IPresetColor))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ISchemeColor))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IRgbColorModelPercentage))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IRgbColorModelHex))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ISystemColor))]
public class EffectColorList: IEffectColorList
{
  /// <summary>
  /// Color Application Method Type
  /// </summary>
  public ColorApplicationMethodValues? Method
  {
    get;
    set;
  }
  
  /// <summary>
  /// Hue Direction
  /// </summary>
  public HueDirectionValues? HueDirection
  {
    get;
    set;
  }
  
}
