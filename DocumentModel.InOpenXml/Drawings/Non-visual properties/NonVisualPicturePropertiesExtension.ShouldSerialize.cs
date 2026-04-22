namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class NonVisualPicturePropertiesExtension
{
  public bool ShouldSerializeCameraTool() => CameraTool is not null;
  public bool ShouldSerializeSignatureLine() => SignatureLine is not null;
  public bool ShouldSerializeObjectProperties() => ObjectProperties is not null;
  public bool ShouldSerializeLiveFeedProperties() => LiveFeedProperties is not null;
  public bool ShouldSerializeUri() => !String.IsNullOrEmpty(Uri);
}
