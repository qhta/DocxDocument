namespace DocumentModel.Bibliography;

/// <summary>
/// Compiler.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Bibliography.INameList))]
public class Compiler: ICompiler
{
  /// <summary>
  /// Name List.
  /// </summary>
  public INameList? NameList
  {
    get;
    set;
  }
  
}
