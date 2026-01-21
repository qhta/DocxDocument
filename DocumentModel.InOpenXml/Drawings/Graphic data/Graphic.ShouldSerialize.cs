namespace DocumentModel.Drawings;

public partial class Graphic
{
  public bool ShouldSerializeGraphicData() => GraphicData is not null;
}
