namespace DocumentModel.Drawings;


/// <summary>
///   The list of gradient stops that specifies the gradient colors and their relative positions in the color band.
/// </summary>
public partial class GradientStopList
{
  public ElementCollection<GradientStop>? Items { get; set; }
  
}
