namespace DocumentModel.Math;

/// <summary>
/// Lower limit (n-ary) .
/// </summary>
public class SubArgument: DocumentModel.Math.OfficeMathArgumentType
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
