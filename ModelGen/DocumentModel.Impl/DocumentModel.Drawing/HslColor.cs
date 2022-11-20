namespace DocumentModel.Drawing;

/// <summary>
/// Hue, Saturation, Luminance Color Model.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IHueOffset))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IComplement))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IAlphaOffset))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IGamma))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IGray))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IInverseGamma))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IInverse))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ISaturation))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ISaturationOffset))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ISaturationModulation))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ILuminance))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ILuminanceOffset))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ILuminanceModulation))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IRed))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IRedOffset))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IRedModulation))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IGreen))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IGreenOffset))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IGreenModulation))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IBlue))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IBlueOffset))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IBlueModulation))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IHue))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ITint))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IShade))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IAlpha))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IAlphaModulation))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IHueModulation))]
public class HslColor: IHslColor
{
  /// <summary>
  /// Hue
  /// </summary>
  public int? HueValue
  {
    get;
    set;
  }
  
  /// <summary>
  /// Saturation
  /// </summary>
  public int? SatValue
  {
    get;
    set;
  }
  
  /// <summary>
  /// Luminance
  /// </summary>
  public int? LumValue
  {
    get;
    set;
  }
  
}
