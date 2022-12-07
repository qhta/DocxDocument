namespace DocumentModel.Math;

/// <summary>
/// Denominator.
/// </summary>
public class DenominatorImpl: DocumentModel.Math.OfficeMathArgumentTypeImpl, Denominator
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
