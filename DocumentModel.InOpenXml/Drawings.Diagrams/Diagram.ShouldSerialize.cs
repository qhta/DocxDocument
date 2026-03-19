namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class Diagram
{
  public bool ShouldSerializeId() => !String.IsNullOrEmpty(Id);
  public bool ShouldSerializeBuildStep() => BuildStep is not null;
}
