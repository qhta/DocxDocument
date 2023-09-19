namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of properties which shall be applied to the parent custom XML element.
/// </summary>
public partial class CustomXmlProperties
{
  
  /// <summary>
  ///   Custom XML Element Placeholder Text.
  /// </summary>
  [Nullable((Byte)2)]
  public String? CustomXmlPlaceholder { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.Wordprocessing.CustomXmlAttribute>? Items { get; set; }
  
}
