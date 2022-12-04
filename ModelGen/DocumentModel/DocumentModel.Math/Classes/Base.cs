namespace DocumentModel.Math;

/// <summary>
/// Base.
/// </summary>
public class Base: DocumentModel.Math.OfficeMathArgumentType
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
