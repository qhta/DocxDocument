namespace DocumentModel.Wordprocessing.Drawings;

#pragma warning disable CS1591

public partial class WordprocessingGroupType<T> 
{
  public bool ShouldSerializeNonVisualDrawingProperties() => NonVisualDrawingProperties is not null;
  public bool ShouldSerializeNonVisualGroupDrawingShapeProperties() => NonVisualGroupDrawingShapeProperties is not null;
  public bool ShouldSerializeGroupShapeProperties() => GroupShapeProperties is not null;
}
