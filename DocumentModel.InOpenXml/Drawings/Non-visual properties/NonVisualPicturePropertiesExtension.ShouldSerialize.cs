namespace DocumentModel.Drawings;

public partial class NonVisualPicturePropertiesExtension
{
  public bool ShouldSerializeCameraTool() => CameraTool is not null;
  public bool ShouldSerializeSignatureLine() => SignatureLine is not null;
  public bool ShouldSerializeObjectProperties() => ObjectProperties is not null;
  public bool ShouldSerializeLiveFeedProperties() => LiveFeedProperties is not null;
  public bool ShouldSerializeUriString() => UriString is not null;
}
