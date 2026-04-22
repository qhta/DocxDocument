namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class Binning
{
  public bool ShouldSerializeIntervalClosed() => IntervalClosed is not null;
  public bool ShouldSerializeUnderflow() => !String.IsNullOrEmpty(Underflow);
  public bool ShouldSerializeOverflow() => !String.IsNullOrEmpty(Overflow);
  public bool ShouldSerializeXsddouble() => !String.IsNullOrEmpty(Xsddouble);
  public bool ShouldSerializeBinCountXsdunsignedInt() => !String.IsNullOrEmpty(BinCountXsdunsignedInt);
}
