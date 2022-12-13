namespace DocumentModel.Drawings;

/// <summary>
/// Defines the TextSpacingType Class.
/// </summary>
public interface TextSpacingType
{
  /// <summary>
  /// Spacing Percent.
  /// </summary>
  public Int32? SpacingPercent { get ; set; }
  
  /// <summary>
  /// Spacing Points.
  /// </summary>
  public Int32? SpacingPoints { get ; set; }
  
}
