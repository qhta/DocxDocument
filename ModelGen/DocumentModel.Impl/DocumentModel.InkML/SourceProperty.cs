namespace DocumentModel.InkML;

/// <summary>
/// Defines the SourceProperty Class.
/// </summary>
public class SourceProperty: ISourceProperty
{
  /// <summary>
  /// name
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// value
  /// </summary>
  public decimal? Value
  {
    get;
    set;
  }
  
  /// <summary>
  /// units
  /// </summary>
  public string? Units
  {
    get;
    set;
  }
  
}
