namespace DocumentModel.Math;

/// <summary>
/// Base.
/// </summary>
public class BaseImpl: DocumentModel.Math.OfficeMathArgumentTypeImpl, Base
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
