namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Numbering Definitions.
/// </summary>
public class Numbering: ModelElement
{
  /// <summary>
  /// Specifies to a consumer the progress in the last attempt made by the application 
  /// to remove unused abstract numbering definitions from a given document. 
  /// </summary>
  [XmlAttribute] public HexInt? NumberingIdMacAtCleanup { get; set; }


  /// <summary>
  /// Collection of abstract numbering definitions
  /// </summary>
  public Collection<AbstractNum>? AbstractNums { get; set; }

  /// <summary>
  /// Collection of numbering instances definitions
  /// </summary>
  public Collection<NumberingInstance>? NumberingInstances { get; set; }
  
  /// <summary>
  /// Collection of numbering picture bullets
  /// </summary>
  public Collection<NumberingPictureBullet>? NumberingPictureBullets { get; set; }

}