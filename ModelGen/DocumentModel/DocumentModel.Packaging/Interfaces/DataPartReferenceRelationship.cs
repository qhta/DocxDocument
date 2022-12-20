namespace DocumentModel.Packaging;

/// <summary>
/// Represents an internal reference relationship to a DataPart element.
/// </summary>
public partial interface DataPartReferenceRelationship
{
  /// <summary>
  /// Gets the referenced target DataPart.
  /// </summary>
  public DocumentModel.Packaging.DataPart? DataPart { get; set; }
  
}
