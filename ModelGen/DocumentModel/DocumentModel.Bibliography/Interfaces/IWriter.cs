namespace DocumentModel.Bibliography;

/// <summary>
/// Writer.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Bibliography.INameList))]
public interface IWriter // : DocumentFormat.OpenXml.Bibliography.NameType
{
  /// <summary>
  /// Name List.
  /// </summary>
  public INameList? NameList { get ; set; }
  
}
