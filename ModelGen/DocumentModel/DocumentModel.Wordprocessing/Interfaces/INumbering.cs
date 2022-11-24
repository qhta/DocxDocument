namespace DocumentModel.Wordprocessing;

/// <summary>
/// Numbering Definitions.
/// </summary>
public interface INumbering // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// Gets the NumberingDefinitionsPart associated with this element.
  /// </summary>
  public INumberingDefinitionsPart? NumberingDefinitionsPart { get ; set; }
  
}
