namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the ArgumentDescription Class.
/// </summary>
public class ArgumentDescription: IArgumentDescription
{
  /// <summary>
  /// index, this property is only available in Office 2010 and later.
  /// </summary>
  public uint? Index
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text
  {
    get;
    set;
  }
  
}
