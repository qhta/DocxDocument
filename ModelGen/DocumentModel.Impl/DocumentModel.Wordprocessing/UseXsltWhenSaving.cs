namespace DocumentModel.Wordprocessing;

/// <summary>
/// Save Document as XML File through Custom XSL Transform.
/// </summary>
public class UseXsltWhenSaving: IUseXsltWhenSaving
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val
  {
    get;
    set;
  }
  
}
