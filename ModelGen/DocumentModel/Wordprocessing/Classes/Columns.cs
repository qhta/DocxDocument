namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the Columns Class.
/// </summary>
public partial class Columns
{
  
  /// <summary>
  ///   Equal Column Widths
  /// </summary>
  [SchemaAttr("w:equalWidth")]
  public Boolean? EqualWidth { get; set; }
  
  
  /// <summary>
  ///   Spacing Between Equal Width Columns
  /// </summary>
  [SchemaAttr("w:space")]
  public String? Space { get; set; }
  
  
  /// <summary>
  ///   Number of Equal Width Columns
  /// </summary>
  [SchemaAttr("w:num")]
  public Int16? ColumnCount { get; set; }
  
  
  /// <summary>
  ///   Draw Line Between Columns
  /// </summary>
  [SchemaAttr("w:sep")]
  public Boolean? Separator { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.Wordprocessing.Column>? Items { get; set; }
  
}
