namespace DocumentModel.InkML;

/// <summary>
/// Defines the SourceProperty Class.
/// </summary>
public interface ISourceProperty // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// name
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// value
  /// </summary>
  public Decimal? Value { get ; set; }
  
  /// <summary>
  /// units
  /// </summary>
  public String? Units { get ; set; }
  
}
