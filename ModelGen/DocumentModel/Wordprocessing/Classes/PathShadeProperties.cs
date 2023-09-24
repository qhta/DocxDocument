namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that a gradient fill follows a path versus a linear line.
/// </summary>
public partial class PathShadeProperties
{
  
  /// <summary>
  ///   path, this property is only available in Office 2010 and later.
  /// </summary>
  public PathShadeTypeKind? Path { get; set; }
  
  
  /// <summary>
  ///   FillToRectangle.
  /// </summary>
  public FillToRectangle? FillToRectangle { get; set; }
  
}
