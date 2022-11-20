namespace DocumentModel.Vml;

/// <summary>
/// Defines the TextBox Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITextBoxContent))]
public class TextBox: ITextBox
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Styling Properties
  /// </summary>
  public string? Style
  {
    get;
    set;
  }
  
  /// <summary>
  /// Text Box Inset
  /// </summary>
  public string? Inset
  {
    get;
    set;
  }
  
  /// <summary>
  /// Text Box Single-Click Selection Toggle
  /// </summary>
  public ITrueFalseValue? SingleClick
  {
    get;
    set;
  }
  
}
