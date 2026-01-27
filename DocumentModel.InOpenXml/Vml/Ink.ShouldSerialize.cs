namespace DocumentModel.Vml;

#pragma warning disable CS1591

public partial class Ink
{
  public bool ShouldSerializeInkData() => InkData is not null;
  public bool ShouldSerializeAnnotationFlag() => AnnotationFlag is not null;
}
