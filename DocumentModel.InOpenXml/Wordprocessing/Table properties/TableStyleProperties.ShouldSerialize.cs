namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class TableStyleProperties
{
  public bool ShouldSerializeType() => Type is not null;
  public bool ShouldSerializeStyleParagraphProperties() => StyleParagraphProperties is not null;
  public bool ShouldSerializeTableStyleRunProperties() => TableStyleRunProperties is not null;
  public bool ShouldSerializeTableStyleConditionalTableProperties() => TableStyleConditionalTableProperties is not null;
  public bool ShouldSerializeTableStyleConditionalRowProperties() => TableStyleConditionalRowProperties is not null;
  public bool ShouldSerializeTableStyleConditionalCellProperties() => TableStyleConditionalCellProperties is not null;
}
