namespace DocumentModel.Math;

/// <summary>
/// Upper limit (n-ary).
/// </summary>
public class SuperArgumentImpl: DocumentModel.Math.OfficeMathArgumentTypeImpl, SuperArgument
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
