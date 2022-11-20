namespace DocumentModel.Wordprocessing;

/// <summary>
/// Do Not Validate Custom XML Markup Against Schemas.
/// </summary>
public class DoNotValidateAgainstSchema: IDoNotValidateAgainstSchema
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
