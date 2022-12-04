namespace DocumentModel.Math;

/// <summary>
/// Degree.
/// </summary>
public class Degree: DocumentModel.Math.OfficeMathArgumentType
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
