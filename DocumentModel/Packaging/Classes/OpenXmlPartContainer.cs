namespace DocumentModel.Packaging;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the base class for OpenXmlPackage and OpenXmlPart.
/// </summary>
public class OpenXmlPartContainer: ModelElement
{
  /// <summary>
  ///   Gets all external relationships.
  /// </summary>
  public Collection<ExternalRelationship>? ExternalRelationships { get; set; }

  /// <summary>
  ///   Gets all hyperlink relationships.
  /// </summary>
  public Collection<HyperlinkRelationship>? HyperlinkRelationships { get; set; }

  /// <summary>
  ///   Gets all  relationships.
  /// </summary>
  public Collection<DataPartReferenceRelationship>? DataPartReferenceRelationships { get; set; }

  /// <summary>
  ///   Gets all parts which are relationship targets of this part.
  /// </summary>
  public Collection<IdPartPair>? Parts { get; set; }
}