namespace DocumentModel.Drawing;

public interface ISpaceAfter // : DocumentFormat.OpenXml.Drawing.TextSpacingType
{
  public ISpacingPercent? SpacingPercent { get ; set; }

  public ISpacingPoints? SpacingPoints { get ; set; }

}
