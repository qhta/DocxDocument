namespace DocumentModel.Packaging;

/// <summary>
/// Defines the base class for OpenXmlPackage and OpenXmlPart.
/// </summary>
public partial interface OpenXmlPartContainer
{
  /// <summary>
  /// Gets all external relationships.
  /// </summary>
  public Collection<DocumentModel.Packaging.ExternalRelationship>? ExternalRelationships { get; }
  
  /// <summary>
  /// Gets all hyperlink relationships.
  /// </summary>
  public Collection<DocumentModel.Packaging.HyperlinkRelationship>? HyperlinkRelationships { get; }
  
  /// <summary>
  /// Gets all  relationships.
  /// </summary>
  public Collection<DocumentModel.Packaging.DataPartReferenceRelationship>? DataPartReferenceRelationships { get; }
  
  /// <summary>
  /// Gets all parts which are relationship targets of this part.
  /// </summary>
  public Collection<DocumentModel.Packaging.IdPartPair>? Parts { get; }
  
}
