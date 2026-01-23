namespace DocumentModel;

public partial class ClassificationLabelList
{
  public bool ShouldSerializeClassificationExtensionList() => ClassificationExtensionList is not null;
}
