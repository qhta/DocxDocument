namespace DocumentModel.Drawing;

public interface ISpaceBefore // : DocumentFormat.OpenXml.Drawing.TextSpacingType
{
  public ISpacingPercent? SpacingPercent { get ; set; }
  
  public ISpacingPoints? SpacingPoints { get ; set; }
  
}
