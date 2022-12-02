namespace DocumentModel.Packaging;

/// <summary>
/// Defines the base class for OpenXmlPackage and OpenXmlPart.
/// </summary>
public interface IOpenXmlPartContainer // : 
{
  /// <summary>
  /// Gets all external relationships.
  /// </summary>
  public IReferenceRelationship? ExternalRelationships { get ; set; }
  
  /// <summary>
  /// Gets all hyperlink relationships.
  /// </summary>
  public IHyperlinkRelationship? HyperlinkRelationships { get ; set; }
  
  /// <summary>
  /// Gets all  relationships.
  /// </summary>
  public IReferenceRelationship? DataPartReferenceRelationships { get ; set; }
  
  /// <summary>
  /// Gets all parts which are relationship targets of this part.
  /// </summary>
  public IIdPartPair? Parts { get ; set; }
  
}
