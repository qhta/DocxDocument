namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class TableRow
{
  public bool ShouldSerializeRsidTableRowMarkRevision() => RsidTableRowMarkRevision is not null;
  public bool ShouldSerializeRsidTableRowAddition() => RsidTableRowAddition is not null;
  public bool ShouldSerializeRsidTableRowDeletion() => RsidTableRowDeletion is not null;
  public bool ShouldSerializeRsidTableRowProperties() => RsidTableRowProperties is not null;
  public bool ShouldSerializeParagraphId() => ParagraphId is not null;
  public bool ShouldSerializeTextId() => TextId is not null;
  public bool ShouldSerializeTablePropertyExceptions() => TablePropertyExceptions is not null;
  public bool ShouldSerializeTableRowProperties() => TableRowProperties is not null;
}
