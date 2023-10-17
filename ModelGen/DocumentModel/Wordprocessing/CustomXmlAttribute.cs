namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a custom XML attribute which shall be located on the parent custom XML element specified via the customXml element. The uri attribute can specify the Namespace of the custom XML attribute, and the name attribute shall specify the local name of the custom XML attribute. For any set of sibling attr elements, all the pairs of Namespace and local name shall be distinct.
/// </summary>
public partial class CustomXmlAttribute
{
  
  /// <summary>
  ///   uri
  /// </summary>
  public String? Uri { get; set; }
  
  
  /// <summary>
  ///   name
  /// </summary>
  public String? Name { get; set; }
  
  
  /// <summary>
  ///   val
  /// </summary>
  public String? Val { get; set; }
  
}
