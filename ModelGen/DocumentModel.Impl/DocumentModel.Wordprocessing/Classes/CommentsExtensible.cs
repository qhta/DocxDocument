namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CommentsExtensible Class.
/// </summary>
public class CommentsExtensibleImpl: ModelElement<DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentsExtensible>, CommentsExtensible
{
  public ExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
