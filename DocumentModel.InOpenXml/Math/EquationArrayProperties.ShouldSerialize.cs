namespace DocumentModel.Math;

#pragma warning disable CS1591

public partial class EquationArrayProperties
{
  public bool ShouldSerializeBaseJustification() => BaseJustification is not null;
  public bool ShouldSerializeMaxDistribution() => MaxDistribution is not null;
  public bool ShouldSerializeObjectDistribution() => ObjectDistribution is not null;
  public bool ShouldSerializeRowSpacing() => RowSpacing is not null;
  public bool ShouldSerializeControlProperties() => ControlProperties is not null;
}
