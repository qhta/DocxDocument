namespace DocumentModel.Math;


/// <summary>
///   Border Box Properties.
/// </summary>
public partial class BorderBoxProperties
{
  
  /// <summary>
  ///   Hide Top Edge.
  /// </summary>
  public Boolean? HideTop { get; set; }
  
  
  /// <summary>
  ///   Hide Bottom Edge.
  /// </summary>
  public Boolean? HideBottom { get; set; }
  
  
  /// <summary>
  ///   Hide Left Edge.
  /// </summary>
  public Boolean? HideLeft { get; set; }
  
  
  /// <summary>
  ///   Hide Right Edge.
  /// </summary>
  public Boolean? HideRight { get; set; }
  
  
  /// <summary>
  ///   Border Box Strikethrough Horizontal.
  /// </summary>
  public Boolean? StrikeHorizontal { get; set; }
  
  
  /// <summary>
  ///   Border Box Strikethrough Vertical.
  /// </summary>
  public Boolean? StrikeVertical { get; set; }
  
  
  /// <summary>
  ///   Border Box Strikethrough Bottom-Left to Top-Right.
  /// </summary>
  public Boolean? StrikeBottomLeftToTopRight { get; set; }
  
  
  /// <summary>
  ///   Border Box Strikethrough Top-Left to Bottom-Right.
  /// </summary>
  public Boolean? StrikeTopLeftToBottomRight { get; set; }
  
  
  /// <summary>
  ///   ControlProperties.
  /// </summary>
  public ControlProperties? ControlProperties { get; set; }
  
}
