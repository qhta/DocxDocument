namespace DocumentModel.Drawings;


/// <summary>
///   This element defines the fill that is applied to the table as a whole.  The background of the table can contain a single fill that is the entire size of the table.  This can allow for gradient fills, or image fills, which span the entire size of the table.
/// </summary>
public partial class Fill
{
  
  /// <summary>
  ///   NoFill.
  /// </summary>
  public DMD.NoFill? NoFill { get; set; }
  
  
  /// <summary>
  ///   SolidFill.
  /// </summary>
  public DMD.SolidFill? SolidFill { get; set; }
  
  
  /// <summary>
  ///   GradientFill.
  /// </summary>
  public DMD.GradientFill? GradientFill { get; set; }
  
  
  /// <summary>
  ///   BlipFill.
  /// </summary>
  public DMD.BlipFill? BlipFill { get; set; }
  
  
  /// <summary>
  ///   Pattern Fill.
  /// </summary>
  public DMD.PatternFill? PatternFill { get; set; }
  
  
  /// <summary>
  ///   Group Fill.
  /// </summary>
  public DMD.GroupFill? GroupFill { get; set; }
  
}
