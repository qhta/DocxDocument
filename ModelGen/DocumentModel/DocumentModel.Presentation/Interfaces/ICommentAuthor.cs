namespace DocumentModel.Presentation;

/// <summary>
/// Comment Author.
/// </summary>
public interface ICommentAuthor // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// id
  /// </summary>
  public UInt32? Id { get ; set; }
  
  /// <summary>
  /// name
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// initials
  /// </summary>
  public String? Initials { get ; set; }
  
  /// <summary>
  /// lastIdx
  /// </summary>
  public UInt32? LastIndex { get ; set; }
  
  /// <summary>
  /// clrIdx
  /// </summary>
  public UInt32? ColorIndex { get ; set; }
  
  /// <summary>
  /// CommentAuthorExtensionList.
  /// </summary>
  public ICommentAuthorExtensionList? CommentAuthorExtensionList { get ; set; }
  
}
