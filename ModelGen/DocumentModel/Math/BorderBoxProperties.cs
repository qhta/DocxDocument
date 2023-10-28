namespace DocumentModel.Math;


/// <summary>
///   Border Box Properties.
/// </summary>
public partial class BorderBoxProperties
{
  
  /// <summary>
  ///   Hide Top Edge.
  /// </summary>
  public DMM.HideTop? HideTop { get; set; }
  
  
  /// <summary>
  ///   Hide Bottom Edge.
  /// </summary>
  public DMM.HideBottom? HideBottom { get; set; }
  
  
  /// <summary>
  ///   Hide Left Edge.
  /// </summary>
  public DMM.HideLeft? HideLeft { get; set; }
  
  
  /// <summary>
  ///   Hide Right Edge.
  /// </summary>
  public DMM.HideRight? HideRight { get; set; }
  
  
  /// <summary>
  ///   Border Box Strikethrough Horizontal.
  /// </summary>
  public DMM.StrikeHorizontal? StrikeHorizontal { get; set; }
  
  
  /// <summary>
  ///   Border Box Strikethrough Vertical.
  /// </summary>
  public DMM.StrikeVertical? StrikeVertical { get; set; }
  
  
  /// <summary>
  ///   Border Box Strikethrough Bottom-Left to Top-Right.
  /// </summary>
  public DMM.StrikeBottomLeftToTopRight? StrikeBottomLeftToTopRight { get; set; }
  
  
  /// <summary>
  ///   Border Box Strikethrough Top-Left to Bottom-Right.
  /// </summary>
  public DMM.StrikeTopLeftToBottomRight? StrikeTopLeftToBottomRight { get; set; }
  
  
  /// <summary>
  ///   ControlProperties.
  /// </summary>
  public DMM.ControlProperties? ControlProperties { get; set; }
  
}
