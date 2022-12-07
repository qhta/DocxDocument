namespace DocumentModel.Math;

/// <summary>
/// Numerator.
/// </summary>
public class NumeratorImpl: DocumentModel.Math.OfficeMathArgumentTypeImpl, Numerator
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
