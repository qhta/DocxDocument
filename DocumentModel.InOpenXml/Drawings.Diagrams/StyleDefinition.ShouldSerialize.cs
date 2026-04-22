namespace DocumentModel.Drawings.Diagrams;

#pragma warning disable CS1591

public partial class StyleDefinition
{
  public bool ShouldSerializeUniqueId() => !String.IsNullOrEmpty(UniqueId);
  public bool ShouldSerializeMinVersion() => !String.IsNullOrEmpty(MinVersion);
  public bool ShouldSerializeStyleDefinitionTitles() => StyleDefinitionTitles is not null;
  public bool ShouldSerializeStyleLabelDescriptions() => StyleLabelDescriptions is not null;
  public bool ShouldSerializeStyleDisplayCategories() => StyleDisplayCategories is not null;
  public bool ShouldSerializeScene3D() => Scene3D is not null;
  public bool ShouldSerializeStyleLabel() => StyleLabel is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
