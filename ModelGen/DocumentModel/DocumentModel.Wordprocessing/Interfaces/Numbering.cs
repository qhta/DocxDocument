namespace DocumentModel.Wordprocessing;

/// <summary>
/// Numbering Definitions.
/// </summary>
public partial interface Numbering
{
  /// <summary>
  /// Gets the NumberingDefinitionsPart associated with this element.
  /// </summary>
  public DocumentModel.Packaging.NumberingDefinitionsPart? NumberingDefinitionsPart { get; set; }
  
  public Collection<DocumentModel.Wordprocessing.NumberingPictureBullet>? NumberingPictureBullets { get; set; }
  
  public Collection<DocumentModel.Wordprocessing.AbstractNum>? AbstractNums { get; set; }
  
  public Collection<DocumentModel.Wordprocessing.NumberingInstance>? NumberingInstances { get; set; }
  
  public Int32? NumberingIdMacAtCleanup { get; set; }
  
}
