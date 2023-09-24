namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the MathControlMoveType Class.
/// </summary>
public partial class MathControlMoveType
{
  
  /// <summary>
  ///   author
  /// </summary>
  public String? Author { get; set; }
  
  
  /// <summary>
  ///   date
  /// </summary>
  public DateTime? Date { get; set; }
  
  
  /// <summary>
  ///   dateUtc, this property is only available in Microsoft365 and later.
  /// </summary>
  public DateTime? DateUtc { get; set; }
  
  
  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  public String? Id { get; set; }
  
}
