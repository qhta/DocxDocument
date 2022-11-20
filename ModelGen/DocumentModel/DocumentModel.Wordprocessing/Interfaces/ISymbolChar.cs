namespace DocumentModel.Wordprocessing;

/// <summary>
/// Symbol Character.
/// </summary>
public interface ISymbolChar // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Symbol Character Font
  /// </summary>
  public string? Font { get ; set; }
  
  /// <summary>
  /// Symbol Character Code
  /// </summary>
  public IHexBinaryValue? Char { get ; set; }
  
}
