namespace DocumentModel.Packaging;

/// <summary>
/// Defines the base class for OpenXmlPackage and OpenXmlPart.
/// </summary>
public interface OpenXmlPartContainer
{
  /// <summary>
  /// Gets all external relationships.
  /// </summary>
  public DocumentModel.Packaging.ReferenceRelationship? ExternalRelationships { get ; set; }
  
  /// <summary>
  /// Gets all hyperlink relationships.
  /// </summary>
  public DocumentModel.Packaging.HyperlinkRelationship? HyperlinkRelationships { get ; set; }
  
  /// <summary>
  /// Gets all  relationships.
  /// </summary>
  public DocumentModel.Packaging.ReferenceRelationship? DataPartReferenceRelationships { get ; set; }
  
  /// <summary>
  /// Gets all parts which are relationship targets of this part.
  /// </summary>
  public DocumentModel.Packaging.IdPartPair? Parts { get ; set; }
  
}
