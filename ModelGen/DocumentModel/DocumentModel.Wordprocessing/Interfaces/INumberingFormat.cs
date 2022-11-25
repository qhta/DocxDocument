namespace DocumentModel.Wordprocessing;

/// <summary>
/// Footnote Numbering Format.
/// </summary>
public interface INumberingFormat // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Numbering Format Type
  /// </summary>
  public DocumentModel.Wordprocessing.NumberFormatKind? Val { get ; set; }
  
  /// <summary>
  /// format, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? Format { get ; set; }
  
}
