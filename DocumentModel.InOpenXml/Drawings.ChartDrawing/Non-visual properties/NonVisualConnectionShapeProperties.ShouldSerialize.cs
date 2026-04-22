namespace DocumentModel.Drawings.ChartDrawing;

#pragma warning disable CS1591

public partial class NonVisualConnectionShapeProperties
{
  public bool ShouldSerializeConnectionShapeLocks() => ConnectionShapeLocks is not null;
  public bool ShouldSerializeStartConnection() => StartConnection is not null;
  public bool ShouldSerializeEndConnection() => EndConnection is not null;
}
