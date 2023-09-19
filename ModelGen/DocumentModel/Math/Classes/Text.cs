namespace DocumentModel.Math;


/// <summary>
///   Text.
/// </summary>
public partial class Text
{
  
  /// <summary>
  ///   space
  /// </summary>
  [Nullable((Byte)2)]
  [SchemaAttr("xml:space")]
  public DocumentModel.SpaceProcessingModeValues? Space { get; set; }
  
}
