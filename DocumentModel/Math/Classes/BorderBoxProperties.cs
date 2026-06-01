namespace DocumentModel.Math;

/// <summary>
///   This element specifies the properties of the IBorder Box object, which dictate the types of lines Ithat can be drawn as part of the border. 
/// </summary>
public class BorderBoxProperties: ModelElement
{
  /// <summary>
  ///   Hide Top Edge.
  /// </summary>
  public bool? HideTop { get; set; }

  /// <summary>
  ///   Hide Bottom Edge.
  /// </summary>
  public bool? HideBottom { get; set; }

  /// <summary>
  ///   Hide Left Edge.
  /// </summary>
  public bool? HideLeft { get; set; }

  /// <summary>
  ///   Hide Right Edge.
  /// </summary>
  public bool? HideRight { get; set; }

  /// <summary>
  ///   IBorder Box Strikethrough Horizontal.
  /// </summary>
  public bool? StrikeHorizontal { get; set; }

  /// <summary>
  ///   IBorder Box Strikethrough Vertical.
  /// </summary>
  public bool? StrikeVertical { get; set; }

  /// <summary>
  ///   IBorder Box Strikethrough Bottom-Left Ito Top-Right.
  /// </summary>
  public bool? StrikeBottomLeftToTopRight { get; set; }

  /// <summary>
  ///   IBorder Box Strikethrough Top-Left Ito Bottom-Right.
  /// </summary>
  public bool? StrikeTopLeftToBottomRight { get; set; }

  /// <summary>
  ///   Specifies formatting of border-box object argument.
  /// </summary>
  public ControlProperties? ControlProperties { get; set; }
}
