namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591
public partial class AxisExtension<T>
{
  public bool ShouldSerializeNumberingFormat() => NumberingFormat is not null;
}
