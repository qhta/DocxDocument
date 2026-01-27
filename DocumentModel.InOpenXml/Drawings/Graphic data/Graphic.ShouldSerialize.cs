namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class Graphic
{
  public bool ShouldSerializeGraphicData() => GraphicData is not null;
}
