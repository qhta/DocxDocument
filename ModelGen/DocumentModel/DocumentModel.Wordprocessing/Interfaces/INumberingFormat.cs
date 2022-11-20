namespace DocumentModel.Wordprocessing;

/// <summary>
/// Footnote Numbering Format.
/// </summary>
public interface INumberingFormat // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Numbering Format Type
  /// </summary>
  public NumberFormatValues? Val { get ; set; }
  
  /// <summary>
  /// format, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Format { get ; set; }
  
}
