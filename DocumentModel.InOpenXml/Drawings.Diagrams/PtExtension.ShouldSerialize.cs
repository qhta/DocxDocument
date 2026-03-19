namespace DocumentModel.Drawings.Diagrams;

#pragma warning disable CS1591

public partial class PtExtension
{
  public bool ShouldSerializeNonVisualDrawingProperties() => NonVisualDrawingProperties is not null;
}
