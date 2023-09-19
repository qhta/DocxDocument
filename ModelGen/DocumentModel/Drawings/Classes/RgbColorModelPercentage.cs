namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a color using the red, green, blue RGB color model. Each component, red, green, and blue is expressed as a percentage from 0% to 100%. A linear gamma of 1.0 is assumed.
/// </summary>
public partial class RgbColorModelPercentage
{
  
  /// <summary>
  ///   Specifies the percentage of red.
  /// </summary>
  [SchemaAttr("r")]
  public Int32? RedPortion { get; set; }
  
  
  /// <summary>
  ///   Specifies the percentage of green.
  /// </summary>
  [SchemaAttr("g")]
  public Int32? GreenPortion { get; set; }
  
  
  /// <summary>
  ///   Specifies the percentage of blue.
  /// </summary>
  [SchemaAttr("b")]
  public Int32? BluePortion { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.IModelElement>? Items { get; set; }
  
}
