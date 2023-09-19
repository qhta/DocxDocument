namespace DocumentModel.Packaging;


/// <summary>
///   Defines the base class for OpenXmlPackage and OpenXmlPart.
/// </summary>
public partial class OpenXmlPartContainer
{
  
  /// <summary>
  ///   Gets all external relationships.
  ///               Hyperlink relationships are not included, use HyperlinkRelationship property to enumerate hyperlink relationships.
  /// </summary>
  public Collection? ExternalRelationships { get; set; }
  
  
  /// <summary>
  ///   Gets all hyperlink relationships.
  /// </summary>
  public Collection? HyperlinkRelationships { get; set; }
  
  public Collection? DataPartReferenceRelationships { get; set; }
  
  
  /// <summary>
  ///   Gets all parts which are relationship targets of this part.
  /// </summary>
  public Collection? Parts { get; set; }
  
}
