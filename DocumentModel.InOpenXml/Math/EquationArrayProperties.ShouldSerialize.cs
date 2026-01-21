namespace DocumentModel.Math;

public partial class EquationArrayProperties
{
  public bool ShouldSerializeBaseJustification() => BaseJustification is not null;
  public bool ShouldSerializeMaxDistribution() => MaxDistribution is not null;
  public bool ShouldSerializeObjectDistribution() => ObjectDistribution is not null;
  public bool ShouldSerializeRowSpacing() => RowSpacing is not null;
  public bool ShouldSerializeControlProperties() => ControlProperties is not null;
}
