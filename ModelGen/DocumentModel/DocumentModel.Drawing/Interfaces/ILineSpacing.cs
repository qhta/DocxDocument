namespace DocumentModel.Drawing;

/// <summary>
/// Line Spacing.
/// </summary>
public interface ILineSpacing // : DocumentModel.Drawing.ITextSpacingType
{
  public Int32? SpacingPercent { get ; set; }
  
  public Int32? SpacingPoints { get ; set; }
  
}
