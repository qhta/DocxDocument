namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class Stretch
{
  public bool ShouldSerializeFillRectangle() => FillRectangle is not null;
}
