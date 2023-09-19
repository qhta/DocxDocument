namespace DocumentModel.Wordprocessing;


/// <summary>
///   Entry Types.
/// </summary>
public partial class DocPartTypes
{
  
  /// <summary>
  ///   Entry Is Of All Types
  /// </summary>
  [Nullable((Byte)2)]
  [SchemaAttr("w:all")]
  public Boolean? All { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.Wordprocessing.DocPartValues>? Items { get; set; }
  
}
