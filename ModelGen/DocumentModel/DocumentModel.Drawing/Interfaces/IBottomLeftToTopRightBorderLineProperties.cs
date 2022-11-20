namespace DocumentModel.Drawing;

/// <summary>
/// Bottom-Left to Top-Right Border Line Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.ICustomDash))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IGradientFill))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IHeadEnd))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ITailEnd))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ILineJoinBevel))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IMiter))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IRound))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ILinePropertiesExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.INoFill))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IPatternFill))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IPresetDash))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ISolidFill))]
public interface IBottomLeftToTopRightBorderLineProperties // : DocumentFormat.OpenXml.Drawing.LinePropertiesType
{
  /// <summary>
  /// line width
  /// </summary>
  public int? Width { get ; set; }
  
  /// <summary>
  /// line cap
  /// </summary>
  public DocumentModel.Drawing.LineCapValues? CapType { get ; set; }
  
  /// <summary>
  /// compound line type
  /// </summary>
  public DocumentModel.Drawing.CompoundLineValues? CompoundLineType { get ; set; }
  
  /// <summary>
  /// pen alignment
  /// </summary>
  public DocumentModel.Drawing.PenAlignmentValues? Alignment { get ; set; }
  
}
