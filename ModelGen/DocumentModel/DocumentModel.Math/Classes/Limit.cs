namespace DocumentModel.Math;

/// <summary>
/// Limit (Lower).
/// </summary>
public class Limit: DocumentModel.Math.OfficeMathArgumentType
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
