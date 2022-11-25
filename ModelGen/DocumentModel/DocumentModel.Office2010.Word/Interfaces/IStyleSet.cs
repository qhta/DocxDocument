namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the StyleSet Class.
/// </summary>
public interface IStyleSet // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public System.UInt32? Id { get ; set; }
  
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Office2010.Word.OnOffKind? Val { get ; set; }
  
}
