namespace DocumentModel.Drawings;

public partial class NonVisualDrawingPropertiesExtension<T>
{
  public bool ShouldSerializeCompatExtension() => CompatExtension is not null;
  public bool ShouldSerializeBackgroundProperties() => BackgroundProperties is not null;
  public bool ShouldSerializeCreationId() => CreationId is not null;
  public bool ShouldSerializePredecessorDrawingElementReference() => PredecessorDrawingElementReference is not null;
  public bool ShouldSerializeDecorative() => Decorative is not null;
  public bool ShouldSerializeClassificationOutcome() => ClassificationOutcome is not null;
  public bool ShouldSerializeScriptLink() => ScriptLink is not null;
  public bool ShouldSerializeUri() => Uri is not null;
}
