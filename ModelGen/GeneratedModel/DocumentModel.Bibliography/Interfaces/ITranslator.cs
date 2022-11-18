namespace DocumentModel.Bibliography;

/// <summary>
/// Translator.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Bibliography.INameList))]
public interface ITranslator // : DocumentFormat.OpenXml.Bibliography.NameType
{
  /// <summary>
  /// Name List.
  /// </summary>
  public INameList? NameList { get ; set; }
  
}
