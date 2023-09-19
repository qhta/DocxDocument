namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that a line join is mitered.
/// </summary>
public partial class LineJoinMiterProperties
{
  
  /// <summary>
  ///   lim, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w14:lim")]
  public Int32? Limit { get; set; }
  
}
