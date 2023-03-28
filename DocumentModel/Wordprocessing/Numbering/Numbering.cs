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
  [XmlContentElement] public AbstractNums? AbstractNums { get; set; }

  /// <summary>
  /// Collection of numbering instances definitions
  /// </summary>
  [XmlContentElement] public NumberingInstances? NumberingInstances { get; set; }
  
  /// <summary>
  /// Collection of numbering picture bullets
  /// </summary>
  [XmlContentElement] public NumberingPictureBullets? NumberingPictureBullets { get; set; }

}