namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the presence of a custom XML element around one or more inline level structures (runs, images, fields, etc.) within a paragraph. The attributes on this element shall be used to specify the name and namespace URI of the current custom XML element.
/// </summary>
public partial class CustomXmlRow
{
  public CustomXmlProperties? CustomXmlProperties { get; set; }
  
  public ElementCollection<IModelElement>? Items { get; set; }
  
}
