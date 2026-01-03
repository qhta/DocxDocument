namespace DocumentModel.Drawings;

/// <summary>
///   Defines the TextSpacingType interface.
/// </summary>
public interface TextSpacingType: IModelElement
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