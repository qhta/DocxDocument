namespace DocumentModel.Spreadsheet;

/// <summary>
/// XML Mapping.
/// </summary>
public class DataBinding: IDataBinding
{
  /// <summary>
  /// DataBindingName
  /// </summary>
  public string? DataBindingName
  {
    get;
    set;
  }
  
  /// <summary>
  /// FileBinding
  /// </summary>
  public bool? FileBinding
  {
    get;
    set;
  }
  
  /// <summary>
  /// ConnectionID
  /// </summary>
  public uint? ConnectionId
  {
    get;
    set;
  }
  
  /// <summary>
  /// FileBindingName
  /// </summary>
  public string? FileBindingName
  {
    get;
    set;
  }
  
  /// <summary>
  /// DataBindingLoadMode
  /// </summary>
  public uint? DataBindingLoadMode
  {
    get;
    set;
  }
  
}
