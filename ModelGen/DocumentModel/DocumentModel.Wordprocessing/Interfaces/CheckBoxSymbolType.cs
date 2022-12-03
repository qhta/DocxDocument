namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CheckBoxSymbolType Class.
/// </summary>
public interface CheckBoxSymbolType // : System.Boolean
{
  /// <summary>
  /// font, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Font { get ; set; }
  
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.HexBinaryValue? Val { get ; set; }
  
}
