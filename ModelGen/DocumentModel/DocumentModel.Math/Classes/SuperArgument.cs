namespace DocumentModel.Math;

/// <summary>
/// Upper limit (n-ary).
/// </summary>
public class SuperArgument: DocumentModel.Math.OfficeMathArgumentType
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
