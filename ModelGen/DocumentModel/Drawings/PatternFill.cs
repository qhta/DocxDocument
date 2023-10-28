namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a pattern fill. A repeated pattern is used to fill the object.
/// </summary>
public partial class PatternFill
{
  
  /// <summary>
  ///   Foreground color.
  /// </summary>
  public DMD.ForegroundColor? ForegroundColor { get; set; }
  
  
  /// <summary>
  ///   Background color.
  /// </summary>
  public DMD.BackgroundColor? BackgroundColor { get; set; }
  
}
