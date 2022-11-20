namespace DocumentModel.Vml.Office;

/// <summary>
/// Embedded Object Cannot Be Refreshed.
/// </summary>
public class LockedField: ILockedField
{
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text
  {
    get;
    set;
  }
  
}
