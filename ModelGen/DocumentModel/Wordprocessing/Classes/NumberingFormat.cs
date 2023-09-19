namespace DocumentModel.Wordprocessing;


/// <summary>
///   Footnote Numbering Format.
/// </summary>
public partial class NumberingFormat
{
  
  /// <summary>
  ///   Numbering Format Type
  /// </summary>
  [SchemaAttr("w:val")]
  public DocumentModel.Wordprocessing.NumberFormatValues? Val { get; set; }
  
  
  /// <summary>
  ///   format, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w:format")]
  public String? Format { get; set; }
  
}
