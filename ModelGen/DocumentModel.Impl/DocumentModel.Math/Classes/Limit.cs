namespace DocumentModel.Math;

/// <summary>
/// Limit (Lower).
/// </summary>
public class LimitImpl: DocumentModel.Math.OfficeMathArgumentTypeImpl, Limit
{
  public override ArgumentProperties? ArgumentProperties
  {
    get;
    set;
  }
  
  public ControlProperties? ControlProperties
  {
    get;
    set;
  }
  
}
