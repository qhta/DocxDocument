namespace DocumentModel.Drawings.Diagrams;

#pragma warning disable CS1591

public partial class ColorDefinition
{
  public bool ShouldSerializeUniqueId() => !String.IsNullOrEmpty(UniqueId);
  public bool ShouldSerializeMinVersion() => !String.IsNullOrEmpty(MinVersion);
  public bool ShouldSerializeColorDefinitionTitles() => ColorDefinitionTitles is not null;
  public bool ShouldSerializeColorTransformDescriptions() => ColorTransformDescriptions is not null;
  public bool ShouldSerializeColorTransformCategories() => ColorTransformCategories is not null;
  public bool ShouldSerializeColorTransformStyleLabels() => ColorTransformStyleLabels is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null && ExtensionList.Count > 0;
}
