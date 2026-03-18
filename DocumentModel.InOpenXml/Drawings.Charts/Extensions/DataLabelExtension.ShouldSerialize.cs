namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class DataLabelExtension
{
  public bool ShouldSerializeDataLabelFieldTable() => DataLabelFieldTable is not null;
  public bool ShouldSerializeExceptionForSave() => ExceptionForSave is not null;
  public bool ShouldSerializeShowDataLabelsRange() => ShowDataLabelsRange is not null;
  public bool ShouldSerializeShapeProperties() => ShapeProperties is not null;
  public bool ShouldSerializeLayout() => Layout is not null;
}
