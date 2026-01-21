namespace DocumentModel.Vml;

public partial class Ink
{
  public bool ShouldSerializeInkData() => InkData is not null;
  public bool ShouldSerializeAnnotationFlag() => AnnotationFlag is not null;
}
