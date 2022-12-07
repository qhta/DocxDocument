namespace DocumentModel.Math;

/// <summary>
/// Degree.
/// </summary>
public class DegreeImpl: DocumentModel.Math.OfficeMathArgumentTypeImpl, Degree
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
