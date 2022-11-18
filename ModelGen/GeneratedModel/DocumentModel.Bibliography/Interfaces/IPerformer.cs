namespace DocumentModel.Bibliography;

/// <summary>
/// Performer.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Bibliography.INameList))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.ICorporate))]
public interface IPerformer // : DocumentFormat.OpenXml.Bibliography.NameOrCorporateType
{
  /// <summary>
  /// NameList.
  /// </summary>
  public INameList? NameList { get ; set; }
  
  /// <summary>
  /// Corporate Author.
  /// </summary>
  public ICorporate? Corporate { get ; set; }
  
}
