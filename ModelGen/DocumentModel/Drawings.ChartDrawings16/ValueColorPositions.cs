namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the ValueColorPositions Class.
/// </summary>
public partial class ValueColorPositions
{
  
  /// <summary>
  ///   count, this property is only available in Office 2016 and later.
  /// </summary>
  public Int32? Count { get; set; }
  
  
  /// <summary>
  ///   MinValueColorEndPosition.
  /// </summary>
  public DMDCD16.MinValueColorEndPosition? MinValueColorEndPosition { get; set; }
  
  
  /// <summary>
  ///   ValueColorMiddlePosition.
  /// </summary>
  public DMDCD16.ValueColorMiddlePosition? ValueColorMiddlePosition { get; set; }
  
  
  /// <summary>
  ///   MaxValueColorEndPosition.
  /// </summary>
  public DMDCD16.MaxValueColorEndPosition? MaxValueColorEndPosition { get; set; }
  
}
