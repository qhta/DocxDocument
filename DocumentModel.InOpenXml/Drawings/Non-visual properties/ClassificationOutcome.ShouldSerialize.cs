namespace DocumentModel.Drawings;

public partial class ClassificationOutcome
{
  public bool ShouldSerializeClassificationOutcomeType() => ClassificationOutcomeType is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
