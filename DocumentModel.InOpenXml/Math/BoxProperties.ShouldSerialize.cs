namespace DocumentModel.Math;

public partial class BoxProperties
{
  public bool ShouldSerializeOperatorEmulator() => OperatorEmulator is not null;
  public bool ShouldSerializeNoBreak() => NoBreak is not null;
  public bool ShouldSerializeDifferential() => Differential is not null;
  public bool ShouldSerializeBreak() => Break is not null;
  public bool ShouldSerializeAlignment() => Alignment is not null;
  public bool ShouldSerializeControlProperties() => ControlProperties is not null;
}
