namespace DocumentModel.Drawing;

/// <summary>
/// Line Spacing.
/// </summary>
public interface ILineSpacing // : DocumentModel.Drawing.ITextSpacingType
{
  public System.Int32? SpacingPercent { get ; set; }
  
  public System.Int32? SpacingPoints { get ; set; }
  
}
