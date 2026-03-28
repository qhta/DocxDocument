namespace DocumentModel.Drawings.Diagrams;

#pragma warning disable CS1591

public partial class ColorData
{
  public bool ShouldSerializeDataModel() => DataModel is not null;
}
