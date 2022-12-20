namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the PictureOptions Class.
/// </summary>
public partial interface PictureOptions
{
  /// <summary>
  /// Apply To Front.
  /// </summary>
  public Boolean? ApplyToFront { get; set; }
  
  /// <summary>
  /// Apply To Sides.
  /// </summary>
  public Boolean? ApplyToSides { get; set; }
  
  /// <summary>
  /// Apply to End.
  /// </summary>
  public Boolean? ApplyToEnd { get; set; }
  
  /// <summary>
  /// Picture Format.
  /// </summary>
  public DocumentModel.Drawings.Charts.PictureFormatKind? PictureFormat { get; set; }
  
  /// <summary>
  /// Picture Stack Unit.
  /// </summary>
  public Double? PictureStackUnit { get; set; }
  
}
