namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that the nearest ancestor structured document tag shall be a combo box when displayed in the document.
/// </summary>
public partial class SdtContentComboBox
{
  
  /// <summary>
  ///   Combo Box Last Saved Value
  /// </summary>
  [Nullable((Byte)2)]
  [SchemaAttr("w:lastValue")]
  public String? LastValue { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.Wordprocessing.ListItem>? Items { get; set; }
  
}
