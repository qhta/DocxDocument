namespace DocumentModel.Drawing;

/// <summary>
/// Space After.
/// </summary>
public interface ISpaceAfter // : DocumentModel.Drawing.ITextSpacingType
{
  public System.Int32? SpacingPercent { get ; set; }
  
  public System.Int32? SpacingPoints { get ; set; }
  
}
