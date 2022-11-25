namespace DocumentModel.Wordprocessing;

/// <summary>
/// Associated Help Text.
/// </summary>
public interface IHelpText // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Help Text Type
  /// </summary>
  public DocumentModel.Wordprocessing.InfoTextKind? Type { get ; set; }
  
  /// <summary>
  /// Help Text Value
  /// </summary>
  public System.String? Val { get ; set; }
  
}
