namespace DocumentModel.Wordprocessing.Drawings;

public partial class WordprocessingGroupType
{
  public bool ShouldSerializeNonVisualDrawingProperties() => NonVisualDrawingProperties is not null;
  public bool ShouldSerializeNonVisualGroupDrawingShapeProperties() => NonVisualGroupDrawingShapeProperties is not null;
  public bool ShouldSerializeGroupShapeProperties() => GroupShapeProperties is not null;
}
