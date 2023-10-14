namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element contains a list of gradient stops. These gradient stops specify the gradient colors and their relative positions in the color band.
/// </summary>
public partial class GradientStopList
{
  public DM.ElementCollection<GradientStop>? Items { get; set; }
  
}
