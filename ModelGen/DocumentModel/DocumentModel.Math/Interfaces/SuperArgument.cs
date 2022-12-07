namespace DocumentModel.Math;

/// <summary>
/// Upper limit (n-ary).
/// </summary>
public interface SuperArgument
{
  public ArgumentProperties? ArgumentProperties { get ; set; }
  
  public ControlProperties? ControlProperties { get ; set; }
  
}
