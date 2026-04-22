namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class Text
{
  public bool ShouldSerializeTextData() => TextData is not null;
  public bool ShouldSerializeRichTextBody() => RichTextBody is not null;
}
