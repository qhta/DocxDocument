namespace DocumentModel;

/// <summary>
/// Represents the data type for attributes that have enum values that are  values that represent 't' or 'f', or 'true' or 'false'.
/// </summary>
public class TrueFalseBlankValue: ITrueFalseBlankValue
{
  /// <summary>
  /// Gets or sets the value of the simple value.
  /// </summary>
  public bool? Value
  {
    get;
    set;
  }
  
}
