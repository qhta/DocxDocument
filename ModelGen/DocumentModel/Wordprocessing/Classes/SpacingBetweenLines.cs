namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the inter-line and inter-paragraph spacing which shall be applied to the contents of this paragraph when it is displayed by a consumer.
/// </summary>
public partial class SpacingBetweenLines
{
  
  /// <summary>
  ///   Spacing Above Paragraph
  /// </summary>
  [SchemaAttr("w:before")]
  public String? Before { get; set; }
  
  
  /// <summary>
  ///   Spacing Above Paragraph IN Line Units
  /// </summary>
  [SchemaAttr("w:beforeLines")]
  public Int32? BeforeLines { get; set; }
  
  
  /// <summary>
  ///   Automatically Determine Spacing Above Paragraph
  /// </summary>
  [SchemaAttr("w:beforeAutospacing")]
  public Boolean? BeforeAutoSpacing { get; set; }
  
  
  /// <summary>
  ///   Spacing Below Paragraph
  /// </summary>
  [SchemaAttr("w:after")]
  public String? After { get; set; }
  
  
  /// <summary>
  ///   Spacing Below Paragraph in Line Units
  /// </summary>
  [SchemaAttr("w:afterLines")]
  public Int32? AfterLines { get; set; }
  
  
  /// <summary>
  ///   Automatically Determine Spacing Below Paragraph
  /// </summary>
  [SchemaAttr("w:afterAutospacing")]
  public Boolean? AfterAutoSpacing { get; set; }
  
  
  /// <summary>
  ///   Spacing Between Lines in Paragraph
  /// </summary>
  [SchemaAttr("w:line")]
  public String? Line { get; set; }
  
  
  /// <summary>
  ///   Type of Spacing Between Lines
  /// </summary>
  [SchemaAttr("w:lineRule")]
  public DocumentModel.Wordprocessing.LineSpacingRuleValues? LineRule { get; set; }
  
}
