namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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