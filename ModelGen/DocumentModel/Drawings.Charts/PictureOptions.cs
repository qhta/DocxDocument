namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the PictureOptions Class.
/// </summary>
public partial class PictureOptions
{
  
  /// <summary>
  ///   Apply To Front.
  /// </summary>
  public DMDC.ApplyToFront? ApplyToFront { get; set; }
  
  
  /// <summary>
  ///   Apply To Sides.
  /// </summary>
  public DMDC.ApplyToSides? ApplyToSides { get; set; }
  
  
  /// <summary>
  ///   Apply to End.
  /// </summary>
  public DMDC.ApplyToEnd? ApplyToEnd { get; set; }
  
  
  /// <summary>
  ///   Picture Format.
  /// </summary>
  public DMDC.PictureFormatKind? PictureFormat { get; set; }
  
  
  /// <summary>
  ///   Picture Stack Unit.
  /// </summary>
  public Double? PictureStackUnit { get; set; }
  
}
