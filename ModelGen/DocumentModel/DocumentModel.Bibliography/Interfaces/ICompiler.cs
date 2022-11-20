namespace DocumentModel.Bibliography;

/// <summary>
/// Compiler.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Bibliography.INameList))]
public interface ICompiler // : DocumentFormat.OpenXml.Bibliography.NameType
{
  /// <summary>
  /// Name List.
  /// </summary>
  public INameList? NameList { get ; set; }
  
}
