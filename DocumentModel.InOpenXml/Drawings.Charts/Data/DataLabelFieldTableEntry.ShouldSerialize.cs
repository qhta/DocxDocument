namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591
public partial class DataLabelFieldTableEntry
{
  public bool ShouldSerializeTextFieldGuid() => !String.IsNullOrEmpty(TextFieldGuid);
  public bool ShouldSerializeFormula() => !String.IsNullOrEmpty(Formula);
  public bool ShouldSerializeDataLabelFieldTableCache() => DataLabelFieldTableCache is not null;
}
