namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class TableRow
{
  public bool ShouldSerializeRsidTableRowMarkRevision() => RsidTableRowMarkRevision is not null && ShouldSerialize(RsidTableRowMarkRevision);
  public bool ShouldSerializeRsidTableRowAddition() => RsidTableRowAddition is not null && ShouldSerialize(RsidTableRowAddition);
  public bool ShouldSerializeRsidTableRowDeletion() => RsidTableRowDeletion is not null && ShouldSerialize(RsidTableRowDeletion);
  public bool ShouldSerializeRsidTableRowProperties() => RsidTableRowProperties is not null && ShouldSerialize(RsidTableRowProperties);
  public bool ShouldSerializeParagraphId() => ParagraphId is not null && ShouldSerialize(ParagraphId);
  public bool ShouldSerializeTextId() => TextId is not null && ShouldSerialize(TextId);
  public bool ShouldSerializeTablePropertyExceptions() => TablePropertyExceptions is not null && ShouldSerialize(TablePropertyExceptions);
  public bool ShouldSerializeTableRowProperties() => TableRowProperties is not null && ShouldSerialize(TableRowProperties);
}
