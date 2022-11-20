namespace DocumentModel.InkML;

/// <summary>
/// Defines the Matrix Class.
/// </summary>
public class Matrix: IMatrix
{
  /// <summary>
  /// id
  /// </summary>
  public string? Id
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
