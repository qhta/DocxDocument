namespace DocumentModel.Drawings;


/// <summary>
///   This element defines the fill that is applied to the table as a whole.  The background of the table can contain a single fill that is the entire size of the table.  This can allow for gradient fills, or image fills, which span the entire size of the table.
/// </summary>
public partial class Fill
{
  
  /// <summary>
  ///   NoFill.
  /// </summary>
  public Boolean? NoFill { get; set; }
  
  
  /// <summary>
  ///   SolidFill.
  /// </summary>
  public SolidFill? SolidFill { get; set; }
  
  
  /// <summary>
  ///   GradientFill.
  /// </summary>
  public GradientFill? GradientFill { get; set; }
  
  
  /// <summary>
  ///   BlipFill.
  /// </summary>
  public BlipFill? BlipFill { get; set; }
  
  
  /// <summary>
  ///   Pattern Fill.
  /// </summary>
  public PatternFill? PatternFill { get; set; }
  
  
  /// <summary>
  ///   Group Fill.
  /// </summary>
  public Boolean? GroupFill { get; set; }
  
}
