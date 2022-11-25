namespace DocumentModel.InkML;

/// <summary>
/// Defines the SourceProperty Class.
/// </summary>
public interface ISourceProperty // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// name
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// value
  /// </summary>
  public System.Decimal? Value { get ; set; }
  
  /// <summary>
  /// units
  /// </summary>
  public System.String? Units { get ; set; }
  
}
