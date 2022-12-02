namespace DocumentModel.Drawing;

/// <summary>
/// Space After.
/// </summary>
public interface ISpaceAfter // : DocumentModel.Drawing.ITextSpacingType
{
  public Int32? SpacingPercent { get ; set; }
  
  public Int32? SpacingPoints { get ; set; }
  
}
