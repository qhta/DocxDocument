namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the PictureOptions Class.
/// </summary>
public partial class PictureOptions
{
  
  /// <summary>
  ///   Apply To Front.
  /// </summary>
  public DocumentModel.Drawings.Charts.ApplyToFront? ApplyToFront { get; set; }
  
  
  /// <summary>
  ///   Apply To Sides.
  /// </summary>
  public DocumentModel.Drawings.Charts.ApplyToSides? ApplyToSides { get; set; }
  
  
  /// <summary>
  ///   Apply to End.
  /// </summary>
  public DocumentModel.Drawings.Charts.ApplyToEnd? ApplyToEnd { get; set; }
  
  
  /// <summary>
  ///   Picture Format.
  /// </summary>
  public DocumentModel.Drawings.Charts.PictureFormatKind? PictureFormat { get; set; }
  
  
  /// <summary>
  ///   Picture Stack Unit.
  /// </summary>
  public Double? PictureStackUnit { get; set; }
  
}
