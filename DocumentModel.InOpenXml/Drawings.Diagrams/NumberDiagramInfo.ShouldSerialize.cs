namespace DocumentModel.Drawings.Diagram1;
#pragma warning disable CS1591
public partial class NumberDiagramInfo
{
  public bool ShouldSerializeLvl() => Lvl is not null;
  public bool ShouldSerializePtType() => PtType is not null;
  public bool ShouldSerializeDiagramAutoBullet() => DiagramAutoBullet is not null;
}
