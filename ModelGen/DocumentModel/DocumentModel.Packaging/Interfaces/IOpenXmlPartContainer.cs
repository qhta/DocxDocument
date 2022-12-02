namespace DocumentModel.Packaging;

/// <summary>
/// Defines the base class for OpenXmlPackage and OpenXmlPart.
/// </summary>
public interface IOpenXmlPartContainer // : 
{
  /// <summary>
  /// Gets all external relationships.
  /// </summary>
  public DocumentModel.Packaging.IReferenceRelationship? ExternalRelationships { get ; set; }
  
  /// <summary>
  /// Gets all hyperlink relationships.
  /// </summary>
  public DocumentModel.Packaging.IHyperlinkRelationship? HyperlinkRelationships { get ; set; }
  
  /// <summary>
  /// Gets all  relationships.
  /// </summary>
  public DocumentModel.Packaging.IReferenceRelationship? DataPartReferenceRelationships { get ; set; }
  
  /// <summary>
  /// Gets all parts which are relationship targets of this part.
  /// </summary>
  public DocumentModel.Packaging.IIdPartPair? Parts { get ; set; }
  
}
