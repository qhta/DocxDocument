namespace DocumentModel.Drawings;

/// <summary>
/// Line Spacing.
/// </summary>
public interface LineSpacing // : DocumentModel.Drawings.TextSpacingType
{
  public Int32? SpacingPercent { get ; set; }
  
  public Int32? SpacingPoints { get ; set; }
  
}
