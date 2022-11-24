namespace DocumentModel.Office2021.PowerPoint.Comment;

/// <summary>
/// Defines the AuthorList Class.
/// </summary>
public interface IAuthorList // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// Gets the PowerPointAuthorsPart associated with this element.
  /// </summary>
  public PowerPointAuthorsPart? PowerPointAuthorsPart { get ; set; }
  
}
