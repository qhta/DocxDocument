namespace DocumentModel.Wordprocessing;


/// <summary>
///   Visibility of Annotation Types.
/// </summary>
public partial class RevisionView
{
  
  /// <summary>
  ///   Display Visual Indicator Of Markup Area
  /// </summary>
  [SchemaAttr("w:markup")]
  public Boolean? Markup { get; set; }
  
  
  /// <summary>
  ///   Display Comments
  /// </summary>
  [SchemaAttr("w:comments")]
  public Boolean? Comments { get; set; }
  
  
  /// <summary>
  ///   Display Content Revisions
  /// </summary>
  [SchemaAttr("w:insDel")]
  public Boolean? DisplayRevision { get; set; }
  
  
  /// <summary>
  ///   Display Formatting Revisions
  /// </summary>
  [SchemaAttr("w:formatting")]
  public Boolean? Formatting { get; set; }
  
  
  /// <summary>
  ///   Display Ink Annotations
  /// </summary>
  [SchemaAttr("w:inkAnnotations")]
  public Boolean? InkAnnotations { get; set; }
  
}
