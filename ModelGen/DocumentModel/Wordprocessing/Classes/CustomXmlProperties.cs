namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of properties which shall be applied to the parent custom XML element.
/// </summary>
public partial class CustomXmlProperties
{
  
  /// <summary>
  ///   Custom XML Element Placeholder Text.
  /// </summary>
  public String? CustomXmlPlaceholder { get; set; }
  
  public ElementCollection<CustomXmlAttribute>? Items { get; set; }
  
}
