namespace DocumentModel.Office2019.Drawing.Model3D;

/// <summary>
/// Defines the Blip Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IAlphaBiLevel))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IAlphaCeiling))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IAlphaFloor))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IAlphaInverse))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IAlphaModulationEffect))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IAlphaModulationFixed))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IAlphaReplace))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IBiLevel))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IBlipExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IBlur))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IColorChange))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IColorReplacement))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IDuotone))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IFillOverlay))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IGrayscale))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IHsl))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ILuminanceEffect))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ITintEffect))]
public class Blip: IBlip
{
  /// <summary>
  /// Embedded Picture Reference
  /// </summary>
  public string? Embed
  {
    get;
    set;
  }
  
  /// <summary>
  /// Linked Picture Reference
  /// </summary>
  public string? Link
  {
    get;
    set;
  }
  
  /// <summary>
  /// Compression state for blips.
  /// </summary>
  public BlipCompressionValues? CompressionState
  {
    get;
    set;
  }
  
}
