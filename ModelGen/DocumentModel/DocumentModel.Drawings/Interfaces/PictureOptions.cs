namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PictureOptions Class.
/// </summary>
public interface PictureOptions // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Apply To Front.
  /// </summary>
  public Boolean? ApplyToFront { get ; set; }
  
  /// <summary>
  /// Apply To Sides.
  /// </summary>
  public Boolean? ApplyToSides { get ; set; }
  
  /// <summary>
  /// Apply to End.
  /// </summary>
  public Boolean? ApplyToEnd { get ; set; }
  
  /// <summary>
  /// Picture Format.
  /// </summary>
  public PictureFormatKind? PictureFormat { get ; set; }
  
  /// <summary>
  /// Picture Stack Unit.
  /// </summary>
  public Double? PictureStackUnit { get ; set; }
  
}
