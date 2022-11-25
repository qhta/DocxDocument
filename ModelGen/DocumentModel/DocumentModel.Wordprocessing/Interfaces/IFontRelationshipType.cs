namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FontRelationshipType Class.
/// </summary>
public interface IFontRelationshipType // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// fontKey
  /// </summary>
  public System.String? FontKey { get ; set; }
  
  /// <summary>
  /// subsetted
  /// </summary>
  public System.Boolean? Subsetted { get ; set; }
  
  /// <summary>
  /// Relationship to Part
  /// </summary>
  public System.String? Id { get ; set; }
  
}
