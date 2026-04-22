namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class NumberingFormat<T> 
{
  public bool ShouldSerializeFormatCode() => !String.IsNullOrEmpty(FormatCode);
  public bool ShouldSerializeSourceLinked() => SourceLinked is not null;
}
