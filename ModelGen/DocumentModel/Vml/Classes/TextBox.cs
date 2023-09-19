namespace DocumentModel.Vml;


/// <summary>
///   Defines the TextBox Class.
/// </summary>
public partial class TextBox
{
  
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  [SchemaAttr("id")]
  public String? Id { get; set; }
  
  
  /// <summary>
  ///   Shape Styling Properties
  /// </summary>
  [SchemaAttr("style")]
  public String? Style { get; set; }
  
  
  /// <summary>
  ///   Text Box Inset
  /// </summary>
  [SchemaAttr("inset")]
  public String? Inset { get; set; }
  
  
  /// <summary>
  ///   Text Box Single-Click Selection Toggle
  /// </summary>
  [SchemaAttr("o:singleclick")]
  public Boolean? SingleClick { get; set; }
  
  public DocumentModel.Wordprocessing.TextBoxContent? TextBoxContent { get; set; }
  
}
