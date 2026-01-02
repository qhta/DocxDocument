namespace DocumentModel.Drawings;

/// <summary>
///   Defines the TextSpacingType Class.
/// </summary>
public class TextSpacingType: ModelElement
{
  /// <summary>
  ///   Spacing Percent.
  /// </summary>
  public Int32? SpacingPercent { get; set; }
  /// <summary>
  ///   Spacing Points.
  /// </summary>
  public Int32? SpacingPoints { get; set; }
}