namespace DocumentModel;

#pragma warning disable CS1591

public partial class ClassificationLabelList
{
  public bool ShouldSerializeClassificationExtensionList() => ClassificationExtensionList is not null && ShouldSerialize(ClassificationExtensionList);
}
