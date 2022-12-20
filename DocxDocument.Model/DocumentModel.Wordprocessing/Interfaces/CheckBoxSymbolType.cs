namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CheckBoxSymbolType Class.
/// </summary>
public partial interface CheckBoxSymbolType
{
  /// <summary>
  /// font, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Font { get; set; }
  
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.HexBinary? Val { get; set; }
  
}
