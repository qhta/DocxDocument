namespace DocumentModel.Drawings;

/// <summary>
/// Space After.
/// </summary>
public interface SpaceAfter // : DocumentModel.Drawings.TextSpacingType
{
  public Int32? SpacingPercent { get ; set; }
  
  public Int32? SpacingPoints { get ; set; }
  
}
