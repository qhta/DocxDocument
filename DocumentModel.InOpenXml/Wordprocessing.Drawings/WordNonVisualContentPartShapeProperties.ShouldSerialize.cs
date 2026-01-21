namespace DocumentModel.Wordprocessing.Drawings;

public partial class WordNonVisualContentPartShapeProperties
{
  public bool ShouldSerializeNonVisualDrawingProperties() => NonVisualDrawingProperties is not null;
  public bool ShouldSerializeNonVisualInkContentPartProperties() => NonVisualInkContentPartProperties is not null;
}
