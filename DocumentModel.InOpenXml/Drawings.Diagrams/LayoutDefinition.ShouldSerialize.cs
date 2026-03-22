namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591
public partial class LayoutDefinition
{
  public bool ShouldSerializeUniqueId() => !String.IsNullOrEmpty(UniqueId);
  public bool ShouldSerializeMinVersion() => !String.IsNullOrEmpty(MinVersion);
  public bool ShouldSerializeDefaultStyle() => !String.IsNullOrEmpty(DefaultStyle);
  public bool ShouldSerializeTitles() => Titles is not null;
  public bool ShouldSerializeDescriptions() => Descriptions is not null;
  public bool ShouldSerializeCategoryList() => CategoryList is not null && CategoryList.Count > 0;
  public bool ShouldSerializeSampleData() => SampleData is not null;
  public bool ShouldSerializeStyleData() => StyleData is not null;
  public bool ShouldSerializeColorData() => ColorData is not null;
  public bool ShouldSerializeLayoutNode() => LayoutNode is not null;
  public bool ShouldSerializeDiagramDefinitionExtensionList() => DiagramDefinitionExtensionList is not null && DiagramDefinitionExtensionList.Count > 0;
}
