namespace DocumentModel.Math;

/// <summary>
/// Lower limit (n-ary) .
/// </summary>
public class SubArgumentImpl: DocumentModel.Math.OfficeMathArgumentTypeImpl, SubArgument
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
