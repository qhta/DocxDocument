namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a color using the red, green, blue RGB color model. Each component, red, green, and blue is expressed as a percentage from 0% to 100%. A linear gamma of 1.0 is assumed.
/// </summary>
public partial class RgbColorModelPercentage
{
  
  /// <summary>
  ///   Specifies the percentage of red.
  /// </summary>
  public Int32? RedPortion { get; set; }
  
  
  /// <summary>
  ///   Specifies the percentage of green.
  /// </summary>
  public Int32? GreenPortion { get; set; }
  
  
  /// <summary>
  ///   Specifies the percentage of blue.
  /// </summary>
  public Int32? BluePortion { get; set; }
  
}
