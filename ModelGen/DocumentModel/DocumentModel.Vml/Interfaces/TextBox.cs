namespace DocumentModel.Vml;

/// <summary>
/// Defines the TextBox Class.
/// </summary>
public partial interface TextBox
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  public String? Id { get; set; }
  
  /// <summary>
  /// Shape Styling Properties
  /// </summary>
  public String? Style { get; set; }
  
  /// <summary>
  /// Text Box Inset
  /// </summary>
  public String? Inset { get; set; }
  
  /// <summary>
  /// Text Box Single-Click Selection Toggle
  /// </summary>
  public Boolean? SingleClick { get; set; }
  
  public DocumentModel.Wordprocessing.TextBoxContent? TextBoxContent { get; set; }
  
}
