namespace DocumentModel.Wordprocessing;

/// <summary>
/// Symbol Character.
/// </summary>
public interface ISymbolChar // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Symbol Character Font
  /// </summary>
  public String? Font { get ; set; }
  
  /// <summary>
  /// Symbol Character Code
  /// </summary>
  public IHexBinaryValue? Char { get ; set; }
  
}
