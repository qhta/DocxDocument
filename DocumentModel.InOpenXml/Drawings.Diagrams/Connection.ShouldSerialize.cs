namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591
public partial class Connection
{
  public bool ShouldSerializeModelId() => !String.IsNullOrEmpty(ModelId);
  public bool ShouldSerializeType() => Type is not null;
  public bool ShouldSerializeSourceId() => !String.IsNullOrEmpty(SourceId);
  public bool ShouldSerializeDestinationId() => !String.IsNullOrEmpty(DestinationId);
  public bool ShouldSerializeSourcePosition() => SourcePosition is not null;
  public bool ShouldSerializeDestinationPosition() => DestinationPosition is not null;
  public bool ShouldSerializeParentTransitionId() => !String.IsNullOrEmpty(ParentTransitionId);
  public bool ShouldSerializeSiblingTransitionId() => !String.IsNullOrEmpty(SiblingTransitionId);
  public bool ShouldSerializePresentationId() => !String.IsNullOrEmpty(PresentationId);
  public bool ShouldSerializeExtensionList() => ExtensionList is not null && ExtensionList.Count > 0;
}
