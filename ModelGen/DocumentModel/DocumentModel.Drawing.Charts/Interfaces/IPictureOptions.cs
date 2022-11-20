namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the PictureOptions Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IApplyToFront))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IApplyToSides))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IApplyToEnd))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IPictureFormat))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IPictureStackUnit))]
public interface IPictureOptions // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Apply To Front.
  /// </summary>
  public IApplyToFront? ApplyToFront { get ; set; }
  
  /// <summary>
  /// Apply To Sides.
  /// </summary>
  public IApplyToSides? ApplyToSides { get ; set; }
  
  /// <summary>
  /// Apply to End.
  /// </summary>
  public IApplyToEnd? ApplyToEnd { get ; set; }
  
  /// <summary>
  /// Picture Format.
  /// </summary>
  public IPictureFormat? PictureFormat { get ; set; }
  
  /// <summary>
  /// Picture Stack Unit.
  /// </summary>
  public IPictureStackUnit? PictureStackUnit { get ; set; }
  
}
