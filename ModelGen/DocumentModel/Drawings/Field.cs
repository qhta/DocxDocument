namespace DocumentModel.Drawings;


/// <summary>
///   Text Field.
/// </summary>
public partial class Field
{
  
  /// <summary>
  ///   Field ID
  /// </summary>
  public String? Id { get; set; }
  
  
  /// <summary>
  ///   Field Type
  /// </summary>
  public String? Type { get; set; }
  
  
  /// <summary>
  ///   Text Character Properties.
  /// </summary>
  public DMD.RunProperties? RunProperties { get; set; }
  
  
  /// <summary>
  ///   Text Paragraph Properties.
  /// </summary>
  public DMD.ParagraphProperties? ParagraphProperties { get; set; }
  
  
  /// <summary>
  ///   Text.
  /// </summary>
  public DMD.Text? Text { get; set; }
  
}
