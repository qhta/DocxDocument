namespace DocumentModel.Packaging;

/// <summary>
///   Defines the base interface for OpenXmlPackage and OpenXmlPart.
/// </summary>
public interface OpenXmlPartContainer: OpenXmlPartCollection<OpenXmlPart>
{
  /// <summary>
  ///   Gets all external relationships.
  /// </summary>
  public ExternalRelationships ExternalRelationships { get; set; }
  /// <summary>
  ///   Gets all hyperlink relationships.
  /// </summary>
  public HyperlinkRelationships HyperlinkRelationships { get; set; }
  /// <summary>
  ///   Gets all  relationships.
  /// </summary>
  public DataPartReferenceRelationships DataPartReferenceRelationships { get; set; }
}