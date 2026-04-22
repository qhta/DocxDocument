namespace DocumentModel.Drawings.ChartDrawing;

#pragma warning disable CS1591

public partial class MarkerType<T> 
{
  public bool ShouldSerializeXPosition() => !String.IsNullOrEmpty(XPosition);
  public bool ShouldSerializeYPosition() => !String.IsNullOrEmpty(YPosition);
}
