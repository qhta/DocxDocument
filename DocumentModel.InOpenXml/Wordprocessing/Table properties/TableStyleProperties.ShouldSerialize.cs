namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class TableStyleProperties
{
  public bool ShouldSerializeType() => Type is not null && ShouldSerialize(Type);
  public bool ShouldSerializeStyleParagraphProperties() => StyleParagraphProperties is not null && ShouldSerialize(StyleParagraphProperties);
  public bool ShouldSerializeTableStyleRunProperties() => TableStyleRunProperties is not null && ShouldSerialize(TableStyleRunProperties);
  public bool ShouldSerializeTableStyleConditionalTableProperties() => TableStyleConditionalTableProperties is not null && ShouldSerialize(TableStyleConditionalTableProperties);
  public bool ShouldSerializeTableStyleConditionalRowProperties() => TableStyleConditionalRowProperties is not null && ShouldSerialize(TableStyleConditionalRowProperties);
  public bool ShouldSerializeTableStyleConditionalCellProperties() => TableStyleConditionalCellProperties is not null && ShouldSerialize(TableStyleConditionalCellProperties);
}
