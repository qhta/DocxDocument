namespace DocumentModel.Packaging;

/// <summary>
/// Defines the base class for OpenXmlPackage and OpenXmlPart.
/// </summary>
public interface IOpenXmlPartContainer // : 
{
  /// <summary>
  /// Gets the children parts IDictionary.
  /// </summary>
  public DocumentModel.Packaging.IPartDictionary? ChildrenRelationshipParts { get ; set; }
  
  /// <summary>
  /// Gets the ReferenceRelationship list.
  /// </summary>
  public System.Collections.Generic.LinkedList<DocumentModel.Packaging.IReferenceRelationship>? ReferenceRelationshipList { get ; set; }
  
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
  
  /// <summary>
  /// Gets the public OpenXmlPackage instance
  /// </summary>
  public DocumentModel.Packaging.IOpenXmlPackage? InternalOpenXmlPackage { get ; set; }
  
}
