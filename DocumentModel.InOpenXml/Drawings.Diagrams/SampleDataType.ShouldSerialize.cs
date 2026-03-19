namespace DocumentModel.Drawings.Diagrams;

#pragma warning disable CS1591

public partial class SampleDataType
{
  public bool ShouldSerializeUseDefault() => UseDefault is not null;
  public bool ShouldSerializeDataModel() => DataModel is not null;
}
