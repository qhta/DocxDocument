namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class NumberFormat
{
  public bool ShouldSerializeFormatCode() => !String.IsNullOrEmpty(FormatCode);
  public bool ShouldSerializeSourceLinked() => SourceLinked is not null;
}
