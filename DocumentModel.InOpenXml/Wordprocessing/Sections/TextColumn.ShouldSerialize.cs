namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class TextColumn
{
  public bool ShouldSerializeWidth() => !String.IsNullOrEmpty(Width);
  public bool ShouldSerializeSpace() => !String.IsNullOrEmpty(Space);
}
