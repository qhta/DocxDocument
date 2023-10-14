namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that a gradient fill follows a path versus a linear line.
/// </summary>
public partial class PathShadeProperties
{
  
  /// <summary>
  ///   path, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Wordprocessing.PathShadeTypeKind? Path { get; set; }
  
  
  /// <summary>
  ///   FillToRectangle.
  /// </summary>
  public DocumentModel.Wordprocessing.FillToRectangle? FillToRectangle { get; set; }
  
}
