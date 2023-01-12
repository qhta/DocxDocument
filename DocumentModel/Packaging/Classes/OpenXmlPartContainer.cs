namespace DocumentModel.Packaging;

/// <summary>
/// Defines the base class for OpenXmlPackage and OpenXmlPart.
/// </summary>
public partial class OpenXmlPartContainer
{
  /// <summary>
  /// Gets all external relationships.
  /// </summary>
  public Collection<DocumentModel.Packaging.ExternalRelationship>? ExternalRelationships { get; set; }
  
  /// <summary>
  /// Gets all hyperlink relationships.
  /// </summary>
  public Collection<DocumentModel.Packaging.HyperlinkRelationship>? HyperlinkRelationships { get; set; }
  
  /// <summary>
  /// Gets all  relationships.
  /// </summary>
  public Collection<DocumentModel.Packaging.DataPartReferenceRelationship>? DataPartReferenceRelationships { get; set; }
  
  /// <summary>
  /// Gets all parts which are relationship targets of this part.
  /// </summary>
  public Collection<DocumentModel.Packaging.IdPartPair>? Parts { get; set; }
  
}
