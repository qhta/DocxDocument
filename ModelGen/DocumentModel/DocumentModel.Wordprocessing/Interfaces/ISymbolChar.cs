namespace DocumentModel.Wordprocessing;

/// <summary>
/// Symbol Character.
/// </summary>
public interface ISymbolChar // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Symbol Character Font
  /// </summary>
  public System.String? Font { get ; set; }
  
  /// <summary>
  /// Symbol Character Code
  /// </summary>
  public DocumentModel.IHexBinaryValue? Char { get ; set; }
  
}
