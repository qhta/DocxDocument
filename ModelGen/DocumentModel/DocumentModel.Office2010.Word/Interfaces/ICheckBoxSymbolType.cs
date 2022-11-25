namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the CheckBoxSymbolType Class.
/// </summary>
public interface ICheckBoxSymbolType // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// font, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? Font { get ; set; }
  
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.IHexBinaryValue? Val { get ; set; }
  
}
