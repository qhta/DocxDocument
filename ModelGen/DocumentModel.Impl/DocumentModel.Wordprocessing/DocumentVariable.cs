namespace DocumentModel.Wordprocessing;

/// <summary>
/// Single Document Variable.
/// </summary>
public class DocumentVariable: IDocumentVariable
{
  /// <summary>
  /// Document Variable Name
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// Document Variable Value
  /// </summary>
  public string? Val
  {
    get;
    set;
  }
  
}
