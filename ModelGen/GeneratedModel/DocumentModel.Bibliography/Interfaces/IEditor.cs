namespace DocumentModel.Bibliography;

/// <summary>
/// Editor.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Bibliography.INameList))]
public interface IEditor // : DocumentFormat.OpenXml.Bibliography.NameType
{
  /// <summary>
  /// Name List.
  /// </summary>
  public INameList? NameList { get ; set; }
  
}
