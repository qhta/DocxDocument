namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the PictureOptions Class.
/// </summary>
public interface IPictureOptions // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Apply To Front.
  /// </summary>
  public System.Boolean? ApplyToFront { get ; set; }
  
  /// <summary>
  /// Apply To Sides.
  /// </summary>
  public System.Boolean? ApplyToSides { get ; set; }
  
  /// <summary>
  /// Apply to End.
  /// </summary>
  public System.Boolean? ApplyToEnd { get ; set; }
  
  /// <summary>
  /// Picture Format.
  /// </summary>
  public DocumentModel.Drawing.Charts.PictureFormatKind? PictureFormat { get ; set; }
  
  /// <summary>
  /// Picture Stack Unit.
  /// </summary>
  public System.Double? PictureStackUnit { get ; set; }
  
}
