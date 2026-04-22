namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class Numbering
{
  public bool ShouldSerializeLastRevAbstractNumbering() => LastRevAbstractNumbering is not null;
}
