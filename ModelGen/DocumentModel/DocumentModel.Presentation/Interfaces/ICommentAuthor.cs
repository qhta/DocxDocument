namespace DocumentModel.Presentation;

/// <summary>
/// Comment Author.
/// </summary>
public interface ICommentAuthor // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// id
  /// </summary>
  public System.UInt32? Id { get ; set; }
  
  /// <summary>
  /// name
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// initials
  /// </summary>
  public System.String? Initials { get ; set; }
  
  /// <summary>
  /// lastIdx
  /// </summary>
  public System.UInt32? LastIndex { get ; set; }
  
  /// <summary>
  /// clrIdx
  /// </summary>
  public System.UInt32? ColorIndex { get ; set; }
  
  /// <summary>
  /// CommentAuthorExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? CommentAuthorExtensionList { get ; set; }
  
}
