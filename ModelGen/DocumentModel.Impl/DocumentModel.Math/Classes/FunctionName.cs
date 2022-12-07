namespace DocumentModel.Math;

/// <summary>
/// Function Name.
/// </summary>
public class FunctionNameImpl: DocumentModel.Math.OfficeMathArgumentTypeImpl, FunctionName
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
