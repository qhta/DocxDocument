namespace DocumentModel.Bibliography;

/// <summary>
/// Inventor.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Bibliography.INameList))]
public interface IInventor // : DocumentFormat.OpenXml.Bibliography.NameType
{
  /// <summary>
  /// Name List.
  /// </summary>
  public INameList? NameList { get ; set; }
  
}
