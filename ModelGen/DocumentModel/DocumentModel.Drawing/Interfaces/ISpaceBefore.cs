namespace DocumentModel.Drawing;

/// <summary>
/// Space Before.
/// </summary>
public interface ISpaceBefore // : DocumentModel.Drawing.ITextSpacingType
{
  public Int32? SpacingPercent { get ; set; }
  
  public Int32? SpacingPoints { get ; set; }
  
}
