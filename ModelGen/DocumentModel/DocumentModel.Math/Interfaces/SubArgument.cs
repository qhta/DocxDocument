namespace DocumentModel.Math;

/// <summary>
/// Lower limit (n-ary) .
/// </summary>
public interface SubArgument
{
  public ArgumentProperties? ArgumentProperties { get ; set; }
  
  public ControlProperties? ControlProperties { get ; set; }
  
}
