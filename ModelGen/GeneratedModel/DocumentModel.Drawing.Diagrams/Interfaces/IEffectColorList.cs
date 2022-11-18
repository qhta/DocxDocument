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
public interface IEffectColorList // : DocumentFormat.OpenXml.Drawing.Diagrams.ColorsType
{
  /// <summary>
  /// Color Application Method Type
  /// </summary>
  public ColorApplicationMethod? Method { get ; set; }
  
  /// <summary>
  /// Hue Direction
  /// </summary>
  public HueDirection? HueDirection { get ; set; }
  
}
