namespace DocumentModel.Wordprocessing;

/// <summary>
///   This element specifies the set of properties which shall be applied to the parent custom XML element.
/// </summary>
public class CustomXmlProperties: ElementCollection<CustomXmlAttribute>
{
  /// <summary>
  ///   Specifies the placeholder text which shall be displayed in place of this custom XML element 
  ///   when the contents of this custom XML markup are empty 
  ///   (i.e. there are no runs of text within the current custom XML element).
  /// </summary>
  public string? CustomXmlPlaceholder { get; set; }

}