namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the PictureOptions Class.
/// </summary>
public interface IPictureOptions // : DocumentModel.ITypedOpenXmlCompositeElement
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
