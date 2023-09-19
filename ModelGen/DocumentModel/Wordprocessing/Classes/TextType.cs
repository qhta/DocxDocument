namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the TextType Class.
/// </summary>
public partial class TextType
{
  
  /// <summary>
  ///   space
  /// </summary>
  [Nullable((Byte)2)]
  [SchemaAttr("xml:space")]
  public DocumentModel.SpaceProcessingModeValues? Space { get; set; }
  
}
