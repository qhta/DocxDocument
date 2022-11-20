namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Style Label Description.
/// </summary>
public class StyleLabelDescription: IStyleLabelDescription
{
  /// <summary>
  /// Natural Language
  /// </summary>
  public string? Language
  {
    get;
    set;
  }
  
  /// <summary>
  /// Description Value
  /// </summary>
  public string? Val
  {
    get;
    set;
  }
  
}
