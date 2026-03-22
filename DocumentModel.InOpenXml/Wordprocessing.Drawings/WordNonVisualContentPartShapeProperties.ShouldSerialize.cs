namespace DocumentModel.Wordprocessing.Drawings;
#pragma warning disable CS1591
public partial class WordNonVisualContentPartShapeProperties
{
  public bool ShouldSerializeNonVisualDrawingProperties() => NonVisualDrawingProperties is not null;
  public bool ShouldSerializeNonVisualInkContentPartProperties() => NonVisualInkContentPartProperties is not null;
}
