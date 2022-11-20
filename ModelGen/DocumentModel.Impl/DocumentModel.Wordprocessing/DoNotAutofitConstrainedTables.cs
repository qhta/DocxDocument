namespace DocumentModel.Wordprocessing;

/// <summary>
/// Do Not AutoFit Tables To Fit Next To Wrapped Objects.
/// </summary>
public class DoNotAutofitConstrainedTables: IDoNotAutofitConstrainedTables
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
