namespace DocumentModel.Office.CustomUI;

/// <summary>
/// Defines the RepurposedCommand Class.
/// </summary>
public class RepurposedCommand: IRepurposedCommand
{
  /// <summary>
  /// onAction
  /// </summary>
  public string? OnAction
  {
    get;
    set;
  }
  
  /// <summary>
  /// enabled
  /// </summary>
  public bool? Enabled
  {
    get;
    set;
  }
  
  /// <summary>
  /// getEnabled
  /// </summary>
  public string? GetEnabled
  {
    get;
    set;
  }
  
  /// <summary>
  /// idMso
  /// </summary>
  public string? IdMso
  {
    get;
    set;
  }
  
}
